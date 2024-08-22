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
    public partial class Categories : Form
    {
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            EmployeeShow empShow = new EmployeeShow();
            empShow.Show();
        }

        public Categories()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PackageForm pkg = new PackageForm();
            pkg.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AllCustomers_frm customers = new AllCustomers_frm();
            customers.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Evaluation_frm evo = new Evaluation_frm();
            evo.Show();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متاكد من اغلاق الصفحة", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Attendane_frm attend = new Attendane_frm();
            attend.Show();
        }
    }
}
