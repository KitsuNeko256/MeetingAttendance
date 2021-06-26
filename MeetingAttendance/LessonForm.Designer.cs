
namespace MeetingAttendance
{
	partial class LessonForm
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
			this.SubjectBox = new System.Windows.Forms.TextBox();
			this.SubjectLabel = new System.Windows.Forms.Label();
			this.TeacherLabel = new System.Windows.Forms.Label();
			this.TeacherBox = new System.Windows.Forms.ComboBox();
			this.LinkLabel = new System.Windows.Forms.Label();
			this.RecordedLabel = new System.Windows.Forms.Label();
			this.LinkBox = new System.Windows.Forms.TextBox();
			this.RecordedCheckBox = new System.Windows.Forms.CheckBox();
			this.PeriodLabel = new System.Windows.Forms.Label();
			this.PeriodBox = new System.Windows.Forms.ComboBox();
			this.TypeLabel = new System.Windows.Forms.Label();
			this.TypeBox = new System.Windows.Forms.ComboBox();
			this.CommentsLabel = new System.Windows.Forms.Label();
			this.CommentsBox = new System.Windows.Forms.TextBox();
			this.GroupListLabel = new System.Windows.Forms.Label();
			this.LessonGroupList = new System.Windows.Forms.ListBox();
			this.GroupComboBox = new System.Windows.Forms.ComboBox();
			this.RemoveGroupButton = new System.Windows.Forms.Button();
			this.AddGroupButton = new System.Windows.Forms.Button();
			this.LessonDatePicker = new System.Windows.Forms.DateTimePicker();
			this.DateLabel = new System.Windows.Forms.Label();
			this.StartTimeLabel = new System.Windows.Forms.Label();
			this.StartTimeComboBox = new System.Windows.Forms.ComboBox();
			this.AddGroupLabel = new System.Windows.Forms.Label();
			this.UserHelpButton = new System.Windows.Forms.Button();
			this.LessonLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SubjectBox
			// 
			this.SubjectBox.Location = new System.Drawing.Point(222, 62);
			this.SubjectBox.Name = "SubjectBox";
			this.SubjectBox.Size = new System.Drawing.Size(173, 23);
			this.SubjectBox.TabIndex = 0;
			this.SubjectBox.TextChanged += new System.EventHandler(this.SubjectBox_TextChanged);
			// 
			// SubjectLabel
			// 
			this.SubjectLabel.AutoSize = true;
			this.SubjectLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SubjectLabel.Location = new System.Drawing.Point(140, 62);
			this.SubjectLabel.Name = "SubjectLabel";
			this.SubjectLabel.Size = new System.Drawing.Size(76, 21);
			this.SubjectLabel.TabIndex = 1;
			this.SubjectLabel.Text = "Предмет:";
			// 
			// TeacherLabel
			// 
			this.TeacherLabel.AutoSize = true;
			this.TeacherLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TeacherLabel.Location = new System.Drawing.Point(93, 102);
			this.TeacherLabel.Name = "TeacherLabel";
			this.TeacherLabel.Size = new System.Drawing.Size(123, 21);
			this.TeacherLabel.TabIndex = 2;
			this.TeacherLabel.Text = "Преподаватель:";
			// 
			// TeacherBox
			// 
			this.TeacherBox.FormattingEnabled = true;
			this.TeacherBox.Location = new System.Drawing.Point(222, 102);
			this.TeacherBox.Name = "TeacherBox";
			this.TeacherBox.Size = new System.Drawing.Size(173, 23);
			this.TeacherBox.TabIndex = 3;
			this.TeacherBox.SelectedIndexChanged += new System.EventHandler(this.TeacherBox_SelectedIndexChanged);
			this.TeacherBox.Leave += new System.EventHandler(this.TeacherBox_Leave);
			// 
			// LinkLabel
			// 
			this.LinkLabel.AutoSize = true;
			this.LinkLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LinkLabel.Location = new System.Drawing.Point(12, 182);
			this.LinkLabel.Name = "LinkLabel";
			this.LinkLabel.Size = new System.Drawing.Size(204, 21);
			this.LinkLabel.TabIndex = 4;
			this.LinkLabel.Text = "Ссылка на онлайн-занятие:";
			// 
			// RecordedLabel
			// 
			this.RecordedLabel.AutoSize = true;
			this.RecordedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RecordedLabel.Location = new System.Drawing.Point(406, 182);
			this.RecordedLabel.Name = "RecordedLabel";
			this.RecordedLabel.Size = new System.Drawing.Size(189, 21);
			this.RecordedLabel.TabIndex = 5;
			this.RecordedLabel.Text = "Посещение обязательно:";
			// 
			// LinkBox
			// 
			this.LinkBox.Location = new System.Drawing.Point(222, 182);
			this.LinkBox.Name = "LinkBox";
			this.LinkBox.Size = new System.Drawing.Size(173, 23);
			this.LinkBox.TabIndex = 6;
			this.LinkBox.TextChanged += new System.EventHandler(this.LinkBox_TextChanged);
			// 
			// RecordedCheckBox
			// 
			this.RecordedCheckBox.AutoSize = true;
			this.RecordedCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.RecordedCheckBox.Location = new System.Drawing.Point(602, 188);
			this.RecordedCheckBox.Name = "RecordedCheckBox";
			this.RecordedCheckBox.Size = new System.Drawing.Size(15, 14);
			this.RecordedCheckBox.TabIndex = 7;
			this.RecordedCheckBox.UseVisualStyleBackColor = true;
			this.RecordedCheckBox.CheckedChanged += new System.EventHandler(this.RecordedCheckBox_CheckedChanged);
			// 
			// PeriodLabel
			// 
			this.PeriodLabel.AutoSize = true;
			this.PeriodLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.PeriodLabel.Location = new System.Drawing.Point(465, 64);
			this.PeriodLabel.Name = "PeriodLabel";
			this.PeriodLabel.Size = new System.Drawing.Size(130, 21);
			this.PeriodLabel.TabIndex = 8;
			this.PeriodLabel.Text = "Частота занятия:";
			// 
			// PeriodBox
			// 
			this.PeriodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PeriodBox.FormattingEnabled = true;
			this.PeriodBox.Location = new System.Drawing.Point(602, 62);
			this.PeriodBox.Name = "PeriodBox";
			this.PeriodBox.Size = new System.Drawing.Size(143, 23);
			this.PeriodBox.TabIndex = 9;
			this.PeriodBox.SelectedIndexChanged += new System.EventHandler(this.PeriodBox_SelectedIndexChanged);
			// 
			// TypeLabel
			// 
			this.TypeLabel.AutoSize = true;
			this.TypeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TypeLabel.Location = new System.Drawing.Point(117, 142);
			this.TypeLabel.Name = "TypeLabel";
			this.TypeLabel.Size = new System.Drawing.Size(99, 21);
			this.TypeLabel.TabIndex = 10;
			this.TypeLabel.Text = "Тип занятия:";
			// 
			// TypeBox
			// 
			this.TypeBox.FormattingEnabled = true;
			this.TypeBox.Location = new System.Drawing.Point(222, 142);
			this.TypeBox.Name = "TypeBox";
			this.TypeBox.Size = new System.Drawing.Size(173, 23);
			this.TypeBox.TabIndex = 11;
			this.TypeBox.Text = "asd";
			this.TypeBox.SelectedIndexChanged += new System.EventHandler(this.TypeBox_SelectedIndexChanged);
			// 
			// CommentsLabel
			// 
			this.CommentsLabel.AutoSize = true;
			this.CommentsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CommentsLabel.Location = new System.Drawing.Point(423, 255);
			this.CommentsLabel.Name = "CommentsLabel";
			this.CommentsLabel.Size = new System.Drawing.Size(112, 21);
			this.CommentsLabel.TabIndex = 12;
			this.CommentsLabel.Text = "Комментарии:";
			// 
			// CommentsBox
			// 
			this.CommentsBox.Location = new System.Drawing.Point(423, 282);
			this.CommentsBox.Multiline = true;
			this.CommentsBox.Name = "CommentsBox";
			this.CommentsBox.Size = new System.Drawing.Size(322, 73);
			this.CommentsBox.TabIndex = 13;
			this.CommentsBox.TextChanged += new System.EventHandler(this.CommentsBox_TextChanged);
			// 
			// GroupListLabel
			// 
			this.GroupListLabel.AutoSize = true;
			this.GroupListLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.GroupListLabel.Location = new System.Drawing.Point(23, 222);
			this.GroupListLabel.Name = "GroupListLabel";
			this.GroupListLabel.Size = new System.Drawing.Size(143, 21);
			this.GroupListLabel.TabIndex = 14;
			this.GroupListLabel.Text = "Группы студентов:";
			// 
			// LessonGroupList
			// 
			this.LessonGroupList.FormattingEnabled = true;
			this.LessonGroupList.ItemHeight = 15;
			this.LessonGroupList.Location = new System.Drawing.Point(23, 255);
			this.LessonGroupList.Name = "LessonGroupList";
			this.LessonGroupList.Size = new System.Drawing.Size(193, 184);
			this.LessonGroupList.TabIndex = 15;
			// 
			// GroupComboBox
			// 
			this.GroupComboBox.FormattingEnabled = true;
			this.GroupComboBox.Location = new System.Drawing.Point(222, 282);
			this.GroupComboBox.Name = "GroupComboBox";
			this.GroupComboBox.Size = new System.Drawing.Size(173, 23);
			this.GroupComboBox.TabIndex = 17;
			// 
			// RemoveGroupButton
			// 
			this.RemoveGroupButton.Location = new System.Drawing.Point(222, 390);
			this.RemoveGroupButton.Name = "RemoveGroupButton";
			this.RemoveGroupButton.Size = new System.Drawing.Size(173, 49);
			this.RemoveGroupButton.TabIndex = 18;
			this.RemoveGroupButton.Text = "Удалить выбранную группу с занятия";
			this.RemoveGroupButton.UseVisualStyleBackColor = true;
			this.RemoveGroupButton.Click += new System.EventHandler(this.RemoveGroupButton_Click);
			// 
			// AddGroupButton
			// 
			this.AddGroupButton.Location = new System.Drawing.Point(222, 313);
			this.AddGroupButton.Name = "AddGroupButton";
			this.AddGroupButton.Size = new System.Drawing.Size(173, 42);
			this.AddGroupButton.TabIndex = 16;
			this.AddGroupButton.Text = "Добавить группу на занятие";
			this.AddGroupButton.UseVisualStyleBackColor = true;
			this.AddGroupButton.Click += new System.EventHandler(this.AddGroupButton_Click);
			// 
			// LessonDatePicker
			// 
			this.LessonDatePicker.Location = new System.Drawing.Point(602, 102);
			this.LessonDatePicker.Name = "LessonDatePicker";
			this.LessonDatePicker.Size = new System.Drawing.Size(143, 23);
			this.LessonDatePicker.TabIndex = 19;
			this.LessonDatePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
			// 
			// DateLabel
			// 
			this.DateLabel.AutoSize = true;
			this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DateLabel.Location = new System.Drawing.Point(486, 102);
			this.DateLabel.Name = "DateLabel";
			this.DateLabel.Size = new System.Drawing.Size(109, 21);
			this.DateLabel.TabIndex = 20;
			this.DateLabel.Text = "День занятия:";
			// 
			// StartTimeLabel
			// 
			this.StartTimeLabel.AutoSize = true;
			this.StartTimeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.StartTimeLabel.Location = new System.Drawing.Point(423, 142);
			this.StartTimeLabel.Name = "StartTimeLabel";
			this.StartTimeLabel.Size = new System.Drawing.Size(172, 21);
			this.StartTimeLabel.TabIndex = 21;
			this.StartTimeLabel.Text = "Время начала занятия:";
			// 
			// StartTimeComboBox
			// 
			this.StartTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.StartTimeComboBox.FormattingEnabled = true;
			this.StartTimeComboBox.Location = new System.Drawing.Point(602, 142);
			this.StartTimeComboBox.Name = "StartTimeComboBox";
			this.StartTimeComboBox.Size = new System.Drawing.Size(143, 23);
			this.StartTimeComboBox.TabIndex = 22;
			this.StartTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.StartTimeComboBox_SelectedIndexChanged);
			// 
			// AddGroupLabel
			// 
			this.AddGroupLabel.AutoSize = true;
			this.AddGroupLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AddGroupLabel.Location = new System.Drawing.Point(222, 255);
			this.AddGroupLabel.Name = "AddGroupLabel";
			this.AddGroupLabel.Size = new System.Drawing.Size(162, 21);
			this.AddGroupLabel.TabIndex = 23;
			this.AddGroupLabel.Text = "Добавляемая группа:";
			// 
			// UserHelpButton
			// 
			this.UserHelpButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.UserHelpButton.Location = new System.Drawing.Point(619, 9);
			this.UserHelpButton.Name = "UserHelpButton";
			this.UserHelpButton.Size = new System.Drawing.Size(126, 25);
			this.UserHelpButton.TabIndex = 25;
			this.UserHelpButton.Text = "Помощь";
			this.UserHelpButton.UseVisualStyleBackColor = true;
			this.UserHelpButton.Click += new System.EventHandler(this.UserHelpButton_Click);
			// 
			// LessonLabel
			// 
			this.LessonLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LessonLabel.AutoSize = true;
			this.LessonLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LessonLabel.Location = new System.Drawing.Point(357, 7);
			this.LessonLabel.Name = "LessonLabel";
			this.LessonLabel.Size = new System.Drawing.Size(82, 25);
			this.LessonLabel.TabIndex = 24;
			this.LessonLabel.Text = "Занятие";
			// 
			// LessonForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(757, 457);
			this.Controls.Add(this.UserHelpButton);
			this.Controls.Add(this.LessonLabel);
			this.Controls.Add(this.AddGroupLabel);
			this.Controls.Add(this.StartTimeComboBox);
			this.Controls.Add(this.StartTimeLabel);
			this.Controls.Add(this.DateLabel);
			this.Controls.Add(this.LessonDatePicker);
			this.Controls.Add(this.GroupListLabel);
			this.Controls.Add(this.LessonGroupList);
			this.Controls.Add(this.GroupComboBox);
			this.Controls.Add(this.RemoveGroupButton);
			this.Controls.Add(this.AddGroupButton);
			this.Controls.Add(this.CommentsBox);
			this.Controls.Add(this.CommentsLabel);
			this.Controls.Add(this.TypeBox);
			this.Controls.Add(this.TypeLabel);
			this.Controls.Add(this.PeriodBox);
			this.Controls.Add(this.PeriodLabel);
			this.Controls.Add(this.RecordedCheckBox);
			this.Controls.Add(this.LinkBox);
			this.Controls.Add(this.RecordedLabel);
			this.Controls.Add(this.LinkLabel);
			this.Controls.Add(this.TeacherBox);
			this.Controls.Add(this.TeacherLabel);
			this.Controls.Add(this.SubjectLabel);
			this.Controls.Add(this.SubjectBox);
			this.Name = "LessonForm";
			this.Text = "Занятие";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LessonForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox SubjectBox;
		private System.Windows.Forms.Label SubjectLabel;
		private System.Windows.Forms.Label TeacherLabel;
		private System.Windows.Forms.ComboBox TeacherBox;
		private System.Windows.Forms.Label LinkLabel;
		private System.Windows.Forms.Label RecordedLabel;
		private System.Windows.Forms.TextBox LinkBox;
		private System.Windows.Forms.CheckBox RecordedCheckBox;
		private System.Windows.Forms.Label PeriodLabel;
		private System.Windows.Forms.ComboBox PeriodBox;
		private System.Windows.Forms.Label TypeLabel;
		private System.Windows.Forms.ComboBox TypeBox;
		private System.Windows.Forms.Label CommentsLabel;
		private System.Windows.Forms.TextBox CommentsBox;
		private System.Windows.Forms.Label GroupListLabel;
		private System.Windows.Forms.ListBox LessonGroupList;
		private System.Windows.Forms.ComboBox GroupComboBox;
		private System.Windows.Forms.Button RemoveGroupButton;
		private System.Windows.Forms.Button AddGroupButton;
		private System.Windows.Forms.DateTimePicker LessonDatePicker;
		private System.Windows.Forms.Label DateLabel;
		private System.Windows.Forms.Label StartTimeLabel;
		private System.Windows.Forms.ComboBox StartTimeComboBox;
		private System.Windows.Forms.Label AddGroupLabel;
		private System.Windows.Forms.Button UserHelpButton;
		private System.Windows.Forms.Label LessonLabel;
	}
}