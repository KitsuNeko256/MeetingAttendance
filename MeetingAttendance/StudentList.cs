using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MeetingAttendance
{
	class StudentList
	{
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
					}			
					reader.Close();
				}
			}	
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
		
		public static int FindStudent(string name)
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
		public static bool AddStudent(int id, string name)
		{
			if (Students.ContainsKey(id))
			{
				return false;
			}
			Students[id] = new Student(id, name);
			return true;
		}
		public static bool UpdateStudentID(int oldID, int newID)
		{
			if (!Students.ContainsKey(oldID) || Students.ContainsKey(newID)) 
				return false;
			if (oldID != newID)
			{
				Students[newID] = Students[oldID];
				Students[newID].ChangeID(newID);
				Students.Remove(oldID);
			}
			return true;
		}
		public static void UpdateStudentName(int id, string name)
		{
			Students[id].Name = name;
		}
		public static void DeleteStudent(int index)
		{
			Students[index].Delete();
			Students.Remove(index);
		}
	}
}
