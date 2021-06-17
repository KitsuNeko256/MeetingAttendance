using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MeetingAttendance
{
	class GroupList
	{
		private static int nextID = 0;
		public static Dictionary<int, Group> Groups;

		public static void LoadFromFile()
		{
			Groups = new Dictionary<int, Group>();
			if (Directory.Exists("data"))
			{
				if (File.Exists("data\\groups.txt"))
				{
					StreamReader reader = new StreamReader("data\\groups.txt");
					int count = Int32.Parse(reader.ReadLine());
					for (int i = 0; i < count; ++i)
					{
						int id = Int32.Parse(reader.ReadLine());
						Groups[id] = new Group(id, ref reader);
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
			StreamWriter writer = new StreamWriter("data\\groups.txt");

			writer.WriteLine(Groups.Count);
			foreach (Group entry in Groups.Values)
			{
				entry.SaveToFile(ref writer);
			}

			writer.Close();
		}

		public static int AddGroup(string name)
		{
			int id = nextID;
			++nextID;

			Groups[id] = new Group(id, name);

			return id;
		}
		public static void UpdateGroup(int index, string name)
		{
			Groups[index].Name = name;
		}
		public static void DeleteGroup(int index)
		{
			Groups[index].Delete();
			Groups.Remove(index);
		}
	}
}
