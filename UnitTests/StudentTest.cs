using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
	using System;
	using MeetingAttendance;
	[TestClass]
	public class StudentTest
	{
		Student GenerateStudent()
		{
			int ID = 1;
			int StudentID = 1;
			string Name = "test";
			Student student = new Student(ID, StudentID, Name);

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
			int StudentID = 1;
			string Name = "test";
			Student student = new Student(ID, StudentID, Name);

			Assert.AreEqual(ID, student.ID);
			Assert.AreEqual(StudentID, student.StudentID);
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

		}
		[TestMethod]
		public void TableDataTest()
		{
			Student student = GenerateStudent();

			DateTime date = new DateTime(2021, 1, 29, 23, 59, 59);
			string[] actual = student.MakeTableData(date);

			string[] expected = { "1", "1", "test", "group", (2.0/3).ToString(), (1.0/2).ToString()};

			Assert.AreEqual(actual, expected);
		}
	}
}
