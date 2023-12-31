using com.itextpdf.text.pdf;
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
    public partial class DeleteEmpolyee : Form
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public DeleteEmpolyee()
        {
            InitializeComponent();
        }

        private void DeleteEmpolyee_Load(object sender, EventArgs e)
        {
            var EmpolyeeData = context.Employees.ToList();
            var EmpolyeeList = EmpolyeeData.Select(E => new Employee
            {
                EmployeeId = E.EmployeeId,
                Name = E.Name,
                Phone = E.Phone,
                Salary = E.Salary
            }).ToList();



            // Set the DataPropertyName for each column after setting the DataSource
            dataGridView1.Columns[0].DataPropertyName = "EmployeeId";
            dataGridView1.Columns[1].DataPropertyName = "Name";
            dataGridView1.Columns[2].DataPropertyName = "Phone";
            dataGridView1.Columns[3].DataPropertyName = "Salary";

            dataGridView1.DataSource = EmpolyeeList;
            dataGridView1.Columns[4].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                var phone = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
           

                Employee deleted = context.Employees.FirstOrDefault(E => E.Name == name && E.Phone == phone);

                if (deleted != null)
                {
                    // Delete the employee from the database
                    context.Employees.Remove(deleted);

                    // Save changes to the database
                    context.SaveChanges();

                    // The data-bound DataGridView will automatically update to reflect the deletion
                    MessageBox.Show($"تم حذف الموظف");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"لم يتم العثور على الموظف في قاعدة البيانات");
                }
            }
            else
            {
                MessageBox.Show($"يجب اختيار موظف واحد فقط");

            }
        }
    }
}

