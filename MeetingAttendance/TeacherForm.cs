using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeetingAttendance
{
	public partial class TeacherForm : Form
    {
        private void SetupDataGridView()
        {
            TeachersGrid.ColumnCount = 4;

            TeachersGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            TeachersGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            TeachersGrid.ColumnHeadersDefaultCellStyle.Font =
                new Font(TeachersGrid.Font, FontStyle.Bold);

            TeachersGrid.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            TeachersGrid.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            TeachersGrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            TeachersGrid.GridColor = Color.Black;
            TeachersGrid.RowHeadersVisible = false;

            TeachersGrid.Columns[0].Name = "ID";
            TeachersGrid.Columns[0].Visible = false;
            TeachersGrid.Columns[1].Name = "Name";
            TeachersGrid.Columns[1].HeaderText = "Имя";
            TeachersGrid.Columns[2].Name = "Current Attendance";
            TeachersGrid.Columns[2].HeaderText = "Текущая посещаемость";
            TeachersGrid.Columns[2].ReadOnly = true;
            TeachersGrid.Columns[3].Name = "Total Attendance";
            TeachersGrid.Columns[3].HeaderText = "Общая посещаемость";
            TeachersGrid.Columns[3].ReadOnly = true;

            TeachersGrid.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            TeachersGrid.MultiSelect = false;
        }
        private void LoadTeacherData()
        {
            foreach (Teacher entry in TeacherList.Teachers.Values)
            {
                TeachersGrid.Rows.Add(entry.MakeTableData());
            }
        }

        private string OldValue;
        private void TeachersGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            if (TeachersGrid.Rows[row].Cells[col].Value == null)
                OldValue = "";
            else OldValue = TeachersGrid.Rows[row].Cells[col].Value.ToString();
        }
        private void TeachersGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            object value = TeachersGrid.Rows[row].Cells[col].Value;
            //New Teacher
            if (TeachersGrid.Rows[row].Cells[2].Value == null)
            {
                /*
                if (TeachersGrid.Rows[row].Cells[0].Value == null ||
                    TeachersGrid.Rows[row].Cells[1].Value == null)
                    return;
                int ID;
                if (!Int32.TryParse(TeachersGrid.Rows[row].Cells[0].Value.ToString(), out ID))
                {
                    WrongIdError();
                    return;
                }
                */
                if (TeachersGrid.Rows[row].Cells[1].Value == null)
                    return;
                string Name = TeachersGrid.Rows[row].Cells[1].Value.ToString();
                TeacherList.AddTeacher(Name);
                TeachersGrid.Rows[row].Cells[2].Value = "нет занятий";
                TeachersGrid.Rows[row].Cells[3].Value = "нет занятий";
            }
            /*
            //ID
            else if (e.ColumnIndex == 0)
            {
                if (value == null)
                {
                    WrongIdError();
                    TeachersGrid.Rows[row].Cells[col].Value = OldValue;
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
                    TeachersGrid.Rows[row].Cells[col].Value = OldValue;
                    return;
                }
                int ID = Int32.Parse(TeachersGrid.Rows[row].Cells[0].Value.ToString());
                TeacherList.UpdateTeacher(ID, value.ToString());
            }
        }
        private void TeachersGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            bool cancel = MessageBox.Show("Вы уверены что хотите удалить группу?", "Удаление группы", MessageBoxButtons.OKCancel) == DialogResult.Cancel;
            e.Cancel = cancel;
            if (!cancel)
            {
                if (e.Row.Cells["ID"].Value != null)
                {
                    int index = Int32.Parse(e.Row.Cells["ID"].Value.ToString());
                    TeacherList.DeleteTeacher(index);
                }
            }
        }

        private void WrongNameError()
        {
            MessageBox.Show("Недопустимый код групы!", "Недопустимый код", MessageBoxButtons.OK);
        }

        public TeacherForm()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadTeacherData();
        }

	}
}
