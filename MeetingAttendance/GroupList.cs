using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MeetingAttendance
{
	public class GroupList
	{
		private static readonly Dictionary<string, Group> _groups = new Dictionary<string, Group>();

		public static Dictionary<string, Group> Groups
		{
			get => _groups;
		}

		public static void LoadFromFile()
		{
			if (Directory.Exists("data"))
			{
				if (File.Exists("data\\groups.txt"))
				{
					StreamReader reader = new StreamReader("data\\groups.txt");
					int count = Int32.Parse(reader.ReadLine());
					for (int i = 0; i < count; ++i)
					{
						string id = reader.ReadLine();
						Groups[id] = new Group(id, ref reader);
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
			StreamWriter writer = new StreamWriter("data\\groups.txt");

			writer.WriteLine(Groups.Count);
			foreach (Group entry in Groups.Values)
			{
				entry.SaveToFile(ref writer);
			}

			writer.Close();
		}

		public static bool AddGroup(string id)
		{
			if (Groups.ContainsKey(id))
			{
				return false;
			}
			Groups[id] = new Group(id);
			return true;
		}
		public static bool UpdateGroup(string oldID, string newID)
		{
			if (oldID == newID)
				return true;
			if (!Groups.ContainsKey(oldID) || Groups.ContainsKey(newID))
				return false;
			Groups[newID] = Groups[oldID];
			Groups[newID].ID = newID;
			Groups.Remove(oldID);
			return true;
		}
		public static void DeleteGroup(string id)
		{
			Groups[id].ClearStudents();
			Groups.Remove(id);
		}

		public static void Reset()
		{
			_groups.Clear();
		}
	}
}
