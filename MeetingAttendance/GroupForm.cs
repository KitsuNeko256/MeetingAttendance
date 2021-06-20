using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeetingAttendance
{
	public partial class GroupForm : Form
	{
        private void LoadGroupData()
        {
            foreach (Group entry in GroupList.Groups.Values)
            {
                GroupsGrid.Rows.Add(entry.MakeTableData(DateTime.Now));
            }
        }

        private string OldValue;
        private void GroupsGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            OldValue = (GroupsGrid.Rows[row].Cells[col].Value == null)
                ? ""
                : GroupsGrid.Rows[row].Cells[col].Value.ToString();
        }
        private void GroupsGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection Cells = GroupsGrid.Rows[e.RowIndex].Cells;
            int col = e.ColumnIndex;
            object value = Cells[col].Value;
            //New Group
            if (Cells["CurrentAttendance"].Value == null)
            {
                if (Cells["ID"].Value == null)
                    return;
                string ID = Cells["ID"].Value.ToString();
				if (GroupList.AddGroup(ID))
                {
                    GroupsGrid.Rows[e.RowIndex].SetValues(GroupList.Groups[ID].MakeTableData(DateTime.Now));
                }
                else
                {
                    ExistingIdError();
                    Cells[col].Value = OldValue;
                }
            }
            //ID
            else
            {
                if (value == null || String.IsNullOrWhiteSpace(value.ToString()))
                {
                    WrongIdError();
                    Cells[col].Value = OldValue;
                }
                else if (!GroupList.UpdateGroup(OldValue, value.ToString()))
                {
                    ExistingIdError();
                    Cells[col].Value = OldValue;
                }
                else
				{
                    UpdateCurrentGroup(value.ToString());
				}
            }
        }
        private void GroupsGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            bool cancel = MessageBox.Show("Вы уверены что хотите удалить группу?", "Удаление группы", MessageBoxButtons.OKCancel) == DialogResult.Cancel;
            e.Cancel = cancel;
            if (!cancel)
            {
                if (e.Row.Cells["ID"].Value != null)
                {
                    string id = e.Row.Cells["ID"].Value.ToString();
                    GroupList.DeleteGroup(id);
                }
                UpdateCurrentGroup(null);
            }
        }

        private void ExistingIdError()
        {
            MessageBox.Show("Этот код группы уже занят!", "Недопустимый код", MessageBoxButtons.OK);
        }
        private void WrongIdError()
        {
            MessageBox.Show("Недопустимый код группы!", "Недопустимый код", MessageBoxButtons.OK);
        }

        private string CurrentGroupIndex;

        private void GroupsGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = GroupsGrid.Rows[e.RowIndex];
            UpdateCurrentGroup((Row == null || Row.Cells["ID"].Value == null)
                ? null
                : Row.Cells["ID"].Value.ToString());
        }
        private void UpdateCurrentGroup(string NewGroupIndex)
        {
			if (CurrentGroupIndex == NewGroupIndex)
				return;
            CurrentGroupIndex = NewGroupIndex;
            CurrentGroupList.Items.Clear();
            if (CurrentGroupIndex == null)
            {
                AddStudentButton.Enabled = false;
                RemoveStudentButton.Enabled = false;
                return;
            }
            AddStudentButton.Enabled = true;
            RemoveStudentButton.Enabled = true;
            foreach (int entry in GroupList.Groups[CurrentGroupIndex].StudentsID)
            {
                CurrentGroupList.Items.Add(StudentList.Students[entry].Name);
            }
        }

        private void FillStudentsComboBox()
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
			foreach (Student entry in StudentList.Students.Values)
			{
				StudentsComboBox.Items.Add(entry.Name);
				collection.Add(entry.Name);
			}
            StudentsComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            StudentsComboBox.AutoCompleteCustomSource = collection;
            StudentsComboBox.AutoCompleteMode = AutoCompleteMode.Append;
        }
        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            string Name = StudentsComboBox.Text;
            int ID = StudentList.FindStudent(Name);
            if (ID == -1)
			{
                MessageBox.Show("Студент с таким именем не найден!", "ОшиSбка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
			}
            if (GroupList.Groups[CurrentGroupIndex].StudentsID.Contains(ID))
            {
                MessageBox.Show("Студент уже добавлен в группу!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
			}
            GroupList.Groups[CurrentGroupIndex].AddStudent(ID);
			CurrentGroupList.Items.Add(StudentList.Students[ID].Name);
            GroupsGrid.Rows[GroupsGrid.CurrentCell.RowIndex].SetValues(GroupList.Groups[CurrentGroupIndex].MakeTableData(DateTime.Now));
        }
        private void RemoveStudentButton_Click(object sender, EventArgs e)
        {
            if(CurrentGroupList.SelectedItem == null)
			{
                MessageBox.Show("Выберите студента из списка!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string Name = CurrentGroupList.SelectedItem.ToString();
            int ID = StudentList.FindStudent(Name);
            if (ID == -1)
            {
                MessageBox.Show("Студент с таким именем не найден!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GroupList.Groups[CurrentGroupIndex].RemoveStudent(ID);
            CurrentGroupList.Items.Remove(Name);
            GroupsGrid.Rows[GroupsGrid.CurrentCell.RowIndex].SetValues(GroupList.Groups[CurrentGroupIndex].MakeTableData(DateTime.Now));
        }

        public GroupForm()
        {
            InitializeComponent();
            LoadGroupData();
            FillStudentsComboBox();
        }

	}
}
