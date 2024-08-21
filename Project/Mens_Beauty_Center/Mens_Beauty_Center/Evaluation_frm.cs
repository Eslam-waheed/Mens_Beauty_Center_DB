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
    public partial class Evaluation_frm : Form
    {
        Mens_Beauty_Center_DBEntities my_context = new Mens_Beauty_Center_DBEntities();
        Evaluation ev;

        public Evaluation_frm()
        {
            InitializeComponent();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متاكد من اغلاق الصفحة", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void fillDGV()
        {
            // استعلام لربط جدول Evaluation مع Employee واسترجاع البيانات المطلوبة
            var q2 = from evv in my_context.Evaluations
                     join empp in my_context.Employees on evv.NationalID equals empp.NationalID
                     select new
                     {
                         ID = evv.NationalID,
                         Month = evv.Month,
                         TotalAmountOfMonth = evv.TotalAmountOfMonth,
                         ProfitPercentage = evv.ProfitPercentage,
                         Bonus = evv.Bonus,
                         FirstName = empp.FirstName
                     };

            var query = from ev in my_context.Evaluations
                        join emp in my_context.Employees on ev.NationalID equals emp.NationalID
                        select new
                        {
                            ID = ev.NationalID,
                            Month = ev.Month,
                            TotalAmountOfMonth = ev.TotalAmountOfMonth,
                            ProfitPercentage = ev.ProfitPercentage,
                            Bonus = ev.Bonus,
                            FirstName = emp.FirstName
                        };

            // تعيين البيانات إلى DataGridView
            dataGridView1.DataSource = q2.ToList();

            // تخصيص أسماء الأعمدة المعروضة في DataGridView
            dataGridView1.Columns["ID"].HeaderText = "رقم العامل";
            dataGridView1.Columns["Month"].HeaderText = "الشهر";
            dataGridView1.Columns["TotalAmountOfMonth"].HeaderText = "إجمالي الشهر";
            dataGridView1.Columns["ProfitPercentage"].HeaderText = "النسبة";
            dataGridView1.Columns["Bonus"].HeaderText = "الإضافي";
            dataGridView1.Columns["FirstName"].HeaderText = "اسم العامل";
        }
        private void enable_txts()
        {
            txt_month.Enabled = true;
            txt_percent.Enabled = true;
            txt_total.Enabled = true;
            cb_emp.Enabled = true;
        }

        private void clear_txts()
        {
            txt_month.Text = "";
            txt_percent.Text = "";
            txt_total.Text = "";
            cb_emp.SelectedIndex = 0;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // إنشاء كائن جديد من Evaluation
            ev = new Evaluation
            {
                Month = txt_month.Text,
                TotalAmountOfMonth = decimal.Parse(txt_total.Text),
                ProfitPercentage = decimal.Parse(txt_percent.Text),
                NationalID = cb_emp.SelectedValue.ToString()
            };

            // إضافة التقييم الجديد إلى السياق وحفظ التغييرات
            my_context.Evaluations.Add(ev);
            my_context.SaveChanges();

            MessageBox.Show("تم إضافة التقييم بنجاح!", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // تفريغ الحقول بعد الإضافة
            clear_txts();
            // Refresh DataGridView to reflect the newly added data
            fillDGV();
        }

        private void btn_add_MouseEnter(object sender, EventArgs e)
        {
            btn_add.BackColor = Color.MidnightBlue;
        }

        private void btn_add_MouseLeave(object sender, EventArgs e)
        {
            btn_add.BackColor = Color.SteelBlue;
        }

        private void Evaluation_frm_Load(object sender, EventArgs e)
        {
            fillDGV();
            //=======================//
            // تعبئة ComboBox بأسماء العاملين
            var employees = my_context.Employees.ToList();
            cb_emp.DataSource = employees;
            cb_emp.DisplayMember = "FirstName"; // عرض اسم العامل
            cb_emp.ValueMember = "NationalID"; // استخدام رقم العامل كقيمة
        }

        private void btn_enable_Click(object sender, EventArgs e)
        {
            enable_txts();
            clear_txts();
            btn_add.Enabled = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // التحقق من أن هناك صف محدد
            if (dataGridView1.CurrentRow != null)
            {
                // استخراج البيانات من الصف المحدد
                string month = dataGridView1.CurrentRow.Cells["Month"].Value.ToString();
                string totalAmount = dataGridView1.CurrentRow.Cells["TotalAmountOfMonth"].Value.ToString();
                string profitPercentage = dataGridView1.CurrentRow.Cells["ProfitPercentage"].Value.ToString();
                string nationalID = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();

                // تعبئة الحقول بناءً على القيم المستخرجة
                txt_month.Text = month;
                txt_total.Text = totalAmount;
                txt_percent.Text = profitPercentage;
                // تعيين العامل المناسب في ComboBox باستخدام NationalID
                cb_emp.SelectedValue = nationalID;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // الحصول على NationalID من الصف المحدد
                string nationalID = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                string month = dataGridView1.CurrentRow.Cells["Month"].Value.ToString();

                // البحث عن العنصر المحدد في قاعدة البيانات
                var evaluation = my_context.Evaluations.FirstOrDefault(ev => ev.NationalID == nationalID && ev.Month == month);

                if (evaluation != null)
                {
                    // تحديث القيم بالبيانات الجديدة من الحقول النصية
                    evaluation.TotalAmountOfMonth = decimal.Parse(txt_total.Text);
                    evaluation.ProfitPercentage = decimal.Parse(txt_percent.Text);
                    evaluation.Month = txt_month.Text;
                    evaluation.NationalID = cb_emp.SelectedValue.ToString(); // القيمة المختارة من ComboBox

                    // حفظ التغييرات في قاعدة البيانات
                    my_context.SaveChanges();

                    // تحديث DataGridView بعد حفظ التغييرات
                    fillDGV();

                    MessageBox.Show("تم حفظ التعديلات بنجاح!", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_save.Enabled = false;
                }
                else
                {
                    MessageBox.Show("لا يوجد عنصر محدد أو العنصر المحدد غير موجود!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            enable_txts();
            cb_emp.Enabled = false;
            btn_save.Enabled = true;
        }
    }
}
