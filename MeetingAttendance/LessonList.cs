using System;
using System.Collections.Generic;
using System.IO;

namespace MeetingAttendance
{
	class LessonList
	{
		public static int currentLessonID = 0;
		public static DateTime ScheduleDate = new DateTime();

		private static int nextID = 0;
		private static readonly Dictionary<int, Lesson> _lessons = new Dictionary<int, Lesson>();

		public static Lesson CurrentLesson
		{
			get => _lessons[currentLessonID];
		}

		public static Dictionary<int, Lesson> Lessons
		{
			get => _lessons;
		}

		public static void LoadFromFile()
		{
			if (Directory.Exists("data"))
			{
				if (File.Exists("data\\lessons.txt"))
				{
					StreamReader reader = new StreamReader("data\\lessons.txt");
					int count = Int32.Parse(reader.ReadLine());
					for (int i = 0; i < count; ++i)
					{
						int id = Int32.Parse(reader.ReadLine());
						Lessons[id] = new Lesson(id, ref reader);
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
			StreamWriter writer = new StreamWriter("data\\lessons.txt");

			writer.WriteLine(Lessons.Count);
			foreach (Lesson entry in Lessons.Values)
			{
				entry.SaveToFile(ref writer);
			}

			writer.Close();
		}

		public static int AddLesson()
		{
			int id = nextID;
			++nextID;

			Lessons[id] = new Lesson(id);

			return id;
		}
		public static void DeleteLesson(int index)
		{
			Lessons[index].ClearGroups();
			Lessons.Remove(index);
		}

		public static void Reset()
		{
			Lessons.Clear();
		}
	}
}
