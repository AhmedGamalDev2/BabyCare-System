using DarAlArqamForm.Data;
using DarAlArqamForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarAlArqamForm.Forms
{
    public partial class Teachersalary : Form
    {
        ApplicationDbContext context =new ApplicationDbContext() ;
        public Teachersalary()
        {
            InitializeComponent();
        }

        private void Teachersalary_Load(object sender, EventArgs e)
        {
            foreach (var item in context.Teachers)
            {

                dataGridView1.Rows.Add(item.Name, item.Salary, "");

            
            }
        }

        
        private void btn_show_Click_1(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
            foreach (var item in context.Teachers)
            {


                var x = context.TeacherSalaries.FirstOrDefault(t => t.TeacherId == item.TeacherId
                && t.SalaryYearMonth.Month == dateTimePicker1.Value.Month
                && t.SalaryYearMonth.Year == dateTimePicker1.Value.Year
                );
                if (x == null)
                {
                    dataGridView1.Rows.Add(item.Name, item.Salary, "");
                }

                // dataGridView1.Columns.Add("","");
            }

        }

        private void btn_showall_Click_1(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
            foreach (var item in context.Teachers)
            {

                dataGridView1.Rows.Add(item.Name, item.Salary, "");

                // dataGridView1.Columns.Add("","");
            }
        }

        private void btn_pay_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                int id = context.Teachers.FirstOrDefault(g => g.Name == name).TeacherId;

                var x = context.TeacherSalaries.FirstOrDefault(t => t.TeacherId == id
                  && t.SalaryYearMonth.Month == dateTimePicker1.Value.Month
                  && t.SalaryYearMonth.Year == dateTimePicker1.Value.Year
                  );


                if (x == null)
                {
                    TeacherSalary teacher = new TeacherSalary();
                    teacher.TeacherId = id;
                    teacher.SalaryYearMonth = dateTimePicker1.Value;
                    teacher.IsPaid = true;
                    context.TeacherSalaries.Add(teacher);
                    var salarys = context.Payments.FirstOrDefault();
                    salarys.TeacherSalary += context.Teachers.FirstOrDefault(g => g.TeacherId == id).Salary;

                    context.SaveChanges();
                    MessageBox.Show("تم استلام الراتب");
                }
                else
                {

                    MessageBox.Show($"{dateTimePicker1.Value.Month} تم استلام الراتب عن شهر ");
                }



            }
        }
    }
}
