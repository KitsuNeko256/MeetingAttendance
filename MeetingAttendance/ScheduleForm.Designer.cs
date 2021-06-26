
namespace MeetingAttendance
{
	partial class ScheduleForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.LessonDatePicker = new System.Windows.Forms.DateTimePicker();
			this.LessonTimesList = new System.Windows.Forms.ListBox();
			this.LessonDataGrid = new System.Windows.Forms.DataGridView();
			this.AddLessonButton = new System.Windows.Forms.Button();
			this.EditLessonButton = new System.Windows.Forms.Button();
			this.UserHelpButton = new System.Windows.Forms.Button();
			this.ScheduleLabel = new System.Windows.Forms.Label();
			this.AttendanceButton = new System.Windows.Forms.Button();
			this.DateLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Groups = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AttendanceRegistered = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.LessonDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// LessonDatePicker
			// 
			this.LessonDatePicker.Location = new System.Drawing.Point(12, 42);
			this.LessonDatePicker.Name = "LessonDatePicker";
			this.LessonDatePicker.Size = new System.Drawing.Size(145, 23);
			this.LessonDatePicker.TabIndex = 0;
			this.LessonDatePicker.ValueChanged += new System.EventHandler(this.LessonDatePicker_ValueChanged);
			// 
			// LessonTimesList
			// 
			this.LessonTimesList.FormattingEnabled = true;
			this.LessonTimesList.ItemHeight = 15;
			this.LessonTimesList.Location = new System.Drawing.Point(12, 101);
			this.LessonTimesList.Name = "LessonTimesList";
			this.LessonTimesList.Size = new System.Drawing.Size(145, 214);
			this.LessonTimesList.TabIndex = 1;
			this.LessonTimesList.SelectedIndexChanged += new System.EventHandler(this.LessonTimesList_SelectedIndexChanged);
			// 
			// LessonDataGrid
			// 
			this.LessonDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.LessonDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.LessonDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Subject,
            this.Type,
            this.Groups,
            this.Teacher,
            this.AttendanceRegistered});
			this.LessonDataGrid.Location = new System.Drawing.Point(163, 42);
			this.LessonDataGrid.MultiSelect = false;
			this.LessonDataGrid.Name = "LessonDataGrid";
			this.LessonDataGrid.RowHeadersVisible = false;
			this.LessonDataGrid.RowTemplate.Height = 25;
			this.LessonDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.LessonDataGrid.Size = new System.Drawing.Size(625, 273);
			this.LessonDataGrid.TabIndex = 2;
			this.LessonDataGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.LessonDataGrid_UserDeletingRow);
			// 
			// AddLessonButton
			// 
			this.AddLessonButton.Location = new System.Drawing.Point(163, 321);
			this.AddLessonButton.Name = "AddLessonButton";
			this.AddLessonButton.Size = new System.Drawing.Size(125, 50);
			this.AddLessonButton.TabIndex = 3;
			this.AddLessonButton.Text = "Добавить занятие";
			this.AddLessonButton.UseVisualStyleBackColor = true;
			this.AddLessonButton.Click += new System.EventHandler(this.AddLessonButton_Click);
			// 
			// EditLessonButton
			// 
			this.EditLessonButton.Location = new System.Drawing.Point(318, 321);
			this.EditLessonButton.Name = "EditLessonButton";
			this.EditLessonButton.Size = new System.Drawing.Size(125, 50);
			this.EditLessonButton.TabIndex = 4;
			this.EditLessonButton.Text = "Редактировать выбранное занятие";
			this.EditLessonButton.UseVisualStyleBackColor = true;
			this.EditLessonButton.Click += new System.EventHandler(this.EditLessonButton_Click);
			// 
			// UserHelpButton
			// 
			this.UserHelpButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.UserHelpButton.Location = new System.Drawing.Point(662, 9);
			this.UserHelpButton.Name = "UserHelpButton";
			this.UserHelpButton.Size = new System.Drawing.Size(126, 25);
			this.UserHelpButton.TabIndex = 27;
			this.UserHelpButton.Text = "Помощь";
			this.UserHelpButton.UseVisualStyleBackColor = true;
			this.UserHelpButton.Click += new System.EventHandler(this.UserHelpButton_Click);
			// 
			// ScheduleLabel
			// 
			this.ScheduleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ScheduleLabel.AutoSize = true;
			this.ScheduleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ScheduleLabel.Location = new System.Drawing.Point(356, 7);
			this.ScheduleLabel.Name = "ScheduleLabel";
			this.ScheduleLabel.Size = new System.Drawing.Size(115, 25);
			this.ScheduleLabel.TabIndex = 26;
			this.ScheduleLabel.Text = "Расписание";
			// 
			// AttendanceButton
			// 
			this.AttendanceButton.Location = new System.Drawing.Point(474, 321);
			this.AttendanceButton.Name = "AttendanceButton";
			this.AttendanceButton.Size = new System.Drawing.Size(156, 50);
			this.AttendanceButton.TabIndex = 28;
			this.AttendanceButton.Text = "Отметить посещаемость на занятии";
			this.AttendanceButton.UseVisualStyleBackColor = true;
			this.AttendanceButton.Click += new System.EventHandler(this.AttendanceButton_Click);
			// 
			// DateLabel
			// 
			this.DateLabel.AutoSize = true;
			this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DateLabel.Location = new System.Drawing.Point(12, 18);
			this.DateLabel.Name = "DateLabel";
			this.DateLabel.Size = new System.Drawing.Size(107, 21);
			this.DateLabel.TabIndex = 29;
			this.DateLabel.Text = "Дата занятия:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 21);
			this.label1.TabIndex = 30;
			this.label1.Text = "Начало занятия:";
			// 
			// ID
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
			this.ID.DefaultCellStyle = dataGridViewCellStyle1;
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// Subject
			// 
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			this.Subject.DefaultCellStyle = dataGridViewCellStyle2;
			this.Subject.HeaderText = "Предмет";
			this.Subject.Name = "Subject";
			this.Subject.ReadOnly = true;
			// 
			// Type
			// 
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
			this.Type.DefaultCellStyle = dataGridViewCellStyle3;
			this.Type.HeaderText = "Тип занятия";
			this.Type.Name = "Type";
			this.Type.ReadOnly = true;
			// 
			// Groups
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
			this.Groups.DefaultCellStyle = dataGridViewCellStyle4;
			this.Groups.HeaderText = "Группы";
			this.Groups.Name = "Groups";
			this.Groups.ReadOnly = true;
			// 
			// Teacher
			// 
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
			this.Teacher.DefaultCellStyle = dataGridViewCellStyle5;
			this.Teacher.HeaderText = "Преподаватель";
			this.Teacher.Name = "Teacher";
			this.Teacher.ReadOnly = true;
			// 
			// AttendanceRegistered
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle6.NullValue = false;
			this.AttendanceRegistered.DefaultCellStyle = dataGridViewCellStyle6;
			this.AttendanceRegistered.HeaderText = "Посещаемость Проставлена";
			this.AttendanceRegistered.Name = "AttendanceRegistered";
			this.AttendanceRegistered.ReadOnly = true;
			// 
			// ScheduleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 376);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.DateLabel);
			this.Controls.Add(this.AttendanceButton);
			this.Controls.Add(this.UserHelpButton);
			this.Controls.Add(this.ScheduleLabel);
			this.Controls.Add(this.EditLessonButton);
			this.Controls.Add(this.AddLessonButton);
			this.Controls.Add(this.LessonDataGrid);
			this.Controls.Add(this.LessonTimesList);
			this.Controls.Add(this.LessonDatePicker);
			this.Name = "ScheduleForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Расписание";
			((System.ComponentModel.ISupportInitialize)(this.LessonDataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker LessonDatePicker;
		private System.Windows.Forms.ListBox LessonTimesList;
		private System.Windows.Forms.DataGridView LessonDataGrid;
		private System.Windows.Forms.Button AddLessonButton;
		private System.Windows.Forms.Button EditLessonButton;
		private System.Windows.Forms.Button UserHelpButton;
		private System.Windows.Forms.Label ScheduleLabel;
		private System.Windows.Forms.Button AttendanceButton;
		private System.Windows.Forms.Label DateLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
		private System.Windows.Forms.DataGridViewTextBoxColumn Type;
		private System.Windows.Forms.DataGridViewTextBoxColumn Groups;
		private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
		private System.Windows.Forms.DataGridViewCheckBoxColumn AttendanceRegistered;
	}
}