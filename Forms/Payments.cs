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
    public partial class Payments : Form
    {
        ApplicationDbContext _context = new ApplicationDbContext();
        public Payments()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Payments_Load(object sender, EventArgs e)
        {
            //var costs = _context.Payments.Select(s =>s);
            var costs = _context.Payments.Select(s =>s).FirstOrDefault();
            if (costs != null)
            {
               dataGridViewPayment.Rows.Add(costs.Fees, costs.TeacherSalary, costs.EmployeeSalary, costs.Cost, costs.Donation);
                TxtBoxStore.Text = (costs.Fees + costs.Donation - costs.Cost - costs.TeacherSalary - costs.EmployeeSalary).ToString();
                //foreach (var item in costs)
                //{
                //    dataGridViewPayment.Rows.Add(item.Fees,item.TeacherSalary,item.EmployeeSalary,item.Cost,item.Donation);
                //}
            }
            else if(costs ==null)
            {
                Payment payment = new Payment()
                {
                    Fees=0,
                    EmployeeSalary=0,
                    TeacherSalary=0,
                    Donation=0,
                    Cost=0,
                };
                _context.Payments.Add(payment);
                _context.SaveChanges();
                //show data
                 costs = _context.Payments.Select(s => s).FirstOrDefault();
                dataGridViewPayment.Rows.Add(costs.Fees, costs.TeacherSalary, costs.EmployeeSalary, costs.Cost, costs.Donation);

                //foreach (var item in costs)
                //{
                //    dataGridViewPayment.Rows.Add(item.Fees, item.TeacherSalary, item.EmployeeSalary, item.Cost, item.Donation);
                //}
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewPayment.Rows.Clear();
            var costs = _context.Payments.Select(s => s).FirstOrDefault();
            //var costs = _context.Payments.Select(s => s);
            if (costs != null)
            {
                dataGridViewPayment.Rows.Add(costs.Fees, costs.TeacherSalary, costs.EmployeeSalary, costs.Cost, costs.Donation);

                //foreach (var item in costs)
                //{
                //    dataGridViewPayment.Rows.Add(item.Fees, item.TeacherSalary, item.EmployeeSalary, item.Cost, item.Donation);
                //}
            }
            else if (costs == null)
            {
                Payment payment = new Payment()
                {
                    Fees = 0,
                    EmployeeSalary = 0,
                    TeacherSalary = 0,
                    Donation = 0,
                    Cost = 0,
                };
                _context.Payments.Add(payment);
                _context.SaveChanges();
                //show data
                costs = _context.Payments.Select(s => s).FirstOrDefault();
                dataGridViewPayment.Rows.Add(costs.Fees, costs.TeacherSalary, costs.EmployeeSalary, costs.Cost, costs.Donation);

                //foreach (var item in costs)
                //{
                //    dataGridViewPayment.Rows.Add(item.Fees, item.TeacherSalary, item.EmployeeSalary, item.Cost, item.Donation);
                //}
            }
        }
    }
}
