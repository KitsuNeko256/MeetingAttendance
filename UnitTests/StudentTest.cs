using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using MeetingAttendance;

namespace UnitTests
{

	[TestClass]
	public class StudentTest
	{
		public static Student GenerateStudent()
		{
			int ID = 1;
			string Name = "test";
			Student student = new Student(ID, Name);

			DateTime date = new DateTime(2020, 12, 31, 23, 59, 59);
			student.AddAttendance(date, true);
			date = new DateTime(2021, 1, 1, 0, 0, 1);
			student.AddAttendance(date, false);
			date = new DateTime(2021, 5, 15, 12, 30, 00);
			student.AddAttendance(date, true);

			return student;
		}
		[TestMethod]
		public void ConstructorTest()
		{
			int ID = 1;
			string Name = "test";
			Student student = new Student(ID, Name);

			Assert.AreEqual(ID, student.ID);
			Assert.AreEqual(Name, student.Name);
		}
		[TestMethod]
		public void AttendanceTest()
		{
			Student student = GenerateStudent();

			Assert.AreEqual(2.0 / 3, student.TotalAttendance());

			DateTime date = new DateTime(2021, 1, 29, 23, 59, 59);

			Assert.AreEqual(1.0 / 2, student.CurrentAttendance(date));

			date = new DateTime(2021, 5, 15, 12, 30, 00);

			Assert.AreEqual(1, student.CurrentAttendance(date));
		}
		[TestMethod]
		public void GroupTest()
		{
			Student student = GenerateStudent();

			StudentList.Students = new Dictionary<int, Student>();
			StudentList.Students.Add(student.ID, student);

			GroupList.Groups = new Dictionary<int, Group>();
			GroupList.AddGroup("group");
			GroupList.Groups[0].AddStudent(student.ID);

			Assert.AreEqual(0, student.GroupsID[0]);
			Assert.AreEqual(1, GroupList.Groups[0].StudentsID[0]);

			StudentList.UpdateStudentID(1, 2);

			Assert.AreEqual(0, student.GroupsID[0]);
			Assert.AreEqual(2, GroupList.Groups[0].StudentsID[0]);

			student.Delete();

			Assert.AreEqual(0, student.GroupsID.Count);

			StudentList.Reset();
			GroupList.Reset();
		}
		[TestMethod]
		public void TableDataTest()
		{
			Student student = GenerateStudent();

			StudentList.Students = new Dictionary<int, Student>();
			StudentList.Students.Add(student.ID, student);

			GroupList.Groups = new Dictionary<int, Group>();
			GroupList.AddGroup("group");
			GroupList.Groups[0].AddStudent(student.ID);

			DateTime date = new DateTime(2021, 1, 29, 23, 59, 59);
			string[] actual = student.MakeTableData(date);

			string[] expected = { "1", "test", "group", (1.0/2).ToString("P0"), (2.0/3).ToString("P0") };

			for(int i = 0; i < 5; ++i)
			{
				Assert.AreEqual(expected[i], actual[i]);
			}


			StudentList.Reset();
			GroupList.Reset();
		}
	}
}
