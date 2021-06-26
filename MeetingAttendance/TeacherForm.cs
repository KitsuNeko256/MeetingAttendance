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
        private void LoadTeacherData()
        {
            foreach (Teacher entry in TeacherList.Teachers.Values)
            {
                TeachersGrid.Rows.Add(entry.MakeTableData(DateTime.Now));
            }
        }

        private string OldValue;
        private void TeachersGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            OldValue = (TeachersGrid.Rows[row].Cells[col].Value == null)
                ? ""
                : TeachersGrid.Rows[row].Cells[col].Value.ToString();
        }
        private void TeachersGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection Cells = TeachersGrid.Rows[e.RowIndex].Cells;
            int col = e.ColumnIndex;
            object value = Cells[col].Value;
            //New Teacher
            if (Cells["CurrentAttendance"].Value == null)
            {
                if (Cells["TeacherName"].Value == null)
                    return;
                string Name = Cells[1].Value.ToString();
                int ID = TeacherList.AddTeacher(Name);
                TeachersGrid.Rows[e.RowIndex].SetValues(TeacherList.Teachers[ID].MakeTableData(DateTime.Now));
            }
            //NAME
            else
            {
                if (value == null || String.IsNullOrWhiteSpace(value.ToString()))
                {
                    WrongNameError();
                    Cells[col].Value = OldValue;
                    return;
                }
                int ID = Int32.Parse(Cells["TeacherID"].Value.ToString());
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
            MessageBox.Show("Недопустимое имя преподавателя!", "Недопустимое имя", MessageBoxButtons.OK);
        }

        public TeacherForm()
        {
            InitializeComponent();
            LoadTeacherData();
        }

		private void UserHelpButton_Click(object sender, EventArgs e)
		{
            string Text = "Советы:\n"
                + "Для добавления преподавателя введите имя в свободной строке.\n"
                + "Для удаления выделите преподавателя и нажмите Delete.\n"
                + "Для возвращения в главное меню закройте список студентов.\n"
                + "Данные сохраняются автоматически при закрытии списка.";
            MessageBox.Show(Text, "Справка", MessageBoxButtons.OK);
        }
	}
}
