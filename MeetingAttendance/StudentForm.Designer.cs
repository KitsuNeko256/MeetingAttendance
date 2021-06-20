
namespace MeetingAttendance
{
	partial class StudentForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
			this.StudentsGrid = new System.Windows.Forms.DataGridView();
			this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Groups = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CurrentAttendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalAttendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TipsLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.StudentsGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// StudentsGrid
			// 
			this.StudentsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.StudentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.StudentsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.Groups,
            this.CurrentAttendance,
            this.TotalAttendance});
			this.StudentsGrid.Location = new System.Drawing.Point(12, 12);
			this.StudentsGrid.MultiSelect = false;
			this.StudentsGrid.Name = "StudentsGrid";
			this.StudentsGrid.RowHeadersVisible = false;
			this.StudentsGrid.RowTemplate.Height = 25;
			this.StudentsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.StudentsGrid.Size = new System.Drawing.Size(760, 400);
			this.StudentsGrid.TabIndex = 0;
			this.StudentsGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.StudentsGrid_CellBeginEdit);
			this.StudentsGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsGrid_CellEndEdit);
			this.StudentsGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.StudentsGrid_UserDeletingRow);
			// 
			// StudentID
			// 
			this.StudentID.FillWeight = 50F;
			this.StudentID.HeaderText = "Студенческий Номер";
			this.StudentID.Name = "StudentID";
			// 
			// StudentName
			// 
			this.StudentName.HeaderText = "Имя студента";
			this.StudentName.Name = "StudentName";
			// 
			// Groups
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
			this.Groups.DefaultCellStyle = dataGridViewCellStyle1;
			this.Groups.FillWeight = 50F;
			this.Groups.HeaderText = "Группы";
			this.Groups.Name = "Groups";
			this.Groups.ReadOnly = true;
			// 
			// CurrentAttendance
			// 
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			this.CurrentAttendance.DefaultCellStyle = dataGridViewCellStyle2;
			this.CurrentAttendance.FillWeight = 75F;
			this.CurrentAttendance.HeaderText = "Посещаемость за последние 30 дней";
			this.CurrentAttendance.Name = "CurrentAttendance";
			this.CurrentAttendance.ReadOnly = true;
			// 
			// TotalAttendance
			// 
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
			this.TotalAttendance.DefaultCellStyle = dataGridViewCellStyle3;
			this.TotalAttendance.FillWeight = 75F;
			this.TotalAttendance.HeaderText = "Посещаемость за всё время";
			this.TotalAttendance.Name = "TotalAttendance";
			this.TotalAttendance.ReadOnly = true;
			// 
			// TipsLabel
			// 
			this.TipsLabel.AutoSize = true;
			this.TipsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TipsLabel.Location = new System.Drawing.Point(12, 435);
			this.TipsLabel.Name = "TipsLabel";
			this.TipsLabel.Size = new System.Drawing.Size(623, 105);
			this.TipsLabel.TabIndex = 1;
			this.TipsLabel.Text = resources.GetString("TipsLabel.Text");
			// 
			// StudentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 549);
			this.Controls.Add(this.TipsLabel);
			this.Controls.Add(this.StudentsGrid);
			this.Name = "StudentForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Студенты";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.StudentsGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView StudentsGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
		private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Groups;
		private System.Windows.Forms.DataGridViewTextBoxColumn CurrentAttendance;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalAttendance;
		private System.Windows.Forms.Label TipsLabel;
	}
}