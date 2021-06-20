using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using MeetingAttendance;

namespace UnitTests
{
	[TestClass]
	public class GroupTest
	{
		public static Group GenerateGroup()
		{
			string ID = "group";
			Group group = new Group(ID);

			return group;
		}
		[TestMethod]
		public void ConstructorTest()
		{
			string ID = "group";
			Group group = new Group(ID);

			Assert.AreEqual(ID, group.ID);
		}
		[TestMethod]
		public void TableDataTest()
		{
			Student student = StudentTest.GenerateStudent();

			StudentList.Reset();
			StudentList.Students.Add(student.ID, student);

			GroupList.Reset();
			GroupList.AddGroup("group");
			GroupList.Groups["group"].AddStudent(student.ID);

			DateTime date = new DateTime(2021, 1, 29, 23, 59, 59);
			string[] actual = GroupList.Groups["group"].MakeTableData(date);

			string[] expected = { "0", "group", (1.0 / 2).ToString("P0"), (2.0 / 3).ToString("P0") };

			for (int i = 0; i < 4; ++i)
			{
				Assert.AreEqual(expected[i], actual[i]);
			}


			StudentList.Reset();
			GroupList.Reset();
		}
	}
}