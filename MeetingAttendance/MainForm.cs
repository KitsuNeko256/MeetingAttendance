using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
			studentForm.ShowDialog();
			this.Show();
			StudentList.SaveToFile();
			GroupList.SaveToFile();
		}

		private void GroupsButton_Click(object sender, EventArgs e)
		{
			GroupForm groupForm = new GroupForm();
			this.Hide();
			groupForm.ShowDialog();
			this.Show();
			StudentList.SaveToFile();
			GroupList.SaveToFile();
		}


		private void TeachersButton_Click(object sender, EventArgs e)
		{
			TeacherForm teacherForm = new TeacherForm();
			this.Hide();
			teacherForm.ShowDialog();
			this.Show();
		}
	}
}
