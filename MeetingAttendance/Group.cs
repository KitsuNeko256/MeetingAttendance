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
		private List<int> StudentsID;
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
		public Group(int id, string name)
		{
			ID = id;
			Name = name;
			StudentsID = new List<int>();
		}
		public Group(int id, ref StreamReader reader)
		{
			ID = id;
			Name = reader.ReadLine();
			StudentsID = new List<int>();
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
		public string[] MakeTableData()
		{
			string[] row = new string[6];
			row[0] = ID.ToString();
			row[1] = Name;
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
