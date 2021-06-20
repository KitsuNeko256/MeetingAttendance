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
            OldValue = (StudentsGrid.Rows[row].Cells[col].Value == null) 
                ? "" 
                : StudentsGrid.Rows[row].Cells[col].Value.ToString();
		}
        private void StudentsGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection Cells = StudentsGrid.Rows[e.RowIndex].Cells;
            int col = e.ColumnIndex;
            object value = Cells[col].Value;
            //New Student
            if (Cells["CurrentAttendance"].Value == null)
			{
                if (Cells["StudentID"].Value == null)
				{
                    if (Cells["StudentName"].Value == null)
                    {
                        StudentsGrid.Rows.RemoveAt(e.RowIndex);
                        return;
                    }
                    Cells["StudentID"].Style.BackColor = Color.FromArgb(255, 255, 225, 225);
                }
                else if (Cells["StudentName"].Value == null)
                {
                    Cells["StudentName"].Style.BackColor = Color.FromArgb(255, 255, 225, 225);
                }
                else
				{
                    if (!Int32.TryParse(Cells["StudentID"].Value.ToString(), out int ID))
                    {
                        WrongIdError();
                        Cells[col].Value = OldValue;
                        return;
                    }
                    string Name = Cells["StudentName"].Value.ToString();
                    if (StudentList.AddStudent(ID, Name))
                    {
                        Cells["StudentID"].Style.BackColor = Color.White;
                        Cells["StudentName"].Style.BackColor = Color.White;
                        StudentsGrid.Rows[e.RowIndex].SetValues(StudentList.Students[ID].MakeTableData(DateTime.Now));
                    }
                    else
                    {
                        ExistingIdError();
                        Cells[col].Value = OldValue;
                    }
                }
            }
            //ID
            else if (e.ColumnIndex == 0)
            {
				if (value == null || !Int32.TryParse(value.ToString(), out int ID))
				{
					WrongIdError();
					Cells[col].Value = OldValue;
					return;
				}
				if (!StudentList.UpdateStudentID(Int32.Parse(OldValue), ID))
                {
                    ExistingIdError();
                    Cells[col].Value = OldValue;
                }
            }
            //NAME
            else
            {
                if(value == null || String.IsNullOrWhiteSpace(value.ToString()))
                {
                    WrongNameError();
                    Cells[col].Value = OldValue;
                    return;
                }
                int ID = Int32.Parse(Cells["StudentID"].Value.ToString());
                StudentList.UpdateStudentName(ID, value.ToString());
			}
        }
        private void StudentsGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
            bool cancel = MessageBox.Show("Вы уверены что хотите удалить студента?", "Удаление студента", MessageBoxButtons.OKCancel) == DialogResult.Cancel;
            e.Cancel = cancel;
            if (!cancel)
			{
                if (e.Row.Cells["StudentID"].Value != null)
                {
                    int index = Int32.Parse(e.Row.Cells["StudentID"].Value.ToString());
                    StudentList.DeleteStudent(index);
                }
			}
        }

        private void ExistingIdError()
        {
            MessageBox.Show("Этот номер уже занят!", "Недопустимый номер", MessageBoxButtons.OK);
        }
        private void WrongIdError()
		{
            MessageBox.Show("Недопустимый номер студента!", "Недопустимый номер", MessageBoxButtons.OK);
        }
        private void WrongNameError()
        {
            MessageBox.Show("Недопустимое имя студента!", "Недопустимое имя", MessageBoxButtons.OK);
        }

        public StudentForm()
        {
            InitializeComponent();
            LoadStudentData();
        }

		private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
		{
            foreach(DataGridViewRow entry in StudentsGrid.Rows)
			{
                if((entry.Cells["StudentID"].Value == null) ^ (entry.Cells["StudentName"].Value == null))
				{
                    bool cancel = MessageBox.Show("Информация о некоторых студентах недозаполнена. Если вы выйдете, она не сохранится. Выйти?", "Несохраненные записи", MessageBoxButtons.OKCancel) == DialogResult.Cancel;
                    e.Cancel = cancel;
                    return;
                }
			}
        }
    	}
}
