namespace Mens_Beauty_Center
{
    partial class EmployeeShow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FNameTxt = new System.Windows.Forms.TextBox();
            this.LNameTxt = new System.Windows.Forms.TextBox();
            this.NationaIDTxt = new System.Windows.Forms.TextBox();
            this.PhoneTxt = new System.Windows.Forms.TextBox();
            this.FixedSalaryTxt = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.EmployeeDGView = new System.Windows.Forms.DataGridView();
            this.TypeCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDGView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "عرض الموظفين";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(956, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاسم الاول";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(957, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "الاسم الاخير";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(949, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "رقم الموبايل";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(956, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 38);
            this.label5.TabIndex = 3;
            this.label5.Text = "رقم البطاقة";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(945, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 38);
            this.label6.TabIndex = 6;
            this.label6.Text = "نوع الوظيفة";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(977, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 38);
            this.label7.TabIndex = 5;
            this.label7.Text = "اليومية";
            // 
            // FNameTxt
            // 
            this.FNameTxt.Location = new System.Drawing.Point(698, 89);
            this.FNameTxt.Name = "FNameTxt";
            this.FNameTxt.Size = new System.Drawing.Size(232, 37);
            this.FNameTxt.TabIndex = 7;
            // 
            // LNameTxt
            // 
            this.LNameTxt.Location = new System.Drawing.Point(698, 150);
            this.LNameTxt.Name = "LNameTxt";
            this.LNameTxt.Size = new System.Drawing.Size(232, 37);
            this.LNameTxt.TabIndex = 8;
            // 
            // NationaIDTxt
            // 
            this.NationaIDTxt.Location = new System.Drawing.Point(698, 220);
            this.NationaIDTxt.MaxLength = 14;
            this.NationaIDTxt.Name = "NationaIDTxt";
            this.NationaIDTxt.Size = new System.Drawing.Size(232, 37);
            this.NationaIDTxt.TabIndex = 9;
            this.NationaIDTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NationaIDTxt_KeyPress);
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.Location = new System.Drawing.Point(698, 286);
            this.PhoneTxt.MaxLength = 11;
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.Size = new System.Drawing.Size(232, 37);
            this.PhoneTxt.TabIndex = 10;
            this.PhoneTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTxt_KeyPress);
            // 
            // FixedSalaryTxt
            // 
            this.FixedSalaryTxt.Location = new System.Drawing.Point(698, 346);
            this.FixedSalaryTxt.Name = "FixedSalaryTxt";
            this.FixedSalaryTxt.Size = new System.Drawing.Size(232, 37);
            this.FixedSalaryTxt.TabIndex = 11;
            this.FixedSalaryTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FixedSalaryTxt_KeyPress);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(925, 468);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(114, 63);
            this.AddBtn.TabIndex = 13;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(746, 468);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(114, 63);
            this.UpdateBtn.TabIndex = 14;
            this.UpdateBtn.Text = "تعديل";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // EmployeeDGView
            // 
            this.EmployeeDGView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeDGView.DefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeDGView.Location = new System.Drawing.Point(12, 89);
            this.EmployeeDGView.Name = "EmployeeDGView";
            this.EmployeeDGView.ReadOnly = true;
            this.EmployeeDGView.RowHeadersWidth = 62;
            this.EmployeeDGView.RowTemplate.Height = 28;
            this.EmployeeDGView.Size = new System.Drawing.Size(670, 442);
            this.EmployeeDGView.TabIndex = 15;
            this.EmployeeDGView.Click += new System.EventHandler(this.EmployeeDGView_Click);
            // 
            // TypeCB
            // 
            this.TypeCB.FormattingEnabled = true;
            this.TypeCB.Location = new System.Drawing.Point(698, 414);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(232, 38);
            this.TypeCB.TabIndex = 16;
            // 
            // EmployeeShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 543);
            this.Controls.Add(this.TypeCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeDGView);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.FixedSalaryTxt);
            this.Controls.Add(this.PhoneTxt);
            this.Controls.Add(this.NationaIDTxt);
            this.Controls.Add(this.LNameTxt);
            this.Controls.Add(this.FNameTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "EmployeeShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FNameTxt;
        private System.Windows.Forms.TextBox LNameTxt;
        private System.Windows.Forms.TextBox NationaIDTxt;
        private System.Windows.Forms.TextBox PhoneTxt;
        private System.Windows.Forms.TextBox FixedSalaryTxt;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.DataGridView EmployeeDGView;
        private System.Windows.Forms.ComboBox TypeCB;
    }
}