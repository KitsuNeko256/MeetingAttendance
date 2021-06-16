
namespace MeetingAttendance
{
	partial class StudentsForm
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
			this.studentsGrid = new System.Windows.Forms.DataGridView();
			this.SaveButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.studentsGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// studentsGrid
			// 
			this.studentsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.studentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.studentsGrid.Dock = System.Windows.Forms.DockStyle.Top;
			this.studentsGrid.Location = new System.Drawing.Point(0, 0);
			this.studentsGrid.Name = "studentsGrid";
			this.studentsGrid.RowTemplate.Height = 25;
			this.studentsGrid.Size = new System.Drawing.Size(604, 264);
			this.studentsGrid.TabIndex = 0;
			this.studentsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsGrid_CellContentClick);
			// 
			// SaveButton
			// 
			this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SaveButton.Location = new System.Drawing.Point(12, 288);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(125, 60);
			this.SaveButton.TabIndex = 1;
			this.SaveButton.Text = "Сохранить";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ExitButton.Location = new System.Drawing.Point(414, 288);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(178, 60);
			this.ExitButton.TabIndex = 2;
			this.ExitButton.Text = "Выйти в главное меню";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// StudentsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 360);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.studentsGrid);
			this.Name = "StudentsForm";
			this.Text = "StudentsForm";
			this.Shown += new System.EventHandler(this.StudentsForm_Shown);
			((System.ComponentModel.ISupportInitialize)(this.studentsGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView studentsGrid;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button ExitButton;
	}
}