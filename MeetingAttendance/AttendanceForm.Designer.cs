
namespace MeetingAttendance
{
	partial class AttendanceForm
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
			this.UserHelpButton = new System.Windows.Forms.Button();
			this.ScheduleLabel = new System.Windows.Forms.Label();
			this.AttendanceGrid = new System.Windows.Forms.DataGridView();
			this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Attended = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.NotAttended = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.AttendanceGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// UserHelpButton
			// 
			this.UserHelpButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.UserHelpButton.Location = new System.Drawing.Point(546, 12);
			this.UserHelpButton.Name = "UserHelpButton";
			this.UserHelpButton.Size = new System.Drawing.Size(126, 25);
			this.UserHelpButton.TabIndex = 29;
			this.UserHelpButton.Text = "Помощь";
			this.UserHelpButton.UseVisualStyleBackColor = true;
			this.UserHelpButton.Click += new System.EventHandler(this.UserHelpButton_Click);
			// 
			// ScheduleLabel
			// 
			this.ScheduleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ScheduleLabel.AutoSize = true;
			this.ScheduleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ScheduleLabel.Location = new System.Drawing.Point(272, 10);
			this.ScheduleLabel.Name = "ScheduleLabel";
			this.ScheduleLabel.Size = new System.Drawing.Size(115, 25);
			this.ScheduleLabel.TabIndex = 28;
			this.ScheduleLabel.Text = "Расписание";
			// 
			// AttendanceGrid
			// 
			this.AttendanceGrid.AllowUserToAddRows = false;
			this.AttendanceGrid.AllowUserToDeleteRows = false;
			this.AttendanceGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.AttendanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.AttendanceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.Group,
            this.Attended,
            this.NotAttended});
			this.AttendanceGrid.Location = new System.Drawing.Point(12, 55);
			this.AttendanceGrid.Name = "AttendanceGrid";
			this.AttendanceGrid.RowHeadersVisible = false;
			this.AttendanceGrid.RowTemplate.Height = 25;
			this.AttendanceGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.AttendanceGrid.Size = new System.Drawing.Size(660, 344);
			this.AttendanceGrid.TabIndex = 30;
			this.AttendanceGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttendanceGrid_CellValueChanged);
			// 
			// StudentID
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
			this.StudentID.DefaultCellStyle = dataGridViewCellStyle1;
			this.StudentID.HeaderText = "Номер";
			this.StudentID.Name = "StudentID";
			this.StudentID.ReadOnly = true;
			// 
			// StudentName
			// 
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			this.StudentName.DefaultCellStyle = dataGridViewCellStyle2;
			this.StudentName.HeaderText = "Имя";
			this.StudentName.Name = "StudentName";
			this.StudentName.ReadOnly = true;
			// 
			// Group
			// 
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
			this.Group.DefaultCellStyle = dataGridViewCellStyle3;
			this.Group.HeaderText = "Группа";
			this.Group.Name = "Group";
			this.Group.ReadOnly = true;
			// 
			// Attended
			// 
			this.Attended.HeaderText = "Присутствовал";
			this.Attended.Name = "Attended";
			// 
			// NotAttended
			// 
			this.NotAttended.HeaderText = "Не присутствовал";
			this.NotAttended.Name = "NotAttended";
			// 
			// AttendanceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 411);
			this.Controls.Add(this.AttendanceGrid);
			this.Controls.Add(this.UserHelpButton);
			this.Controls.Add(this.ScheduleLabel);
			this.Name = "AttendanceForm";
			this.Text = "Посещаемость на занятии";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AttendanceForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.AttendanceGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button UserHelpButton;
		private System.Windows.Forms.Label ScheduleLabel;
		private System.Windows.Forms.DataGridView AttendanceGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
		private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Group;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Attended;
		private System.Windows.Forms.DataGridViewCheckBoxColumn NotAttended;
	}
}