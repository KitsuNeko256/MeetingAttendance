using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MeetingAttendance
{
	class Teacher
	{
		private int _id;
		private string _name;

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

		public Teacher(int id, string name)
		{
			ID = id;
			Name = name;
		}
		public Teacher(int id, ref StreamReader reader)
		{
			ID = id;
			Name = reader.ReadLine();
		}
		public void SaveToFile(ref StreamWriter writer)
		{
			writer.WriteLine(ID);
			writer.WriteLine(Name);
		}
	}
}
