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
    }
}
