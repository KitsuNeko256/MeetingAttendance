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
            StudentsGrid.ColumnCount = 6;

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
            StudentsGrid.Columns[0].Visible = false;
            StudentsGrid.Columns[1].Name = "Student ID";
            StudentsGrid.Columns[1].HeaderText = "Студенческий Номер";
            StudentsGrid.Columns[2].Name = "Name";
            StudentsGrid.Columns[2].HeaderText = "Имя";
            StudentsGrid.Columns[3].Name = "Group";
            StudentsGrid.Columns[3].HeaderText = "Группа";
            StudentsGrid.Columns[3].ReadOnly = true;
            StudentsGrid.Columns[4].Name = "Current Attendance";
            StudentsGrid.Columns[4].HeaderText = "Текущая посещаемость";
            StudentsGrid.Columns[4].ReadOnly = true;
            StudentsGrid.Columns[5].Name = "Total Attendance";
            StudentsGrid.Columns[5].HeaderText = "Общая посещаемость";
            StudentsGrid.Columns[5].ReadOnly = true;

            StudentsGrid.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            StudentsGrid.MultiSelect = false;
        }

        private void LoadStudentData()
        {
            foreach(Student entry in StudentList.Students.Values)
            {
                StudentsGrid.Rows.Add(entry.MakeTableData());
            }
        }

        private void SaveStudentData()
		{
            foreach (DataGridViewRow row in StudentsGrid.Rows)
            {
                if (row.Cells["Name"].Value == null)
                {
                    continue;
                }

                int StudentID = Int32.Parse(row.Cells["Student ID"].Value.ToString());
                string Name = row.Cells["Name"].Value.ToString();
                if (row.Cells["ID"].Value == null)
                {
                    row.Cells["ID"].Value = StudentList.AddStudent(StudentID, Name);
				}
                else
                {
                    int index = Int32.Parse(row.Cells["ID"].Value.ToString());
                    StudentList.UpdateStudent(index, StudentID, Name);
                }
            }

        }

        public StudentForm()
		{
			InitializeComponent();
            SetupDataGridView();
            LoadStudentData();
        }

		private void StudentsForm_Shown(object sender, EventArgs e)
        {

        }

		private void studentsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
            SaveStudentData();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
            Close();
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
    }
}
