
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
			this.GroupsGrid = new System.Windows.Forms.DataGridView();
			this.StudentListLabel = new System.Windows.Forms.Label();
			this.CurrentGroupList = new System.Windows.Forms.ListBox();
			this.AddStudentButton = new System.Windows.Forms.Button();
			this.StudentsComboBox = new System.Windows.Forms.ComboBox();
			this.RemoveStudentButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.GroupsGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// GroupsGrid
			// 
			this.GroupsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.GroupsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GroupsGrid.Dock = System.Windows.Forms.DockStyle.Left;
			this.GroupsGrid.Location = new System.Drawing.Point(0, 0);
			this.GroupsGrid.Name = "GroupsGrid";
			this.GroupsGrid.RowTemplate.Height = 25;
			this.GroupsGrid.Size = new System.Drawing.Size(287, 289);
			this.GroupsGrid.TabIndex = 4;
			this.GroupsGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.GroupsGrid_CellBeginEdit);
			this.GroupsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupsGrid_CellClick);
			this.GroupsGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupsGrid_CellEndEdit);
			this.GroupsGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.GroupsGrid_UserDeletingRow);
			// 
			// StudentListLabel
			// 
			this.StudentListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StudentListLabel.AutoSize = true;
			this.StudentListLabel.Location = new System.Drawing.Point(300, 15);
			this.StudentListLabel.Name = "StudentListLabel";
			this.StudentListLabel.Size = new System.Drawing.Size(172, 15);
			this.StudentListLabel.TabIndex = 8;
			this.StudentListLabel.Text = "Студенты выбранной группы:";
			// 
			// CurrentGroupList
			// 
			this.CurrentGroupList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CurrentGroupList.FormattingEnabled = true;
			this.CurrentGroupList.ItemHeight = 15;
			this.CurrentGroupList.Location = new System.Drawing.Point(300, 33);
			this.CurrentGroupList.Name = "CurrentGroupList";
			this.CurrentGroupList.Size = new System.Drawing.Size(193, 244);
			this.CurrentGroupList.TabIndex = 10;
			// 
			// AddStudentButton
			// 
			this.AddStudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddStudentButton.Location = new System.Drawing.Point(499, 62);
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
			this.StudentsComboBox.Location = new System.Drawing.Point(499, 33);
			this.StudentsComboBox.Name = "StudentsComboBox";
			this.StudentsComboBox.Size = new System.Drawing.Size(173, 23);
			this.StudentsComboBox.TabIndex = 12;
			// 
			// RemoveStudentButton
			// 
			this.RemoveStudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveStudentButton.Location = new System.Drawing.Point(499, 226);
			this.RemoveStudentButton.Name = "RemoveStudentButton";
			this.RemoveStudentButton.Size = new System.Drawing.Size(173, 51);
			this.RemoveStudentButton.TabIndex = 13;
			this.RemoveStudentButton.Text = "Удалить выбранного студента из группы";
			this.RemoveStudentButton.UseVisualStyleBackColor = true;
			this.RemoveStudentButton.Click += new System.EventHandler(this.RemoveStudentButton_Click);
			// 
			// GroupForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 289);
			this.Controls.Add(this.GroupsGrid);
			this.Controls.Add(this.StudentListLabel);
			this.Controls.Add(this.CurrentGroupList);
			this.Controls.Add(this.StudentsComboBox);
			this.Controls.Add(this.RemoveStudentButton);
			this.Controls.Add(this.AddStudentButton);
			this.Name = "GroupForm";
			this.Text = "GroupForm";
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
	}
}