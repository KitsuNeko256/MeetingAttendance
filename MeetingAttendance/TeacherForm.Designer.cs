
namespace MeetingAttendance
{
	partial class TeacherForm
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
			this.TeachersGrid = new System.Windows.Forms.DataGridView();
			this.TeacherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CurrentAttendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalAttendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserHelpButton = new System.Windows.Forms.Button();
			this.TeacherLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.TeachersGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// TeachersGrid
			// 
			this.TeachersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.TeachersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TeachersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeacherID,
            this.TeacherName,
            this.CurrentAttendance,
            this.TotalAttendance});
			this.TeachersGrid.Location = new System.Drawing.Point(12, 44);
			this.TeachersGrid.MultiSelect = false;
			this.TeachersGrid.Name = "TeachersGrid";
			this.TeachersGrid.RowHeadersVisible = false;
			this.TeachersGrid.RowTemplate.Height = 25;
			this.TeachersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.TeachersGrid.Size = new System.Drawing.Size(560, 405);
			this.TeachersGrid.TabIndex = 9;
			this.TeachersGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.TeachersGrid_CellBeginEdit);
			this.TeachersGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeachersGrid_CellEndEdit);
			this.TeachersGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.TeachersGrid_UserDeletingRow);
			// 
			// TeacherID
			// 
			this.TeacherID.HeaderText = "ID";
			this.TeacherID.Name = "TeacherID";
			this.TeacherID.ReadOnly = true;
			this.TeacherID.Visible = false;
			// 
			// TeacherName
			// 
			this.TeacherName.HeaderText = "Имя преподавателя";
			this.TeacherName.Name = "TeacherName";
			// 
			// CurrentAttendance
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
			this.CurrentAttendance.DefaultCellStyle = dataGridViewCellStyle1;
			this.CurrentAttendance.HeaderText = "Посещаемость за последние 30 дней";
			this.CurrentAttendance.Name = "CurrentAttendance";
			this.CurrentAttendance.ReadOnly = true;
			// 
			// TotalAttendance
			// 
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			this.TotalAttendance.DefaultCellStyle = dataGridViewCellStyle2;
			this.TotalAttendance.HeaderText = "Посещаемость за всё время";
			this.TotalAttendance.Name = "TotalAttendance";
			this.TotalAttendance.ReadOnly = true;
			// 
			// UserHelpButton
			// 
			this.UserHelpButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.UserHelpButton.Location = new System.Drawing.Point(446, 13);
			this.UserHelpButton.Name = "UserHelpButton";
			this.UserHelpButton.Size = new System.Drawing.Size(126, 25);
			this.UserHelpButton.TabIndex = 11;
			this.UserHelpButton.Text = "Помощь";
			this.UserHelpButton.UseVisualStyleBackColor = true;
			this.UserHelpButton.Click += new System.EventHandler(this.UserHelpButton_Click);
			// 
			// TeacherLabel
			// 
			this.TeacherLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.TeacherLabel.AutoSize = true;
			this.TeacherLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TeacherLabel.Location = new System.Drawing.Point(179, 13);
			this.TeacherLabel.Name = "TeacherLabel";
			this.TeacherLabel.Size = new System.Drawing.Size(226, 25);
			this.TeacherLabel.TabIndex = 10;
			this.TeacherLabel.Text = "Список Преподавателей";
			// 
			// TeacherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 461);
			this.Controls.Add(this.UserHelpButton);
			this.Controls.Add(this.TeacherLabel);
			this.Controls.Add(this.TeachersGrid);
			this.Name = "TeacherForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Преподаватели";
			((System.ComponentModel.ISupportInitialize)(this.TeachersGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView TeachersGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn TeacherID;
		private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
		private System.Windows.Forms.DataGridViewTextBoxColumn CurrentAttendance;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalAttendance;
		private System.Windows.Forms.Button UserHelpButton;
		private System.Windows.Forms.Label TeacherLabel;
	}
}