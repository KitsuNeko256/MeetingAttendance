
namespace MeetingAttendance
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.StudentsButton = new System.Windows.Forms.Button();
			this.GroupsButton = new System.Windows.Forms.Button();
			this.TeachersButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// StudentsButton
			// 
			this.StudentsButton.Location = new System.Drawing.Point(12, 12);
			this.StudentsButton.Name = "StudentsButton";
			this.StudentsButton.Size = new System.Drawing.Size(96, 55);
			this.StudentsButton.TabIndex = 0;
			this.StudentsButton.Text = "Студенты";
			this.StudentsButton.UseVisualStyleBackColor = true;
			this.StudentsButton.Click += new System.EventHandler(this.StudentsButton_Click);
			// 
			// GroupsButton
			// 
			this.GroupsButton.Location = new System.Drawing.Point(12, 73);
			this.GroupsButton.Name = "GroupsButton";
			this.GroupsButton.Size = new System.Drawing.Size(96, 55);
			this.GroupsButton.TabIndex = 1;
			this.GroupsButton.Text = "Группы";
			this.GroupsButton.UseVisualStyleBackColor = true;
			this.GroupsButton.Click += new System.EventHandler(this.GroupsButton_Click);
			// 
			// TeachersButton
			// 
			this.TeachersButton.Location = new System.Drawing.Point(12, 134);
			this.TeachersButton.Name = "TeachersButton";
			this.TeachersButton.Size = new System.Drawing.Size(96, 55);
			this.TeachersButton.TabIndex = 2;
			this.TeachersButton.Text = "Учителя";
			this.TeachersButton.UseVisualStyleBackColor = true;
			this.TeachersButton.Click += new System.EventHandler(this.TeachersButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(266, 361);
			this.Controls.Add(this.TeachersButton);
			this.Controls.Add(this.GroupsButton);
			this.Controls.Add(this.StudentsButton);
			this.Name = "MainForm";
			this.Text = "Главное Меню";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button StudentsButton;
		private System.Windows.Forms.Button GroupsButton;
		private System.Windows.Forms.Button TeachersButton;
	}
}

