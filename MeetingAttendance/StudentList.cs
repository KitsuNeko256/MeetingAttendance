using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MeetingAttendance
{
	class StudentList
	{
		private static int nextID = 0;
		public static Dictionary<int, Student> Students;

		public static void LoadFromFile()
		{
			Students = new Dictionary<int, Student>();
			if (Directory.Exists("data"))
			{
				if (File.Exists("data\\students.txt"))
				{
					StreamReader reader = new StreamReader("data\\students.txt");
					int count = Int32.Parse(reader.ReadLine());
					for (int i = 0; i < count; ++i)
					{
						int id = Int32.Parse(reader.ReadLine());
						Students[id] = new Student(id, ref reader);
						nextID = Math.Max(nextID, id);
					}			
					reader.Close();
				}
			}
			++nextID;	
		}
		public static void SaveToFile()
		{
			if (!Directory.Exists("data"))
			{
				Directory.CreateDirectory("data");
			}
			StreamWriter writer = new StreamWriter("data\\students.txt");
			
			writer.WriteLine(Students.Count);
			foreach(Student entry in Students.Values)
			{
				entry.SaveToFile(ref writer);
			}

			writer.Close();
		}
		
		public static int GetStudentID(string name)
		{
			foreach(Student entry in Students.Values)
			{
				if(entry.Name == name)
				{
					return entry.ID;
				}
			}
			return -1;
		}
		public static int AddStudent(int studentID, string name)
		{
			int id = nextID;
			++nextID;

			Students[id] = new Student(id, studentID, name);

			return id;	
		}
		public static void UpdateStudent(int index, int studentID, string name)
		{
			Students[index].Name = name;
			Students[index].StudentID = studentID;
		}
		public static void DeleteStudent(int index)
		{
			Students[index].Delete();
			Students.Remove(index);
		}
	}
}
