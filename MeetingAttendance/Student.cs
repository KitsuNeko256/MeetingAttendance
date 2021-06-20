using System;
using System.Collections.Generic;
using System.IO;

namespace MeetingAttendance
{
	public class Student
	{
		private int _id;
		private string _name;
		private readonly List<string> _groupsID = new List<string>();
		private readonly List<Tuple<DateTime, bool>> Attendance = new List<Tuple<DateTime, bool>>();

		public int ID
		{
			get => _id;
			set
			{
				List<string> list = new List<string>(_groupsID);
				foreach (string index in list)
					GroupList.Groups[index].RemoveStudent(ID);
				_id = value;
				foreach (string index in list)
					GroupList.Groups[index].AddStudent(ID);
			}
		}
		public string Name
		{
			get => _name;
			set => _name = value;
		}
		public List<string> GroupsID
		{
			get => _groupsID;
		}
		public Student(int id, string name)
		{
			_id = id;
			_name = name;
		}
		public Student(int id, ref StreamReader reader)
		{
			_id = id;
			Name = reader.ReadLine();
			int groupCount = Int32.Parse(reader.ReadLine());
			for (int i = 0; i < groupCount; ++i)
			{
				_groupsID.Add(reader.ReadLine());
			}
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
			writer.WriteLine(Name);
			writer.WriteLine(_groupsID.Count);
			foreach(string entry in _groupsID)
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
		
		public void ClearGroups()
		{
			List<string> list = new List<string>(_groupsID);
			foreach (string index in list)
			{
				GroupList.Groups[index].RemoveStudent(ID);
			}
		}
		public void AddGroup(string GroupID)
		{
			if (_groupsID.Contains(GroupID))
				return;
			_groupsID.Add(GroupID);
		}
		public void RemoveGroup(string GroupID)
		{
			_groupsID.Remove(GroupID);
		}

		public void	AddAttendance(DateTime date, bool presence)
		{
			Attendance.Add(Tuple.Create(date, presence));
		}
		public double CurrentAttendance(DateTime Now)
		{
			double attended = 0;
			double total = 0;

			for (int i = Attendance.Count - 1; i >= 0; --i)
			{
				if (Attendance[i].Item1.CompareTo(Now) > 0)
					continue;
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

		public static string NullAttendanceMessage()
		{
			return "нет записей";
		}
		public string[] MakeTableData(DateTime Now)
		{
			string[] row = new string[5];
			row[0] = ID.ToString();
			row[1] = Name;
			if(_groupsID.Count > 0)
			{
				foreach (string entry in _groupsID)
				{
					row[2] += GroupList.Groups[entry].ID + ' ';
				}
				row[2] = row[2].Trim();
			}
			double attendance = CurrentAttendance(Now);
			if (attendance == -1)
				row[3] = NullAttendanceMessage();
			else row[3] = attendance.ToString("P0");

			attendance = TotalAttendance();
			if (attendance == -1)
				row[4] = NullAttendanceMessage();
			else row[4] = attendance.ToString("P0");

			return row;
		}
	}
}
