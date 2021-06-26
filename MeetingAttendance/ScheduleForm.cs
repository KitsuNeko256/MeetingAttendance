using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeetingAttendance
{
	public partial class ScheduleForm : Form
	{
		private void LoadLessonTimes()
		{
			foreach(DateTime entry in Lesson.StartTimes)
			{
				string time = (entry.Hour < 10 ? "0" : "") + entry.Hour.ToString() + ":" 
					+ (entry.Minute < 10 ? "0" : "") + entry.Minute.ToString();
				LessonTimesList.Items.Add(time);
			}
		}

		private void LessonDatePicker_ValueChanged(object sender, EventArgs e)
		{
			UnloadLessons();
			LoadLessons();
		}
		private void LessonTimesList_SelectedIndexChanged(object sender, EventArgs e)
		{
			UnloadLessons();
			LoadLessons();
		}
		private void UnloadLessons()
		{
			LessonDataGrid.Rows.Clear();
		}
		private void LoadLessons()
		{
			DateTime t = LessonDatePicker.Value;
			DateTime ChosenDate = new DateTime(t.Year, t.Month, t.Day, 
				Lesson.StartTimes[LessonTimesList.SelectedIndex].Hour, 
				Lesson.StartTimes[LessonTimesList.SelectedIndex].Minute, 
				Lesson.StartTimes[LessonTimesList.SelectedIndex].Second);
			LessonList.ScheduleDate = ChosenDate;
			int i = 0;
			foreach (Lesson entry in LessonList.Lessons.Values)
			{
				if (entry.IsNow(ChosenDate))
				{
					LessonDataGrid.Rows.Add(entry.MakeTableData());
					if (entry.AttendanceRegistered.Contains(ChosenDate) || !entry.Recorded)
						LessonDataGrid.Rows[i].Cells["AttendanceRegistered"].Value = true;
					++i;
				}
			}
		}

		private void AddLessonButton_Click(object sender, EventArgs e)
		{
			LessonList.currentLessonID = LessonList.AddLesson();

			DateTime Date = LessonDatePicker.Value;
			int index = LessonTimesList.SelectedIndex;
			DateTime StartTime = Lesson.StartTimes[index];
			LessonList.CurrentLesson.Date = new DateTime(Date.Year, Date.Month, Date.Day,
				StartTime.Hour, StartTime.Minute, StartTime.Second);

			StartLessonForm();
		}
		private void EditLessonButton_Click(object sender, EventArgs e)
		{
			if(LessonDataGrid.SelectedRows == null)
			{
				MessageBox.Show("Выберите занятия для редактирования!", "Занятие не выбрано", MessageBoxButtons.OK);
			}
			LessonList.currentLessonID = Int32.Parse(LessonDataGrid.SelectedRows[0].Cells[0].Value.ToString());
			StartLessonForm();
		}
		private void AttendanceButton_Click(object sender, EventArgs e)	
		{
			if (LessonDataGrid.SelectedRows == null || LessonDataGrid.SelectedRows[0].Cells[0].Value == null)
			{
				MessageBox.Show("Выберите занятия для редактирования!", "Занятие не выбрано", MessageBoxButtons.OK);
				return;
			}
			LessonList.currentLessonID = Int32.Parse(LessonDataGrid.SelectedRows[0].Cells[0].Value.ToString());
			if (!LessonList.CurrentLesson.Recorded)
			{
				MessageBox.Show("Для необязательных занятий нельзя проставить посещаемость!", "Занятие не обязательно", MessageBoxButtons.OK);
				return;
			}
			if (LessonList.CurrentLesson.GroupsID.Count == 0)
			{
				MessageBox.Show("На занятие не записана ни одна группа!", "Нет групп", MessageBoxButtons.OK);
				return;
			}
			DateTime Date = LessonDatePicker.Value;
			int index = LessonTimesList.SelectedIndex;
			DateTime StartTime = Lesson.StartTimes[index];
			LessonList.CurrentLesson.Date = new DateTime(Date.Year, Date.Month, Date.Day,
				StartTime.Hour, StartTime.Minute, StartTime.Second);

			if (LessonList.CurrentLesson.AttendanceRegistered.Contains(LessonList.CurrentLesson.Date))
			{
				MessageBox.Show("Посещаемость для этого занятия уже выставлена!", "Посещаемость уже выставлена", MessageBoxButtons.OK);
				return;
			}

			AttendanceForm attendanceForm = new AttendanceForm();
			attendanceForm.ShowDialog();

			StudentList.SaveToFile();
			TeacherList.SaveToFile();
			LessonList.SaveToFile();

			UnloadLessons();
			LoadLessons();
		}

		private void StartLessonForm()
		{
			LessonForm lessonForm = new LessonForm();
			lessonForm.ShowDialog();
			UnloadLessons();
			LoadLessons();
		}

		public ScheduleForm()
		{
			InitializeComponent();
			LoadLessonTimes();
			LessonTimesList.SelectedIndex = 0;
		}

		private void LessonDataGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			bool cancel = MessageBox.Show("Вы уверены что хотите удалить занятие?", "Удаление занятия", MessageBoxButtons.OKCancel) == DialogResult.Cancel;
			e.Cancel = cancel;
			if (!cancel)
			{
				if (e.Row.Cells["ID"].Value != null)
				{
					int index = Int32.Parse(e.Row.Cells["ID"].Value.ToString());
					LessonList.DeleteLesson(index);
				}
			}
		}

		private void UserHelpButton_Click(object sender, EventArgs e)
		{
			string Text = "Советы:\n"
				+ "Слева выберите нужную дату и время начала занятия.\n"
				+ "Для изменения занятия выберите его в таблице и нажмите кнопку снизу.\n"
				+ "При добавлении занятия дата выставляется на выбранную в окне расписания.\n"
				+ "Для удаления выделите занятие и нажмите Delete.\n"
				+ "Для возвращения в главное меню закройте расписание.\n"
				+ "Данные сохраняются автоматически при закрытии расписания.";
			MessageBox.Show(Text, "Справка", MessageBoxButtons.OK);
		}

	}
}
