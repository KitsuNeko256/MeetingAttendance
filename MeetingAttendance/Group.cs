using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MeetingAttendance
{
	public class Group
	{
		private string _id;
		private readonly List<int> _studentsID = new List<int>();
		
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
				_id = value;
			}
		}
		public List<int> StudentsID
		{
			get => _studentsID;
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
		}
		public void SaveToFile(ref StreamWriter writer)
		{
			writer.WriteLine(ID);
			writer.WriteLine(StudentsID.Count);
			foreach (int entry in StudentsID)
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
