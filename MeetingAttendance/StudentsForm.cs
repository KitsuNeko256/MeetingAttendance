using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeetingAttendance
{

	public partial class StudentsForm : Form
	{
        private void SetupDataGridView()
        {
            studentsGrid.ColumnCount = 6;

            studentsGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            studentsGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            studentsGrid.ColumnHeadersDefaultCellStyle.Font =
                new Font(studentsGrid.Font, FontStyle.Bold);

            studentsGrid.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            studentsGrid.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            studentsGrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            studentsGrid.GridColor = Color.Black;
            studentsGrid.RowHeadersVisible = false;

            studentsGrid.Columns[0].Name = "ID";
            studentsGrid.Columns[0].Visible = false;
            studentsGrid.Columns[1].Name = "Student ID";
            studentsGrid.Columns[1].HeaderText = "Номер";
            studentsGrid.Columns[2].Name = "Name";
            studentsGrid.Columns[2].HeaderText = "Имя";
            studentsGrid.Columns[3].Name = "Group";
            studentsGrid.Columns[3].HeaderText = "Группа";
            studentsGrid.Columns[3].ReadOnly = true;
            studentsGrid.Columns[4].Name = "Month Attendance";
            studentsGrid.Columns[4].HeaderText = "Посещаемость за месяц";
            studentsGrid.Columns[4].ReadOnly = true;
            studentsGrid.Columns[5].Name = "Overall Attendance";
            studentsGrid.Columns[5].HeaderText = "Общая посещаемость";
            studentsGrid.Columns[5].ReadOnly = true;

            studentsGrid.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            studentsGrid.MultiSelect = false;
            studentsGrid.Dock = DockStyle.Fill;
        }

        private void LoadStudentData()
        {
            foreach(Student entry in StudentList.Students.Values)
            {
                studentsGrid.Rows.Add(entry.MakeTableData());
            }
        }

        private void SaveStudentData()
		{
            foreach (DataGridViewRow row in studentsGrid.Rows)
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

        public StudentsForm()
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
	}
}
