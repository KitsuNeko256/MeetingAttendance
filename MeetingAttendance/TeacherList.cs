﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MeetingAttendance
{
	class TeacherList
	{
		private static int nextID = 0;
		public static Dictionary<int, Teacher> Teachers;
		public static void LoadFromFile()
		{
			Teachers = new Dictionary<int, Teacher>();
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
	}
}