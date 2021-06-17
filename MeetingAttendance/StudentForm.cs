using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeetingAttendance
{

	public partial class StudentForm : Form
	{
        private void SetupDataGridView()
        {
            StudentsGrid.ColumnCount = 5;

            StudentsGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            StudentsGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            StudentsGrid.ColumnHeadersDefaultCellStyle.Font =
                new Font(StudentsGrid.Font, FontStyle.Bold);

            StudentsGrid.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            StudentsGrid.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            StudentsGrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            StudentsGrid.GridColor = Color.Black;
            StudentsGrid.RowHeadersVisible = false;

            StudentsGrid.Columns[0].Name = "ID";
            StudentsGrid.Columns[0].HeaderText = "Студенческий Номер";
            StudentsGrid.Columns[1].Name = "Name";
            StudentsGrid.Columns[1].HeaderText = "Имя";
            StudentsGrid.Columns[2].Name = "Group";
            StudentsGrid.Columns[2].HeaderText = "Группа";
            StudentsGrid.Columns[2].ReadOnly = true;
            StudentsGrid.Columns[3].Name = "Current Attendance";
            StudentsGrid.Columns[3].HeaderText = "Текущая посещаемость";
            StudentsGrid.Columns[3].ReadOnly = true;
            StudentsGrid.Columns[4].Name = "Total Attendance";
            StudentsGrid.Columns[4].HeaderText = "Общая посещаемость";
            StudentsGrid.Columns[4].ReadOnly = true;

            StudentsGrid.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            StudentsGrid.MultiSelect = false;
        }
        private void LoadStudentData()
        {
            foreach(Student entry in StudentList.Students.Values)
            {
                StudentsGrid.Rows.Add(entry.MakeTableData(DateTime.Now));
            }
        }

        private string OldValue;
		private void StudentsGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            if (StudentsGrid.Rows[row].Cells[col].Value == null)
                OldValue = "";
            else OldValue = StudentsGrid.Rows[row].Cells[col].Value.ToString();
		}
        private void StudentsGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            object value = StudentsGrid.Rows[row].Cells[col].Value;
            //New Student
            if (StudentsGrid.Rows[row].Cells[3].Value == null)
			{
                if (StudentsGrid.Rows[row].Cells[0].Value == null ||
                    StudentsGrid.Rows[row].Cells[1].Value == null)
                        return;
                int ID;
                if(!Int32.TryParse(StudentsGrid.Rows[row].Cells[0].Value.ToString(), out ID))
                {
                    WrongIdError();
                    StudentsGrid.Rows[row].Cells[col].Value = OldValue;
                    return;
                }
                string Name = StudentsGrid.Rows[row].Cells[1].Value.ToString();
                if (StudentList.AddStudent(ID, Name))
                {
                    StudentsGrid.Rows[row].Cells[3].Value = "нет занятий";
                    StudentsGrid.Rows[row].Cells[4].Value = "нет занятий";
                }
				else
				{
                    ExistingIdError();
                    StudentsGrid.Rows[row].Cells[col].Value = OldValue;
                }
            }
            //ID
            else if (e.ColumnIndex == 0) 
			{
                if (value == null)
                {
					WrongIdError();
                    StudentsGrid.Rows[row].Cells[col].Value = OldValue;
                    return;
                }
                StudentList.UpdateStudentID(Int32.Parse(OldValue.ToString()), Int32.Parse(value.ToString()));
			}
            //NAME
            else
            {
                if(value == null)
				{
                    WrongNameError();
                    StudentsGrid.Rows[row].Cells[col].Value = OldValue;
                    return;
                }
                int ID = Int32.Parse(StudentsGrid.Rows[row].Cells[0].Value.ToString());
                StudentList.UpdateStudentName(ID, value.ToString());
			}
        }
        private void StudentsGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
            bool cancel = MessageBox.Show("Вы уверены что хотите удалить студента?", "Удаление студента", MessageBoxButtons.OKCancel) == DialogResult.Cancel;
            e.Cancel = cancel;
            if (!cancel)
			{
                if (e.Row.Cells["ID"].Value != null)
                {
                    int index = Int32.Parse(e.Row.Cells["ID"].Value.ToString());
                    StudentList.DeleteStudent(index);
                }
			}
        }

        private void ExistingIdError()
        {
            MessageBox.Show("Этот номер уже занят!", "Неверный номер", MessageBoxButtons.OK);
        }
        private void WrongIdError()
		{
            MessageBox.Show("Неверный номер студента!", "Неверный номер", MessageBoxButtons.OK);
        }
        private void WrongNameError()
        {
            MessageBox.Show("Недопустимое имя студента!", "Недопустимое имя", MessageBoxButtons.OK);
        }

        public StudentForm()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadStudentData();
        }
	}
}
