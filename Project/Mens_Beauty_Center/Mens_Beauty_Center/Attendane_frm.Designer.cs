namespace Mens_Beauty_Center
{
    partial class Attendane_frm
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
            this.AttendanceDGView = new System.Windows.Forms.DataGridView();
            this.lblAttendance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceDGView)).BeginInit();
            this.SuspendLayout();
            // 
            // AttendanceDGView
            // 
            this.AttendanceDGView.AllowUserToAddRows = false;
            this.AttendanceDGView.AllowUserToDeleteRows = false;
            this.AttendanceDGView.AllowUserToResizeColumns = false;
            this.AttendanceDGView.AllowUserToResizeRows = false;
            this.AttendanceDGView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AttendanceDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendanceDGView.Location = new System.Drawing.Point(13, 58);
            this.AttendanceDGView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AttendanceDGView.Name = "AttendanceDGView";
            this.AttendanceDGView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AttendanceDGView.RowHeadersWidth = 62;
            this.AttendanceDGView.Size = new System.Drawing.Size(976, 451);
            this.AttendanceDGView.TabIndex = 4;
            // 
            // lblAttendance
            // 
            this.lblAttendance.AutoSize = true;
            this.lblAttendance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblAttendance.Location = new System.Drawing.Point(420, 9);
            this.lblAttendance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(112, 34);
            this.lblAttendance.TabIndex = 3;
            this.lblAttendance.Text = "الحضور";
            // 
            // Attendane_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1002, 523);
            this.Controls.Add(this.AttendanceDGView);
            this.Controls.Add(this.lblAttendance);
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Attendane_frm";
            this.Text = "Attendane_frm";
=======
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Attendane_frm";
            this.Text = "Attendane";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
>>>>>>> df241c02bf75023a471056cc18ad2a729439c6ff
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceDGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AttendanceDGView;
        private System.Windows.Forms.Label lblAttendance;
    }
}