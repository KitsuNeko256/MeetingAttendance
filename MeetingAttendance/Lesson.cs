using System;
using System.Collections.Generic;
using System.IO;

namespace MeetingAttendance
{
	public class Lesson
	{
		public static List<DateTime> StartTimes = new List<DateTime>() {
			new DateTime(1,1,1,8,20,0),
			new DateTime(1,1,1,10,0,0),
			new DateTime(1,1,1,11,40,0),
			new DateTime(1,1,1,13,30,0),
			new DateTime(1,1,1,15,20,0),
			new DateTime(1,1,1,17,0,0),
			new DateTime(1,1,1,18,40,0),
			new DateTime(1,1,1,20,20,0)
		};
		public enum PeriodEnum
		{
			Once, Weekly, Biweekly
		};

		private readonly int _id;

		public DateTime Date = new DateTime();
		public int TeacherID = -1;
		private readonly List<string> _groupsID = new List<string>();

		public readonly List<DateTime> AttendanceRegistered = new List<DateTime>();

		public string Subject;
		public bool Recorded;
		public PeriodEnum _period;
		public string Type;
		public string Link;
		public string Comments;


		public int ID
		{
			get => _id;
		}
		public List<string> GroupsID
		{
			get => _groupsID;
		}
		public string Period
		{
			get
			{
				if (_period == PeriodEnum.Once)
					return "Единожды";
				if (_period == PeriodEnum.Weekly)
					return "Каждую неделю";
				if (_period == PeriodEnum.Biweekly)
					return "Каждые две недели";
				return "Ошибка";
			}
			set
			{
				if (value == "Единожды")
					_period = PeriodEnum.Once;
				else if (value == "Каждую неделю")
					_period = PeriodEnum.Weekly;
				else if (value == "Каждые две недели")
					_period = PeriodEnum.Biweekly;
				else 
					_period = PeriodEnum.Once;
			}

		}
		public string StartTime
		{
			get => (Date.Hour < 10 ? "0" : "") + Date.Hour.ToString() + ":"
					+ (Date.Minute < 10 ? "0" : "") + Date.Minute.ToString();
		}

		public Lesson(int id)
		{
			_id = id;
		}
		public Lesson(int id, ref StreamReader reader)
		{
			_id = id;
			Date = DateTime.Parse(reader.ReadLine());
			TeacherID = Int32.Parse(reader.ReadLine());
			int groupCount = Int32.Parse(reader.ReadLine());
			for (int i = 0; i < groupCount; ++i)
			{
				GroupsID.Add(reader.ReadLine());
			}
			int attendanceCount = Int32.Parse(reader.ReadLine());
			for (int i = 0; i < attendanceCount; ++i)
			{
				AttendanceRegistered.Add(DateTime.Parse(reader.ReadLine()));
			}
			Subject = reader.ReadLine();
			Recorded = bool.Parse(reader.ReadLine());
			Period = reader.ReadLine();
			Type = reader.ReadLine();
			Link = reader.ReadLine();
			Comments = reader.ReadLine();
		}
		public void SaveToFile(ref StreamWriter writer)
		{
			writer.WriteLine(ID);
			writer.WriteLine(Date);
			writer.WriteLine(TeacherID);
			writer.WriteLine(GroupsID.Count);
			foreach (string entry in GroupsID)
			{
				writer.WriteLine(entry);
			}
			writer.WriteLine(AttendanceRegistered.Count); 
			foreach (DateTime entry in AttendanceRegistered)
			{
				writer.WriteLine(entry);
			}
			writer.WriteLine(Subject);
			writer.WriteLine(Recorded);
			writer.WriteLine(Period);
			writer.WriteLine(Type);
			writer.WriteLine(Link);
			writer.WriteLine(Comments);
		}

		public void ClearGroups()
		{
			List<string> list = new List<string>(_groupsID);
			foreach (string index in list)
			{
				RemoveGroup(index);
			}
		}
		public void AddGroup(string GroupID)
		{
			if (GroupsID.Contains(GroupID))
				return;
			if (GroupList.Groups.ContainsKey(GroupID))
			{
				GroupList.Groups[GroupID].AddLesson(ID);
				GroupsID.Add(GroupID);
			}
		}
		public void RemoveGroup(string GroupID)
		{
			if (GroupsID.Contains(GroupID))
			{
				if (GroupList.Groups.ContainsKey(GroupID))
				{
					GroupList.Groups[GroupID].RemoveLesson(ID);
					GroupsID.Remove(GroupID);
				}
			}
		}

		public bool IsNow(DateTime Now)
		{
			if(_period == Lesson.PeriodEnum.Once)
			{
				if(Date == Now)
					return true;
			}
			else if (_period == Lesson.PeriodEnum.Weekly)
			{
				if (Date.DayOfWeek == Now.DayOfWeek
					&& Date.Hour == Now.Hour
					&& Date.Minute == Now.Minute)
					return true;
			}
			else if (_period == Lesson.PeriodEnum.Biweekly)
			{
				if ((int)Date.Subtract(Now).TotalDays % 14 == 0
					&& Date.Hour == Now.Hour
					&& Date.Minute == Now.Minute)
					return true;
			}
			return false;
		}

		public string[] MakeTableData()
		{
			string[] row = new string[6];
			row[0] = ID.ToString();
			row[1] = Subject;
			row[2] = Type;
			row[3] = (TeacherID == -1) ? "" : TeacherList.Teachers[TeacherID].Name;
			if (_groupsID.Count > 0)
			{
				foreach (string entry in _groupsID)
				{
					row[4] += entry + ' ';
				}
				row[4] = row[4].Trim();
			}
			return row;
		}
	}
}
