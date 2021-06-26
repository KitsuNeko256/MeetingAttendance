using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeetingAttendance
{
	public partial class AttendanceForm : Form
	{
		private void LoadStudentList()
		{
			List<int> students = new List<int>();
			foreach (string entry in LessonList.CurrentLesson.GroupsID)
			{
				foreach (int studentID in GroupList.Groups[entry].StudentsID)
				{
					if (!students.Contains(studentID))
						students.Add(studentID);
				}
			}
			foreach (int entry in students)
			{
				Student t = StudentList.Students[entry];
				string groups = "";
				foreach(string group in t.GroupsID)
				{
					groups += group + ' ';
				}
				groups = groups.Trim();
				string[] row = { t.ID.ToString(), t.Name, groups };
				AttendanceGrid.Rows.Add(row);
			}
		}
		private void AttendanceGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1)
				return;
			DataGridViewCellCollection Cells = AttendanceGrid.Rows[e.RowIndex].Cells;
			int col = e.ColumnIndex;
			if ((bool)Cells[col].Value)
			{
				if (col == 3)
				{
					Cells[4].Value = false;
				}
				else Cells[3].Value = false;
			}
			this.Update();
		}

		public AttendanceForm()
		{
			InitializeComponent();
			LoadStudentList();
		}

		private void UserHelpButton_Click(object sender, EventArgs e)
		{
			string Text = "Советы:\n"
				+ "Для каждого студента отметьте, был он на занятии или нет.\n"
				+ "Отметить обязательно для всех студентов, иначе данные не сохранятся.\n"
				+ "После успешнего сохранения данных изменить их невозможно.\n"
				+ "Для возвращения в главное меню закройте таблицу посещения.\n"
				+ "Данные сохраняются автоматически при закрытии таблицы.";
			MessageBox.Show(Text, "Справка", MessageBoxButtons.OK);
		}

		private void AttendanceForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			foreach (DataGridViewRow entry in AttendanceGrid.Rows)
			{
				if ((entry.Cells["Attended"].Value == null || !(bool)entry.Cells["Attended"].Value)
					&& (entry.Cells["NotAttended"].Value == null || !(bool)entry.Cells["NotAttended"].Value))
				{
					bool cancel = MessageBox.Show("Не для всех студентов проставлена посещаемость. Если вы выйдете, она не сохранится. Выйти?", "Несохраненные записи", MessageBoxButtons.OKCancel) == DialogResult.Cancel;
					e.Cancel = cancel;
					return;
				}
			}

			double attended = 0;
			double total = AttendanceGrid.RowCount;
			foreach (DataGridViewRow entry in AttendanceGrid.Rows)
			{
				if ((bool)entry.Cells["Attended"].Value)
				{
					attended++;
					StudentList.Students[Int32.Parse(entry.Cells["StudentID"].Value.ToString())].AddAttendance(LessonList.CurrentLesson.Date, true);
				}
				else StudentList.Students[Int32.Parse(entry.Cells["StudentID"].Value.ToString())].AddAttendance(LessonList.CurrentLesson.Date, false);
			}

			TeacherList.Teachers[LessonList.CurrentLesson.TeacherID].AddAttendance(LessonList.CurrentLesson.Date, attended / total);

			LessonList.CurrentLesson.AttendanceRegistered.Add(LessonList.CurrentLesson.Date);
		}

	}
}
