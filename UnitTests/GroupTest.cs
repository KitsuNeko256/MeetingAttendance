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
			int ID = 1;
			string Name = "group";
			Group group = new Group(ID, Name);

			return group;
		}
		[TestMethod]
		public void ConstructorTest()
		{
			int ID = 1;
			string Name = "test";
			Group group = new Group(ID, Name);

			Assert.AreEqual(ID, group.ID);
			Assert.AreEqual(Name, group.Name);
		}
		[TestMethod]
		public void TableDataTest()
		{
			Student student = StudentTest.GenerateStudent();

			StudentList.Students = new Dictionary<int, Student>();
			StudentList.Students.Add(student.ID, student);

			GroupList.Groups = new Dictionary<int, Group>();
			GroupList.AddGroup("group");
			GroupList.Groups[0].AddStudent(student.ID);

			DateTime date = new DateTime(2021, 1, 29, 23, 59, 59);
			string[] actual = GroupList.Groups[0].MakeTableData(date);

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