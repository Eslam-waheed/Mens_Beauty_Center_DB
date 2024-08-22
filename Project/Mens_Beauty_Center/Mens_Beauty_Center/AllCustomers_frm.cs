using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mens_Beauty_Center
{
    public partial class AllCustomers_frm : Form
    {
        Mens_Beauty_Center_DBEntities my_context = new Mens_Beauty_Center_DBEntities();

        public AllCustomers_frm()
        {
            InitializeComponent();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متاكد من اغلاق الصفحة", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void AllCustomers_frm_Load(object sender, EventArgs e)
        {
            try
            {
                var customerData = my_context.Customers
                                             .Select(c => new
                                             {
                                                 c.Code,
                                                 c.Name,
                                                 c.PhoneNumber
                                             })
                                             .ToList();

                dataGridView1.DataSource = customerData;

                // تسمية الأعمدة
                dataGridView1.Columns["Code"].HeaderText = "الكود";
                dataGridView1.Columns["Name"].HeaderText = "الاسم";
                dataGridView1.Columns["PhoneNumber"].HeaderText = "رقم الهاتف";

                //تغيير حجم الأعمدة ليناسب حجم DGV
                dataGridView1.Columns["Code"].Width = 200;
                dataGridView1.Columns["Name"].Width = 200;
                dataGridView1.Columns["PhoneNumber"].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
