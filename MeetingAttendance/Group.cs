using System;
using System.Collections.Generic;
using System.IO;

namespace MeetingAttendance
{
	public class Group
	{
		private string _id;
		private readonly List<int> _studentsID = new List<int>();
		private readonly List<int> _lessonsID = new List<int>();
		
		public string ID
		{
			get => _id;
			set
			{
				foreach (int entry in StudentsID)
				{
					StudentList.Students[entry].RemoveGroup(ID);
					StudentList.Students[entry].AddGroup(value);
				}
				List<int> list = new List<int>(LessonsID);
				foreach (int entry in list)
				{
					LessonList.Lessons[entry].RemoveGroup(ID);
				}
				_id = value;
				foreach (int entry in list)
				{
					LessonList.Lessons[entry].AddGroup(value);
				}
			}
		}
		public List<int> StudentsID
		{
			get => _studentsID;
		}
		public List<int> LessonsID
		{
			get => _lessonsID;
		}
		
		public Group(string id)
		{
			_id = id;
		}
		public Group(string id, ref StreamReader reader)
		{
			_id = id;
			int studentCount = Int32.Parse(reader.ReadLine());
			for (int i = 0; i < studentCount; ++i)
			{
				StudentsID.Add(Int32.Parse(reader.ReadLine()));
			}
			int lessonsCount = Int32.Parse(reader.ReadLine());
			for (int i = 0; i < lessonsCount; ++i)
			{
				LessonsID.Add(Int32.Parse(reader.ReadLine()));
			}
		}
		public void SaveToFile(ref StreamWriter writer)
		{
			writer.WriteLine(ID);
			writer.WriteLine(StudentsID.Count);
			foreach (int entry in StudentsID)
			{
				writer.WriteLine(entry);
			}
			writer.WriteLine(LessonsID.Count);
			foreach (int entry in LessonsID)
			{
				writer.WriteLine(entry);
			}
		}
		
		public void ClearStudents()
		{
			List<int> list = new List<int>(_studentsID);
			foreach(int entry in list)
			{
				StudentList.Students[entry].RemoveGroup(ID);
			}
			_studentsID.Clear();
		}

		public void AddStudent(int StudentID)
		{
			if (StudentsID.Contains(StudentID))
				return;
			if (StudentList.Students.ContainsKey(StudentID))
			{
				StudentList.Students[StudentID].AddGroup(ID);
				StudentsID.Add(StudentID);
			}
		}
		public void RemoveStudent(int StudentID)
		{
			if (StudentsID.Contains(StudentID))
			{
				if (StudentList.Students.ContainsKey(StudentID))
				{
					StudentList.Students[StudentID].RemoveGroup(ID);
					StudentsID.Remove(StudentID);
				}
			}
		}

		public void AddLesson(int LessonID)
		{
			if (LessonsID.Contains(LessonID))
				return;
			LessonsID.Add(LessonID);
		}
		public void RemoveLesson(int LessonID)
		{
			LessonsID.Remove(LessonID);
		}

		public double CurrentAttendance(DateTime Now)
		{
			if (StudentsID.Count == 0)
				return -2;
			double attended = 0;
			double total = 0;
			foreach(int entry in _studentsID)
			{
				double attendance = StudentList.Students[entry].CurrentAttendance(Now);
				if (attendance >= 0)
				{
					attended += attendance;
					total++;
				}
			}

			if (total == 0)
				return -1;
			return attended / total;
		}
		public double TotalAttendance()
		{
			if (StudentsID.Count == 0)
				return -2;
			double attended = 0;
			double total = 0;
			foreach (int entry in _studentsID)
			{
				double attendance = StudentList.Students[entry].TotalAttendance();
				if (attendance >= 0)
				{
					attended += attendance;
					total++;
				}
			}

			if (total == 0)
				return -1;
			return attended / total;
		}

		public static string NoStudentsMessage()
		{
			return "нет студентов";
		}
		public string[] MakeTableData(DateTime Now)
		{
			string[] row = new string[3];
			row[0] = ID.ToString();

			double attendance = CurrentAttendance(Now);
			if (attendance == -2)
				row[1] = NoStudentsMessage();
			else if (attendance == -1)
				row[1] = Student.NullAttendanceMessage();
			else row[1] = attendance.ToString("P0");

			attendance = TotalAttendance();
			if (attendance == -2)
				row[2] = NoStudentsMessage();
			else if (attendance == -1)
				row[2] = Student.NullAttendanceMessage();
			else row[2] = attendance.ToString("P0");

			return row;
		}
	}
}
