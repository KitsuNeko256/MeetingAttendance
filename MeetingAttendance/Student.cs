using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MeetingAttendance
{
	class Student
	{
		private int _id;
		private int _studentID;
		private string _name;
		private List<int> GroupsID;
		private List<Tuple<DateTime, bool>> Attendance;

		public int ID
		{
			get => _id;
			set => _id = value;
		}
		public int StudentID
		{
			get => _studentID;
			set => _studentID = value;
		}
		public string Name
		{
			get => _name;
			set => _name = value;
		}
		public Student(int id, int studentID, string name)
		{
			ID = id;
			StudentID = studentID;
			Name = name;
			GroupsID = new List<int>();
			Attendance = new List<Tuple<DateTime, bool>>();
		}
		public Student(int id, ref StreamReader reader)
		{
			ID = id;
			StudentID = Int32.Parse(reader.ReadLine());
			Name = reader.ReadLine();
			GroupsID = new List<int>();
			int groupCount = Int32.Parse(reader.ReadLine());
			for (int i = 0; i < groupCount; ++i)
			{
				GroupsID.Add(Int32.Parse(reader.ReadLine()));
			}
			Attendance = new List<Tuple<DateTime, bool>>();
			int attendanceCount = Int32.Parse(reader.ReadLine());
			for (int i = 0; i < attendanceCount; ++i)
			{
				string date = reader.ReadLine();
				string presence = reader.ReadLine();
				AddAttendance(DateTime.Parse(date), bool.Parse(presence));
			}
		}
		public void SaveToFile(ref StreamWriter writer)
		{
			writer.WriteLine(ID);
			writer.WriteLine(StudentID);
			writer.WriteLine(Name);
			writer.WriteLine(GroupsID.Count);
			foreach(int entry in GroupsID)
			{
				writer.WriteLine(entry);
			}
			writer.WriteLine(Attendance.Count);
			foreach(Tuple<DateTime, bool> entry in Attendance)
			{
				writer.WriteLine(entry.Item1);
				writer.WriteLine(entry.Item2);
			}
		}
		public void Delete()
		{
			List<int> list = new List<int>(GroupsID);
			foreach (int index in list)
			{
				GroupList.Groups[index].RemoveStudent(ID);
			}
		}

		public void AddToGroup(int GroupID)
		{
			if (GroupsID.Contains(GroupID))
				return;
			GroupsID.Add(GroupID);
		}
		public void RemoveFromGroup(int GroupID)
		{
			GroupsID.Remove(GroupID);
		}

		public void	AddAttendance(DateTime date, bool presence)
		{
			Attendance.Add(Tuple.Create(date, presence));
		}
		public double CurrentAttendance()
		{
			DateTime Now = DateTime.Now;
			double attended = 0;
			double total = 0;

			for (int i = Attendance.Count - 1; i >= 0; --i)
			{
				TimeSpan diff = Now.Subtract(Attendance[i].Item1);
				if (diff.TotalDays > 30)
					break;
				++total;
				if (Attendance[i].Item2)
					++attended;
			}

			if (total == 0)
				return -1;
			return attended / total;
		}
		public double TotalAttendance()
		{
			double attended = 0;
			double total = Attendance.Count;
			if (total == 0)
				return -1;

			foreach (Tuple<DateTime, bool> entry in Attendance)
			{
				if (entry.Item2)
					attended++;
			}

			return attended/total;
		}

		public string[] MakeTableData()
		{
			string[] row = new string[6];
			row[0] = ID.ToString();
			row[1] = StudentID.ToString();
			row[2] = Name;
			if(GroupsID.Count > 0)
			{
				foreach (int entry in GroupsID)
				{
					row[3] += GroupList.Groups[entry].Name + " ";
				}
				row[3].Trim();
			}
			double attendance = CurrentAttendance();
			if (attendance == -1)
				row[4] = "нет занятий";
			else row[4] = attendance.ToString("P0");
			attendance = TotalAttendance();
			if (attendance == -1)
				row[5] = "нет занятий";
			else row[5] = TotalAttendance().ToString("P0");

			return row;
		}
	}
}
