
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
			this.TeachersGrid = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.TeachersGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// TeachersGrid
			// 
			this.TeachersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.TeachersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TeachersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TeachersGrid.Location = new System.Drawing.Point(0, 0);
			this.TeachersGrid.Name = "TeachersGrid";
			this.TeachersGrid.RowTemplate.Height = 25;
			this.TeachersGrid.Size = new System.Drawing.Size(422, 292);
			this.TeachersGrid.TabIndex = 9;
			this.TeachersGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.TeachersGrid_CellBeginEdit);
			this.TeachersGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeachersGrid_CellEndEdit);
			this.TeachersGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.TeachersGrid_UserDeletingRow);
			// 
			// TeacherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 292);
			this.Controls.Add(this.TeachersGrid);
			this.Name = "TeacherForm";
			this.Text = "TeacherForm";
			((System.ComponentModel.ISupportInitialize)(this.TeachersGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView TeachersGrid;
	}
}