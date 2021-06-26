
namespace MeetingAttendance
{
	partial class GroupForm
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
			this.GroupsGrid = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CurrentAttendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalAttendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StudentListLabel = new System.Windows.Forms.Label();
			this.CurrentGroupList = new System.Windows.Forms.ListBox();
			this.AddStudentButton = new System.Windows.Forms.Button();
			this.StudentsComboBox = new System.Windows.Forms.ComboBox();
			this.RemoveStudentButton = new System.Windows.Forms.Button();
			this.UserHelpButton = new System.Windows.Forms.Button();
			this.GroupLabel = new System.Windows.Forms.Label();
			this.AddStudentLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.GroupsGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// GroupsGrid
			// 
			this.GroupsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.GroupsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GroupsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CurrentAttendance,
            this.TotalAttendance});
			this.GroupsGrid.Location = new System.Drawing.Point(12, 47);
			this.GroupsGrid.MultiSelect = false;
			this.GroupsGrid.Name = "GroupsGrid";
			this.GroupsGrid.RowHeadersVisible = false;
			this.GroupsGrid.RowTemplate.Height = 25;
			this.GroupsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GroupsGrid.Size = new System.Drawing.Size(282, 276);
			this.GroupsGrid.TabIndex = 4;
			this.GroupsGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.GroupsGrid_CellBeginEdit);
			this.GroupsGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupsGrid_CellEndEdit);
			this.GroupsGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupsGrid_RowEnter);
			this.GroupsGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.GroupsGrid_UserDeletingRow);
			// 
			// ID
			// 
			this.ID.FillWeight = 75F;
			this.ID.HeaderText = "Код группы";
			this.ID.Name = "ID";
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
			// StudentListLabel
			// 
			this.StudentListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StudentListLabel.AutoSize = true;
			this.StudentListLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.StudentListLabel.Location = new System.Drawing.Point(300, 47);
			this.StudentListLabel.Name = "StudentListLabel";
			this.StudentListLabel.Size = new System.Drawing.Size(220, 21);
			this.StudentListLabel.TabIndex = 8;
			this.StudentListLabel.Text = "Студенты выбранной группы";
			// 
			// CurrentGroupList
			// 
			this.CurrentGroupList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CurrentGroupList.FormattingEnabled = true;
			this.CurrentGroupList.ItemHeight = 15;
			this.CurrentGroupList.Location = new System.Drawing.Point(300, 79);
			this.CurrentGroupList.Name = "CurrentGroupList";
			this.CurrentGroupList.Size = new System.Drawing.Size(193, 244);
			this.CurrentGroupList.TabIndex = 10;
			// 
			// AddStudentButton
			// 
			this.AddStudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddStudentButton.Location = new System.Drawing.Point(499, 135);
			this.AddStudentButton.Name = "AddStudentButton";
			this.AddStudentButton.Size = new System.Drawing.Size(173, 42);
			this.AddStudentButton.TabIndex = 11;
			this.AddStudentButton.Text = "Добавить студента в группу";
			this.AddStudentButton.UseVisualStyleBackColor = true;
			this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
			// 
			// StudentsComboBox
			// 
			this.StudentsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StudentsComboBox.FormattingEnabled = true;
			this.StudentsComboBox.Location = new System.Drawing.Point(499, 106);
			this.StudentsComboBox.Name = "StudentsComboBox";
			this.StudentsComboBox.Size = new System.Drawing.Size(173, 23);
			this.StudentsComboBox.TabIndex = 12;
			// 
			// RemoveStudentButton
			// 
			this.RemoveStudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveStudentButton.Location = new System.Drawing.Point(499, 272);
			this.RemoveStudentButton.Name = "RemoveStudentButton";
			this.RemoveStudentButton.Size = new System.Drawing.Size(173, 51);
			this.RemoveStudentButton.TabIndex = 13;
			this.RemoveStudentButton.Text = "Удалить выбранного студента из группы";
			this.RemoveStudentButton.UseVisualStyleBackColor = true;
			this.RemoveStudentButton.Click += new System.EventHandler(this.RemoveStudentButton_Click);
			// 
			// UserHelpButton
			// 
			this.UserHelpButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.UserHelpButton.Location = new System.Drawing.Point(546, 12);
			this.UserHelpButton.Name = "UserHelpButton";
			this.UserHelpButton.Size = new System.Drawing.Size(126, 25);
			this.UserHelpButton.TabIndex = 15;
			this.UserHelpButton.Text = "Помощь";
			this.UserHelpButton.UseVisualStyleBackColor = true;
			this.UserHelpButton.Click += new System.EventHandler(this.UserHelpButton_Click);
			// 
			// GroupLabel
			// 
			this.GroupLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.GroupLabel.AutoSize = true;
			this.GroupLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.GroupLabel.Location = new System.Drawing.Point(84, 9);
			this.GroupLabel.Name = "GroupLabel";
			this.GroupLabel.Size = new System.Drawing.Size(131, 25);
			this.GroupLabel.TabIndex = 14;
			this.GroupLabel.Text = "Список Групп";
			// 
			// AddStudentLabel
			// 
			this.AddStudentLabel.AutoSize = true;
			this.AddStudentLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AddStudentLabel.Location = new System.Drawing.Point(499, 79);
			this.AddStudentLabel.Name = "AddStudentLabel";
			this.AddStudentLabel.Size = new System.Drawing.Size(149, 21);
			this.AddStudentLabel.TabIndex = 16;
			this.AddStudentLabel.Text = "Добавить студента:";
			// 
			// GroupForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 340);
			this.Controls.Add(this.AddStudentLabel);
			this.Controls.Add(this.UserHelpButton);
			this.Controls.Add(this.GroupLabel);
			this.Controls.Add(this.GroupsGrid);
			this.Controls.Add(this.StudentListLabel);
			this.Controls.Add(this.CurrentGroupList);
			this.Controls.Add(this.StudentsComboBox);
			this.Controls.Add(this.RemoveStudentButton);
			this.Controls.Add(this.AddStudentButton);
			this.Name = "GroupForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Группы";
			((System.ComponentModel.ISupportInitialize)(this.GroupsGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView GroupsGrid;
		private System.Windows.Forms.Label StudentListLabel;
		private System.Windows.Forms.ListBox CurrentGroupList;
		private System.Windows.Forms.Button AddStudentButton;
		private System.Windows.Forms.ComboBox StudentsComboBox;
		private System.Windows.Forms.Button RemoveStudentButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn CurrentAttendance;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalAttendance;
		private System.Windows.Forms.Button UserHelpButton;
		private System.Windows.Forms.Label GroupLabel;
		private System.Windows.Forms.Label AddStudentLabel;
	}
}