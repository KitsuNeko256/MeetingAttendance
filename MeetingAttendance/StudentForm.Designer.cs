
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
			this.StudentsGrid = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.StudentsGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// StudentsGrid
			// 
			this.StudentsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.StudentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.StudentsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StudentsGrid.Location = new System.Drawing.Point(0, 0);
			this.StudentsGrid.Name = "StudentsGrid";
			this.StudentsGrid.RowTemplate.Height = 25;
			this.StudentsGrid.Size = new System.Drawing.Size(584, 361);
			this.StudentsGrid.TabIndex = 0;
			this.StudentsGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.StudentsGrid_CellBeginEdit);
			this.StudentsGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsGrid_CellEndEdit);
			this.StudentsGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.StudentsGrid_UserDeletingRow);
			// 
			// StudentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.StudentsGrid);
			this.Name = "StudentForm";
			this.Text = "StudentsForm";
			((System.ComponentModel.ISupportInitialize)(this.StudentsGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView StudentsGrid;
	}
}