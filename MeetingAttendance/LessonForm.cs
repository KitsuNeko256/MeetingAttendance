using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeetingAttendance
{
	public partial class LessonForm : Form
	{
		private void FillStartTimeComboBox()
		{
			foreach (DateTime entry in Lesson.StartTimes)
			{
				string time = (entry.Hour < 10 ? "0" : "") + entry.Hour.ToString() + ":"
					+ (entry.Minute < 10 ? "0" : "") + entry.Minute.ToString();
				StartTimeComboBox.Items.Add(time);
			}
		}
		private void FillTeacherComboBox()
		{
			AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
			foreach (Teacher entry in TeacherList.Teachers.Values)
			{
				TeacherBox.Items.Add(entry.Name);
				collection.Add(entry.Name);
			}
			TeacherBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
			TeacherBox.AutoCompleteCustomSource = collection;
			TeacherBox.AutoCompleteMode = AutoCompleteMode.Append;
		}
		private void FillPeriodBox()
		{
			Lesson t = new Lesson(-1);
			t._period = Lesson.PeriodEnum.Once;
			PeriodBox.Items.Add(t.Period);
			t._period = Lesson.PeriodEnum.Weekly;
			PeriodBox.Items.Add(t.Period);
			t._period = Lesson.PeriodEnum.Biweekly;
			PeriodBox.Items.Add(t.Period);
		}
		private void FillTypeBox()
		{
			string[] types =
			{
				"Лекция",
				"Практика",
				"Лабораторная",
				"Экзамен"
			};
			AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
			foreach (string entry in types)
			{
				TypeBox.Items.Add(entry);
				collection.Add(entry);
			}
			TypeBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
			TypeBox.AutoCompleteCustomSource = collection;
			TypeBox.AutoCompleteMode = AutoCompleteMode.Append;
		}
		private void LoadLessonData()
		{
			Lesson lesson = LessonList.CurrentLesson;
			SubjectBox.Text = lesson.Subject;
			if (lesson.TeacherID != -1)
				TeacherBox.Text = TeacherList.Teachers[lesson.TeacherID].Name;
			TypeBox.Text = lesson.Type;
			LinkBox.Text = lesson.Link;

			PeriodBox.Text = lesson.Period; 
			LessonDatePicker.Value = lesson.Date;
			StartTimeComboBox.Text = lesson.StartTime;
			RecordedCheckBox.Checked = lesson.Recorded;

			foreach (string id in lesson.GroupsID)
			{
				LessonGroupList.Items.Add(id);
			}

			CommentsBox.Text = lesson.Comments;
		}

		private void SubjectBox_TextChanged(object sender, EventArgs e)
		{
			LessonList.CurrentLesson.Subject = SubjectBox.Text;
		}
		private void TeacherBox_Leave(object sender, EventArgs e)
		{
			int id = TeacherList.FindTeacher(TeacherBox.Text);
			if (id == -1)
			{
				MessageBox.Show("Преподаватель с таким именем не найден!", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				TeacherBox.Text = (LessonList.CurrentLesson.TeacherID == -1)
					? ""
					: TeacherList.Teachers[LessonList.CurrentLesson.TeacherID].Name;
				return;
			}
			LessonList.CurrentLesson.TeacherID = id;
		}
		private void TeacherBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			int id = TeacherList.FindTeacher(TeacherBox.Text);
			if (id == -1)
			{
				MessageBox.Show("Преподаватель с таким именем не найден!", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				TeacherBox.Text = (LessonList.CurrentLesson.TeacherID == -1)
					? ""
					: TeacherList.Teachers[LessonList.CurrentLesson.TeacherID].Name;
				return;
			}
			LessonList.CurrentLesson.TeacherID = id;
		}
		private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			LessonList.CurrentLesson.Type = TypeBox.Text;
		}
		private void LinkBox_TextChanged(object sender, EventArgs e)
		{
			LessonList.CurrentLesson.Link = LinkBox.Text;
		}

		private void PeriodBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			LessonList.CurrentLesson.Period = PeriodBox.Text;
		}
		private void DateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			DateTime OldDate = LessonList.CurrentLesson.Date;
			DateTime NewDate = LessonDatePicker.Value;
			LessonList.CurrentLesson.Date = new DateTime(NewDate.Year, NewDate.Month, NewDate.Day, 
				OldDate.Hour, OldDate.Minute, OldDate.Second);
		}
		private void StartTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			DateTime OldDate = LessonList.CurrentLesson.Date;
			int index = StartTimeComboBox.SelectedIndex;
			DateTime NewDate = Lesson.StartTimes[index];
			LessonList.CurrentLesson.Date = new DateTime(OldDate.Year, OldDate.Month, OldDate.Day,
				NewDate.Hour, NewDate.Minute, NewDate.Second);
		}
		private void RecordedCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			LessonList.CurrentLesson.Recorded = RecordedCheckBox.Checked;
		}

		private void CommentsBox_TextChanged(object sender, EventArgs e)
		{
			LessonList.CurrentLesson.Comments = CommentsBox.Text;
		}

		private void FillGroupComboBox()
		{
			AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
			foreach (string entry in GroupList.Groups.Keys)
			{	
				GroupComboBox.Items.Add(entry);
				collection.Add(entry);
			}
			GroupComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
			GroupComboBox.AutoCompleteCustomSource = collection;
			GroupComboBox.AutoCompleteMode = AutoCompleteMode.Append;
		}
		private void AddGroupButton_Click(object sender, EventArgs e)
		{
			string GroupID = GroupComboBox.Text;
			if (!GroupList.Groups.ContainsKey(GroupID))
			{
				MessageBox.Show("Группа с таким кодом не найдена!", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (LessonGroupList.Items.Contains(GroupID))
			{
				MessageBox.Show("Группа уже добавлена на занятие!", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			LessonList.CurrentLesson.AddGroup(GroupID);
			LessonGroupList.Items.Add(GroupID);
		}
		private void RemoveGroupButton_Click(object sender, EventArgs e)
		{
			if (LessonGroupList.SelectedItem == null)
			{
				MessageBox.Show("Выберите группу из списка!", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string GroupID = LessonGroupList.SelectedItem.ToString();

			if (!GroupList.Groups.ContainsKey(GroupID))
			{
				MessageBox.Show("Группа с таким кодом не найдена!", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			LessonList.CurrentLesson.RemoveGroup(GroupID);
			LessonGroupList.Items.Remove(GroupID);
		}

		public LessonForm()
		{
			InitializeComponent();
			FillTeacherComboBox();
			FillTypeBox();
			FillPeriodBox();
			FillStartTimeComboBox();
			FillGroupComboBox();
			LoadLessonData();
		}

		private void UserHelpButton_Click(object sender, EventArgs e)
		{
			string Text = "Советы:\n"
				+ "Поля Предмет и Преподаватель обязательны.\n"
				+ "Необходимо ввести оба значения, иначе занятие не сохранится.\n"
				+ "Преподаватель должен быть добавлен в список преподавателей.\n"
				+ "Для возвращения в главное меню закройте окно занятия.\n"
				+ "Данные сохраняются автоматически при закрытии окна.";
			MessageBox.Show(Text, "Справка", MessageBoxButtons.OK);
		}

		private void LessonForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (String.IsNullOrWhiteSpace(SubjectBox.Text) 
				|| String.IsNullOrWhiteSpace(TeacherBox.Text))
			{
				bool cancel = MessageBox.Show("Поля Предмет и Преподаватель обязательны для заполнения. Если вы выйдете не заполнив их, занятие не сохранится. Выйти?", "Незаполненные поля", MessageBoxButtons.OKCancel) == DialogResult.Cancel;
				e.Cancel = cancel;
				if (!cancel)
				{
					LessonList.DeleteLesson(LessonList.currentLessonID);
				}
				return;
			}
		}

	}
}
