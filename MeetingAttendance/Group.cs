using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MeetingAttendance
{
	class Group
	{
		private int _id;
		private string _name;
		private List<int> _studentsID;
		public int ID
		{
			get => _id;
			set => _id = value;
		}
		public string Name
		{
			get => _name;
			set => _name = value;
		}
		public List<int> StudentsID
		{
			get => _studentsID;
		}
		public Group(int id, string name)
		{
			ID = id;
			Name = name;
			_studentsID = new List<int>();
		}
		public Group(int id, ref StreamReader reader)
		{
			ID = id;
			Name = reader.ReadLine();
			_studentsID = new List<int>();
			int studentCount = Int32.Parse(reader.ReadLine());
			for (int i = 0; i < studentCount; ++i)
			{
				StudentsID.Add(Int32.Parse(reader.ReadLine()));
			}
		}
		public void SaveToFile(ref StreamWriter writer)
		{
			writer.WriteLine(ID);
			writer.WriteLine(Name);
			writer.WriteLine(StudentsID.Count);
			foreach (int entry in StudentsID)
			{
				writer.WriteLine(entry);
			}
		}
		public void Delete()
		{
			List<int> list = new List<int>(_studentsID);
			foreach(int entry in list)
			{
				StudentList.Students[entry].RemoveFromGroup(ID);
			}
		}

		public void AddStudent(int StudentID)
		{
			if (StudentList.Students.ContainsKey(StudentID))
			{
				if (StudentsID.Contains(StudentID))
					return;
				StudentsID.Add(StudentID);
				StudentList.Students[StudentID].AddToGroup(ID);
			}
		}
		public void RemoveStudent(int StudentID)
		{
			if (StudentList.Students.ContainsKey(StudentID))
			{	
				if (StudentsID.Contains(StudentID))
				{
					StudentsID.Remove(StudentID);
					StudentList.Students[StudentID].RemoveFromGroup(ID);
				}
			}
		}

		public double CurrentAttendance()
		{
			double attended = 0;
			double total = 0;
			foreach(int entry in _studentsID)
			{
				double attendance = StudentList.Students[entry].CurrentAttendance();
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
		public string[] MakeTableData()
		{
			string[] row = new string[6];
			row[0] = ID.ToString();
			row[1] = Name;
			double attendance = CurrentAttendance();
			if (attendance == -1)
				row[2] = "нет занятий";
			else row[2] = attendance.ToString("P0");
			attendance = TotalAttendance();
			if (attendance == -1)
				row[3] = "нет занятий";
			else row[3] = TotalAttendance().ToString("P0");
			/*
			foreach (int entry in GroupsID)
			{
				row[3] += GroupList.Groups[entry].Name + "\n";
			}
			row[3].Trim();
			row[4] = "0%";
			row[5] = "0%";
			*/

			return row;
		}
	}
}
