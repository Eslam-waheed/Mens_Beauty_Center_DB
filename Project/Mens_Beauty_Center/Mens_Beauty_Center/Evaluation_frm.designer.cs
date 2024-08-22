
namespace Mens_Beauty_Center
{
    partial class Evaluation_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Evaluation_frm));
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_percent = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_emp = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_enable = new System.Windows.Forms.Button();
            this.cb_month = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_add.Enabled = false;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_add.Location = new System.Drawing.Point(62, 435);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(108, 37);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "إضـافـة";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            this.btn_add.MouseEnter += new System.EventHandler(this.btn_add_MouseEnter);
            this.btn_add.MouseLeave += new System.EventHandler(this.btn_add_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(304, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "الشهر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(267, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "إجمالي الشهر";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(301, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "النسبة";
            // 
            // txt_percent
            // 
            this.txt_percent.Enabled = false;
            this.txt_percent.Location = new System.Drawing.Point(62, 278);
            this.txt_percent.Name = "txt_percent";
            this.txt_percent.Size = new System.Drawing.Size(175, 20);
            this.txt_percent.TabIndex = 7;
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(62, 220);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(175, 20);
            this.txt_total.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(304, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "العامل";
            // 
            // cb_emp
            // 
            this.cb_emp.DisplayMember = "NationalID";
            this.cb_emp.Enabled = false;
            this.cb_emp.FormattingEnabled = true;
            this.cb_emp.Location = new System.Drawing.Point(62, 342);
            this.cb_emp.Name = "cb_emp";
            this.cb_emp.Size = new System.Drawing.Size(175, 21);
            this.cb_emp.TabIndex = 12;
            this.cb_emp.ValueMember = "NationalID";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_save.Enabled = false;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_save.Location = new System.Drawing.Point(264, 435);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(108, 37);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "حــفــظ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(390, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(649, 472);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(466, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "الحوافز الشهرية";
            // 
            // btn_enable
            // 
            this.btn_enable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_enable.BackgroundImage")));
            this.btn_enable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_enable.Location = new System.Drawing.Point(62, 54);
            this.btn_enable.Name = "btn_enable";
            this.btn_enable.Size = new System.Drawing.Size(49, 37);
            this.btn_enable.TabIndex = 22;
            this.btn_enable.UseVisualStyleBackColor = true;
            this.btn_enable.Click += new System.EventHandler(this.btn_enable_Click);
            // 
            // cb_month
            // 
            this.cb_month.Enabled = false;
            this.cb_month.FormattingEnabled = true;
            this.cb_month.Location = new System.Drawing.Point(62, 167);
            this.cb_month.Name = "cb_month";
            this.cb_month.Size = new System.Drawing.Size(175, 21);
            this.cb_month.TabIndex = 23;
            // 
            // Evaluation_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 573);
            this.Controls.Add(this.cb_month);
            this.Controls.Add(this.btn_enable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cb_emp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_percent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.MaximizeBox = false;
            this.Name = "Evaluation_frm";
            this.Text = "Evaluation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Evaluation_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_percent;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_emp;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_enable;
        private System.Windows.Forms.ComboBox cb_month;
    }
}