using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mens_Beauty_Center
{
    public partial class Attendane_frm : Form
    {
        Mens_Beauty_Center_DBEntities context = new Mens_Beauty_Center_DBEntities();

        public Attendane_frm()
        {
            InitializeComponent();
            FillDataGridViewEmp();
        }
<<<<<<< HEAD
=======
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متاكد من اغلاق الصفحة", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                e.Cancel = true;
        }
>>>>>>> df241c02bf75023a471056cc18ad2a729439c6ff
        private void FillDataGridViewEmp()
        {
            Employee emp = new Employee();
            var q = context.Employees.Select(em=>em);
            var EmpDataSource = context.Attendances.Join(q,x=>x.NationalID,x=>x.NationalID, (att,e) => new { اسم_الموظف = e.FirstName+" "+e.LastName, المصاريف_المسحوبة = att.ExpenseMoney, وقت_الحضور = att.ArrivalTime, وقت_الانصراف = att.DepartureTime, قبض_اليوم = att.DailyPocketMoney });
            AttendanceDGView.DataSource = EmpDataSource.ToList();
        }
    }
}
