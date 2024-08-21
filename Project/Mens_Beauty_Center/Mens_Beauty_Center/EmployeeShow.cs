using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mens_Beauty_Center
{
    public partial class EmployeeShow : Form
    {
        Mens_Beauty_Center_DBEntities context = new Mens_Beauty_Center_DBEntities();
        public EmployeeShow()
        {
            InitializeComponent();
            var dataSource = new List<KeyValuePair<string, bool>>
            {
                new KeyValuePair<string,bool>("موظف" ,false),
                new KeyValuePair<string,bool>("كاشير" ,true)
            };
            TypeCB.DataSource = dataSource;
            TypeCB.DisplayMember = "Key";
            TypeCB.ValueMember = "Value";
            FillDataGridViewEmp();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متاكد من اغلاق الصفحة", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void NationaIDTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void PhoneTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void FixedSalaryTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
                string pattern = @"^01[0125]\d{8}$";
                var query = context.Employees.Select(emp => emp.NationalID);
                if (FNameTxt.Text == "" || LNameTxt.Text == "" || NationaIDTxt.Text == "" || PhoneTxt.Text == "" || FixedSalaryTxt.Text == "")
                    MessageBox.Show("يجب اكمال جميع البيانات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (query.Contains(NationaIDTxt.Text))
                    MessageBox.Show("الرقم القومي موجود بالفعل", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (NationaIDTxt.Text.Length < 14)
                    MessageBox.Show("الرقم القومي يجب ان يكون 14 رقم", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (PhoneTxt.Text.Length < 11)
                    MessageBox.Show("رقم الموبايل يجب ان يكون 11 رقم", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (!(Regex.IsMatch(PhoneTxt.Text, pattern)))
                    MessageBox.Show("رقم الموبايل يجب ان يبدء ب 010 او 011 او 012 او 015", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    context.SP_AddEmployee(FNameTxt.Text, LNameTxt.Text, NationaIDTxt.Text, PhoneTxt.Text, decimal.Parse(FixedSalaryTxt.Text), (bool)(TypeCB.SelectedValue));
                    context.SaveChanges();
                    MessageBox.Show("تمت اضافة الموظف بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FNameTxt.Text = "";
                    LNameTxt.Text = "";
                    NationaIDTxt.Text = "";
                    PhoneTxt.Text = "";
                    FixedSalaryTxt.Text = "";
                    FillDataGridViewEmp();
                }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string pattern = @"^01[0125]\d{8}$";
            var query = context.Employees.Select(emp => emp.NationalID);
            if (FNameTxt.Text == "" || LNameTxt.Text == "" || NationaIDTxt.Text == "" || PhoneTxt.Text == "" || FixedSalaryTxt.Text == "")
                MessageBox.Show("يجب اكمال جميع البيانات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (NationaIDTxt.Text.Length < 14)
                MessageBox.Show("الرقم القومي يجب ان يكون 14 رقم", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (PhoneTxt.Text.Length < 11)
                MessageBox.Show("رقم الموبايل يجب ان يكون 11 رقم", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!(Regex.IsMatch(PhoneTxt.Text, pattern)))
                MessageBox.Show("رقم الموبايل يجب ان يبدء ب 010 او 011 او 012 او 015", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                context.SP_UpdateEmployeeInfo(FNameTxt.Text, LNameTxt.Text, NationaIDTxt.Text, PhoneTxt.Text, decimal.Parse(FixedSalaryTxt.Text), (bool)(TypeCB.SelectedValue));
                context.SaveChanges();
                MessageBox.Show("تمت تعديل البيانات بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FNameTxt.Text = "";
                LNameTxt.Text = "";
                NationaIDTxt.Text = "";
                PhoneTxt.Text = "";
                FixedSalaryTxt.Text = "";
                FillDataGridViewEmp();
            }
        }

        private void EmployeeDGView_Click(object sender, EventArgs e)
        {
            int postion = EmployeeDGView.CurrentRow.Index;
            FNameTxt.Text = EmployeeDGView.Rows[postion].Cells[0].Value.ToString();
            LNameTxt.Text = EmployeeDGView.Rows[postion].Cells[1].Value.ToString();
            NationaIDTxt.Text = EmployeeDGView.Rows[postion].Cells[2].Value.ToString();
            PhoneTxt.Text = EmployeeDGView.Rows[postion].Cells[3].Value.ToString();
            FixedSalaryTxt.Text = EmployeeDGView.Rows[postion].Cells[4].Value.ToString();
            TypeCB.Text = EmployeeDGView.Rows[postion].Cells[5].Value.ToString();
        }
        private void FillDataGridViewEmp() 
        {
            var EmpDataSource = context.Employees.Select(emp => new { الاسم_الاول = emp.FirstName, اسم_العائلة = emp.LastName, رقم_البطاقة = emp.NationalID, التليفون = emp.PhoneNumber, اليومية = emp.FixedSalary, نوع_الوظيفة = emp.Type == true ? "كاشير" : "موظف" });
            EmployeeDGView.DataSource = EmpDataSource.ToList();
        }
    }
}
