using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingAttendance
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void StudentsButton_Click(object sender, EventArgs e)
		{
			StudentForm studentForm = new StudentForm();
			this.Hide();
			studentForm.Location = this.Location;
			studentForm.ShowDialog();
			this.Location = studentForm.Location;
			this.Show();
			StudentList.SaveToFile();
			GroupList.SaveToFile();
		}

		private void GroupsButton_Click(object sender, EventArgs e)
		{
			GroupForm groupForm = new GroupForm();
			this.Hide();
			groupForm.Location = this.Location;
			groupForm.ShowDialog();
			this.Location = groupForm.Location;
			this.Show();
			StudentList.SaveToFile();
			GroupList.SaveToFile();
		}

		private void TeachersButton_Click(object sender, EventArgs e)
		{
			TeacherForm teacherForm = new TeacherForm();
			this.Hide();
			teacherForm.Location = this.Location;
			teacherForm.ShowDialog();
			this.Location = teacherForm.Location;
			this.Show();
			TeacherList.SaveToFile();
		}

		private void ScheduleButton_Click(object sender, EventArgs e)
		{
			ScheduleForm scheduleForm = new ScheduleForm();
			this.Hide();
			scheduleForm.Location = this.Location;
			scheduleForm.ShowDialog();
			this.Location = scheduleForm.Location;
			this.Show();
			LessonList.SaveToFile();
		}
	}
}
