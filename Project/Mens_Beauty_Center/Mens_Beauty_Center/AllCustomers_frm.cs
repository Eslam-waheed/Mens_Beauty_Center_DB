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
            // TODO: This line of code loads data into the 'mens_Beauty_Center_DBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.mens_Beauty_Center_DBDataSet.Customer);
            
        }
    }
}
