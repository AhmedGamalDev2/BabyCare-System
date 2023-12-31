using DarAlArqamForm.Data;
using DarAlArqamForm.Forms;
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

namespace DarAlArqamForm
{
    public partial class EmpolyeeData : Form
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public EmpolyeeData()
        {
            InitializeComponent();
            //LoadEmployeeData();
        }

        private ApplicationDbContext GetApplicationDbContext()
        {
            return new ApplicationDbContext(); // Instantiate the DbContext properly
        }

        private void LoadEmployeeData()
        {
            //using (var context = GetApplicationDbContext())
            //{
            //    var employees = context.Employees.ToList();
            //    dataGridView1.DataSource = employees; // Set the DataGridView's DataSource to the list of employees
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{dataGridView1.ColumnCount}");

            //ApplicationDbContext context = new ApplicationDbContext();
            //var EmpolyeeData = context.Employees.ToList();
            //var EmpolyeeList = EmpolyeeData.Select(E => new Employee
            //{
            //     EmployeeId = E.EmployeeId,
            //    Name = E.Name,
            //    Phone = E.Phone,
            //    Salary = E.Salary
            //}).ToList();


             
            //// Set the DataPropertyName for each column after setting the DataSource
            ////dataGridView1.Columns[0].DataPropertyName = "EmployeeId";
            //dataGridView1.Columns[1].DataPropertyName = "Name";
            //dataGridView1.Columns[2].DataPropertyName = "Phone";
            //dataGridView1.Columns[3].DataPropertyName = "Salary";

            //dataGridView1.DataSource = EmpolyeeList;

            /*******************/
            dataGridView1.Rows.Clear();

            var employees = context.Employees.Select(t => t);
            if (employees != null)
            {
                foreach (var item in employees)
                {
                    //context.Branches.Find(item.BranchId);
                    dataGridView1.Rows.Add(item.Name,item.Phone, item.Salary);
                }
            }

        }
     

        private void EmpolyeeData_Load(object sender, EventArgs e)
        {
            ////MessageBox.Show($"{dataGridView1.ColumnCount}");
            //ApplicationDbContext context = new ApplicationDbContext();
            //var EmpolyeeData = context.Employees.ToList();
            //var EmpolyeeList = EmpolyeeData.Select(E => new Employee
            //{
            //    EmployeeId = E.EmployeeId,
            //    Name = E.Name,
            //    Phone = E.Phone,
            //    Salary = E.Salary
            //}).ToList();



            //// Set the DataPropertyName for each column after setting the DataSource
            ////dataGridView1.Columns[0].DataPropertyName = "EmployeeId";
            //dataGridView1.Columns[1].DataPropertyName = "Name";
            //dataGridView1.Columns[2].DataPropertyName = "Phone";
            //dataGridView1.Columns[3].DataPropertyName = "Salary";

            //dataGridView1.DataSource = EmpolyeeList;
            //dataGridView1.Columns[4].Visible = false;
            /********************/
            dataGridView1.Rows.Clear();

            var employees = context.Employees.Select(t => t);
            if (employees != null)
            {
                foreach (var item in employees)
                {
                    //context.Branches.Find(item.BranchId);
                    dataGridView1.Rows.Add(item.Name, item.Phone, item.Salary);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteEmpolyee deleteEmpolyee = new DeleteEmpolyee();
            deleteEmpolyee.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddEmpolyeeForm addEmpolyeeForm = new AddEmpolyeeForm();

            addEmpolyeeForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                var phone = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                var salary = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                int ind = dataGridView1.SelectedRows[0].Index;
                var edited = context.Employees.Where(a => a.Name == name && a.Phone == phone).FirstOrDefault();
                EditEmpolyee editingform = new EditEmpolyee(edited);
                var dialogResult = editingform.ShowDialog();
                if (dialogResult == DialogResult.Cancel)
                {
                    //update date in datagridview in selected column

                    dataGridView1.Rows[ind].Cells[0].Value = edited.EmployeeId;
                    dataGridView1.Rows[ind].Cells[1].Value = edited.Name;
                    dataGridView1.Rows[ind].Cells[2].Value = edited.Phone;
                    dataGridView1.Rows[ind].Cells[3].Value = edited.Salary;


                    //EditEmpolyee editEmpolyee = new EditEmpolyee();
                    //editEmpolyee.Show();    
                }
            }
            else
            {

                MessageBox.Show("من فضلك اختر صف");
            }



        }
    }
}
