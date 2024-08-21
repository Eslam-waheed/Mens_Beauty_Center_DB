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
        private void FillDataGridViewEmp()
        {
            Employee emp = new Employee();
            var q = context.Employees.Select(em=>em);
            var EmpDataSource = context.Attendances.Join(q,x=>x.NationalID,x=>x.NationalID, (att,e) => new { اسم_الموظف = e.FirstName+" "+e.LastName, المصاريف_المسحوبة = att.ExpenseMoney, وقت_الحضور = att.ArrivalTime, وقت_الانصراف = att.DepartureTime, قبض_اليوم = att.DailyPocketMoney });
            AttendanceDGView.DataSource = EmpDataSource.ToList();
        }
    }
}
