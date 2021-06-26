using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MeetingAttendance
{
	public class TeacherList
	{
		private static int nextID = 0;
		public static readonly Dictionary<int, Teacher> Teachers = new Dictionary<int, Teacher>();
		public static void LoadFromFile()
		{
			if (Directory.Exists("data"))
			{
				if (File.Exists("data\\teachers.txt"))
				{
					StreamReader reader = new StreamReader("data\\teachers.txt");
					int count = Int32.Parse(reader.ReadLine());
					for (int i = 0; i < count; ++i)
					{
						int id = Int32.Parse(reader.ReadLine());
						Teachers[id] = new Teacher(id, ref reader);
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
			StreamWriter writer = new StreamWriter("data\\teachers.txt");

			writer.WriteLine(Teachers.Count);
			foreach (Teacher entry in Teachers.Values)
			{
				entry.SaveToFile(ref writer);
			}

			writer.Close();
		}

		public static int FindTeacher(string name)
		{
			foreach (Teacher entry in Teachers.Values)
			{
				if (entry.Name == name)
				{
					return entry.ID;
				}
			}
			return -1;
		}
		public static int AddTeacher(string name)
		{
			int id = nextID;
			++nextID;

			Teachers[id] = new Teacher(id, name);

			return id;
		}
		public static void UpdateTeacher(int index, string name)
		{
			Teachers[index].Name = name;
		}
		public static void DeleteTeacher(int index)
		{
			Teachers.Remove(index);
		}
		
		public static void Reset()
		{
			nextID = 0;
			Teachers.Clear();
		}
	}
}
