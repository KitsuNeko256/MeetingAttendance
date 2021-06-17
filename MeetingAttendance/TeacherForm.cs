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

        private void SaveTeacherData()
        {
            foreach (DataGridViewRow row in TeachersGrid.Rows)
            {
                if (row.Cells["Name"].Value == null)
                {
                    continue;
                }

                string Name = row.Cells["Name"].Value.ToString();
                if (row.Cells["ID"].Value == null)
                {
                    row.Cells["ID"].Value = TeacherList.AddTeacher(Name);
                }
                else
                {
                    int index = Int32.Parse(row.Cells["ID"].Value.ToString());
                    TeacherList.UpdateTeacher(index, Name);
                }
            }

        }
        public TeacherForm()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadTeacherData();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveTeacherData();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
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
	}
}
