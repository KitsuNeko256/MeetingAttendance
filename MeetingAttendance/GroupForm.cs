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

        private void SetupDataGridView()
        {
            GroupsGrid.ColumnCount = 4;

            GroupsGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            GroupsGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            GroupsGrid.ColumnHeadersDefaultCellStyle.Font =
                new Font(GroupsGrid.Font, FontStyle.Bold);

            GroupsGrid.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            GroupsGrid.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            GroupsGrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            GroupsGrid.GridColor = Color.Black;
            GroupsGrid.RowHeadersVisible = false;

            GroupsGrid.Columns[0].Name = "ID";
            GroupsGrid.Columns[0].Visible = false;
            GroupsGrid.Columns[1].Name = "Name";
            GroupsGrid.Columns[1].HeaderText = "Код группы";
            GroupsGrid.Columns[2].Name = "Current Attendance";
            GroupsGrid.Columns[2].HeaderText = "Текущая посещаемость";
            GroupsGrid.Columns[2].ReadOnly = true;
            GroupsGrid.Columns[3].Name = "Total Attendance";
            GroupsGrid.Columns[3].HeaderText = "Общая посещаемость";
            GroupsGrid.Columns[3].ReadOnly = true;

            GroupsGrid.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            GroupsGrid.MultiSelect = false;
        }
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
            if (GroupsGrid.Rows[row].Cells[col].Value == null)
                OldValue = "";
            else OldValue = GroupsGrid.Rows[row].Cells[col].Value.ToString();
        }
        private void GroupsGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            object value = GroupsGrid.Rows[row].Cells[col].Value;
            //New Group
            if (GroupsGrid.Rows[row].Cells[2].Value == null)
            {
                /*
                if (GroupsGrid.Rows[row].Cells[0].Value == null ||
                    GroupsGrid.Rows[row].Cells[1].Value == null)
                    return;
                int ID;
                if (!Int32.TryParse(GroupsGrid.Rows[row].Cells[0].Value.ToString(), out ID))
                {
                    WrongIdError();
                    return;
                }
                */
                if (GroupsGrid.Rows[row].Cells[1].Value == null)
                    return;
                string Name = GroupsGrid.Rows[row].Cells[1].Value.ToString();
                GroupList.AddGroup(Name);
                GroupsGrid.Rows[row].Cells[2].Value = "нет занятий";
                GroupsGrid.Rows[row].Cells[3].Value = "нет занятий";
            }
            /*
            //ID
            else if (e.ColumnIndex == 0)
            {
                if (value == null)
                {
                    WrongIdError();
                    GroupsGrid.Rows[row].Cells[col].Value = OldValue;
                    return;
                }
                StudentList.UpdateStudentID(Int32.Parse(OldValue.ToString()), Int32.Parse(value.ToString()));
            }
            */
            //NAME
            else
            {
                if (value == null)
                {
                    WrongNameError();
                    GroupsGrid.Rows[row].Cells[col].Value = OldValue;
                    return;
                }
                int ID = Int32.Parse(GroupsGrid.Rows[row].Cells[0].Value.ToString());
                GroupList.UpdateGroup(ID, value.ToString());
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
                    int index = Int32.Parse(e.Row.Cells["ID"].Value.ToString());
                    GroupList.DeleteGroup(index);
                }
                CurrentGroupIndex--;
                UpdateCurrentGroup();
            }
        }

        private void WrongIdError()
        {
            MessageBox.Show("Неверный номер группы!", "Неверный номер", MessageBoxButtons.OK);
        }
        private void WrongNameError()
        {
            MessageBox.Show("Недопустимый код групы!", "Недопустимый код", MessageBoxButtons.OK);
        }

        private int CurrentGroupIndex = 0;
        private void GroupsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			if (GroupsGrid.CurrentRow.Cells["ID"].Value == null)
			{
                return;
			}
            CurrentGroupIndex = Int32.Parse(GroupsGrid.CurrentRow.Cells["ID"].Value.ToString());
            UpdateCurrentGroup();
        }
        private void UpdateCurrentGroup()
        {
            CurrentGroupList.Items.Clear();
            if (CurrentGroupIndex < 0)
                return;
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
                MessageBox.Show("Студент с таким именем не найден!", "Ошибка",
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
        }
        private void RemoveStudentButton_Click(object sender, EventArgs e)
        {
            string Name = CurrentGroupList.SelectedItem.ToString();
            int ID = StudentList.FindStudent(Name);
            if (ID == -1)
            {
                //student doesn't exist error
                return;
            }
            GroupList.Groups[CurrentGroupIndex].RemoveStudent(ID);
            CurrentGroupList.Items.Remove(Name);
        }

        public GroupForm()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadGroupData();
            UpdateCurrentGroup();
            FillStudentsComboBox();
        }

	}
}
