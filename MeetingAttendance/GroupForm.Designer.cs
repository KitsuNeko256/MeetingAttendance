
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
			this.ExitButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.RemoveStudentButton = new System.Windows.Forms.Button();
			this.StudentsComboBox = new System.Windows.Forms.ComboBox();
			this.AddStudentButton = new System.Windows.Forms.Button();
			this.CurrentGroupList = new System.Windows.Forms.ListBox();
			this.StudentListLabel = new System.Windows.Forms.Label();
			this.GroupsGrid = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GroupsGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// ExitButton
			// 
			this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ExitButton.Location = new System.Drawing.Point(494, 289);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(178, 60);
			this.ExitButton.TabIndex = 5;
			this.ExitButton.Text = "Выйти в главное меню";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SaveButton.Location = new System.Drawing.Point(12, 289);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(125, 60);
			this.SaveButton.TabIndex = 4;
			this.SaveButton.Text = "Сохранить";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.RemoveStudentButton);
			this.panel1.Controls.Add(this.StudentsComboBox);
			this.panel1.Controls.Add(this.AddStudentButton);
			this.panel1.Controls.Add(this.CurrentGroupList);
			this.panel1.Controls.Add(this.StudentListLabel);
			this.panel1.Controls.Add(this.GroupsGrid);
			this.panel1.Location = new System.Drawing.Point(2, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(670, 263);
			this.panel1.TabIndex = 6;
			// 
			// RemoveStudentButton
			// 
			this.RemoveStudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveStudentButton.Location = new System.Drawing.Point(492, 200);
			this.RemoveStudentButton.Name = "RemoveStudentButton";
			this.RemoveStudentButton.Size = new System.Drawing.Size(173, 51);
			this.RemoveStudentButton.TabIndex = 13;
			this.RemoveStudentButton.Text = "Удалить выбранного студента из группы";
			this.RemoveStudentButton.UseVisualStyleBackColor = true;
			this.RemoveStudentButton.Click += new System.EventHandler(this.RemoveStudentButton_Click);
			// 
			// StudentsComboBox
			// 
			this.StudentsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StudentsComboBox.FormattingEnabled = true;
			this.StudentsComboBox.Location = new System.Drawing.Point(492, 22);
			this.StudentsComboBox.Name = "StudentsComboBox";
			this.StudentsComboBox.Size = new System.Drawing.Size(173, 23);
			this.StudentsComboBox.TabIndex = 12;
			// 
			// AddStudentButton
			// 
			this.AddStudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddStudentButton.Location = new System.Drawing.Point(492, 51);
			this.AddStudentButton.Name = "AddStudentButton";
			this.AddStudentButton.Size = new System.Drawing.Size(173, 42);
			this.AddStudentButton.TabIndex = 11;
			this.AddStudentButton.Text = "Добавить студента в группу";
			this.AddStudentButton.UseVisualStyleBackColor = true;
			this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
			// 
			// CurrentGroupList
			// 
			this.CurrentGroupList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CurrentGroupList.FormattingEnabled = true;
			this.CurrentGroupList.ItemHeight = 15;
			this.CurrentGroupList.Location = new System.Drawing.Point(293, 22);
			this.CurrentGroupList.Name = "CurrentGroupList";
			this.CurrentGroupList.Size = new System.Drawing.Size(193, 229);
			this.CurrentGroupList.TabIndex = 10;
			// 
			// StudentListLabel
			// 
			this.StudentListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StudentListLabel.AutoSize = true;
			this.StudentListLabel.Location = new System.Drawing.Point(293, 4);
			this.StudentListLabel.Name = "StudentListLabel";
			this.StudentListLabel.Size = new System.Drawing.Size(172, 15);
			this.StudentListLabel.TabIndex = 8;
			this.StudentListLabel.Text = "Студенты выбранной группы:";
			// 
			// GroupsGrid
			// 
			this.GroupsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.GroupsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GroupsGrid.Dock = System.Windows.Forms.DockStyle.Left;
			this.GroupsGrid.Location = new System.Drawing.Point(0, 0);
			this.GroupsGrid.Name = "GroupsGrid";
			this.GroupsGrid.RowTemplate.Height = 25;
			this.GroupsGrid.Size = new System.Drawing.Size(287, 263);
			this.GroupsGrid.TabIndex = 4;
			this.GroupsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupsGrid_CellClick);
			this.GroupsGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.GroupsGrid_UserDeletingRow);
			// 
			// GroupForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 361);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.SaveButton);
			this.Name = "GroupForm";
			this.Text = "GroupForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.GroupsGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView GroupsGrid;
		private System.Windows.Forms.Label StudentListLabel;
		private System.Windows.Forms.ListBox CurrentGroupList;
		private System.Windows.Forms.Button AddStudentButton;
		private System.Windows.Forms.ComboBox StudentsComboBox;
		private System.Windows.Forms.Button RemoveStudentButton;
	}
}