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
    public partial class EmployeeSalarys : Form
    {
        ApplicationDbContext context= new ApplicationDbContext();
        public EmployeeSalarys()
        {
            InitializeComponent();
        }

        private void Salarys_Load(object sender, EventArgs e)
        {

            

            foreach (var item in context.Employees)
            {

                dataGridView1.Rows.Add(item.Name, item.Salary, "");

                // dataGridView1.Columns.Add("","");
            }

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount=1;
            foreach (var item in context.Employees)
            {

               
                var x = context.EmployeeSalaries.FirstOrDefault(t => t.EmployeeId == item.EmployeeId
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

        private void btn_showall_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
            foreach (var item in context.Employees)
            {

                dataGridView1.Rows.Add(item.Name, item.Salary, "");

                // dataGridView1.Columns.Add("","");
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
           
            if(dataGridView1.SelectedRows.Count==1)
            {
                string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                int id = context.Employees.FirstOrDefault(g=>g.Name== name ).EmployeeId;

             var x = context.EmployeeSalaries.FirstOrDefault(t => t.EmployeeId == id
               && t.SalaryYearMonth.Month == dateTimePicker1.Value.Month
               && t.SalaryYearMonth.Year == dateTimePicker1.Value.Year
               );


                if (x == null)
                {
                    EmployeeSalary employee = new EmployeeSalary();
                    employee.EmployeeId = id;
                    employee.SalaryYearMonth = dateTimePicker1.Value;
                    employee.IsPaid = true;
                    context.EmployeeSalaries.Add(employee);
                    var salarys = context.Payments.FirstOrDefault();
                    salarys.EmployeeSalary += context.Employees.FirstOrDefault(g => g.EmployeeId == id).Salary;
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
