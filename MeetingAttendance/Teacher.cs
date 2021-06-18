﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MeetingAttendance
{
	public class Teacher
	{
		private int _id;
		private string _name;
		private List<Tuple<DateTime, double>> Attendance;

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
			Attendance = new List<Tuple<DateTime, double>>();
		}
		public Teacher(int id, ref StreamReader reader)
		{
			ID = id;
			Name = reader.ReadLine();
			Attendance = new List<Tuple<DateTime, double>>();
			int attendanceCount = Int32.Parse(reader.ReadLine());
			for (int i = 0; i < attendanceCount; ++i)
			{
				string date = reader.ReadLine();
				string presence = reader.ReadLine();
				AddAttendance(DateTime.Parse(date), double.Parse(presence));
			}
		}
		public void SaveToFile(ref StreamWriter writer)
		{
			writer.WriteLine(ID);
			writer.WriteLine(Name);
			writer.WriteLine(Attendance.Count);
			foreach (Tuple<DateTime, double> entry in Attendance)
			{
				writer.WriteLine(entry.Item1);
				writer.WriteLine(entry.Item2);
			}
		}

		public void AddAttendance(DateTime date, double presence)
		{
			Attendance.Add(Tuple.Create(date, presence));
		}
		public double CurrentAttendance()
		{
			DateTime Now = DateTime.Now;
			double attended = 0;
			double total = 0;

			for (int i = Attendance.Count - 1; i >= 0; --i)
			{
				TimeSpan diff = Now.Subtract(Attendance[i].Item1);
				if (diff.TotalDays > 30)
					break;
				attended += Attendance[i].Item2;
				total++; 
			}

			if (total == 0)
				return -1;
			return attended / total;
		}
		public double TotalAttendance()
		{
			double attended = 0;
			double total = Attendance.Count;
			if (total == 0)
				return -1;

			foreach (Tuple<DateTime, double> entry in Attendance)
			{
				attended += entry.Item2;
			}

			return attended / total;
		}

		public string[] MakeTableData()
		{
			string[] row = new string[6];
			row[0] = ID.ToString();
			row[1] = Name;
			double attendance = CurrentAttendance();
			if (attendance == -1)
				row[2] = "нет занятий";
			else row[2] = attendance.ToString("P0");
			attendance = TotalAttendance();
			if (attendance == -1)
				row[3] = "нет занятий";
			else row[3] = TotalAttendance().ToString("P0");
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
