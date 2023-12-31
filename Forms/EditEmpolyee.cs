using DarAlArqamForm.Data;
using DarAlArqamForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DarAlArqamForm.Forms
{
    public partial class EditEmpolyee : Form
    {
        ApplicationDbContext context = new ApplicationDbContext();
        Employee employee;
        public EditEmpolyee(Employee _employee)
        {
             employee = _employee;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EditEmpolyee_Load(object sender, EventArgs e)
        {
            textBox1.Text = employee.Name;
            textBox2.Text = employee.Phone;
            textBox3.Text = (employee.Salary).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            string errorMessage = ""; // Accumulate error messages

            // Define a regular expression pattern for Arabic text
            string arabicPattern = @"^[\p{IsArabic}\s]{2,}$";

            // Create a Regex object with the compiled pattern
            Regex regex = new Regex(arabicPattern, RegexOptions.Compiled);

            // Name check
            if (regex.IsMatch(textBox1.Text) && textBox1.Text.Trim().Length >= 2)
            {
                count++;
            }
            else
            {
                errorMessage = "أدخل الإسم صحيحًا\n";
            }

            // Phone check
            if (textBox2.Text.Length == 11)
            {
                count++;
            }
            else
            {
                errorMessage = "أدخل الرقم صحيحًا\n";
            }

            // Salary check
            decimal salary;
            if (decimal.TryParse(textBox3.Text, out salary))
            {
                count++;
            }
            else
            {
                errorMessage = "أدخل الراتب صحيحًا\n";
            }

            if (count == 3)
            {
                // Validate that an employee with the specified EmployeeId exists
                var existingEmployee = context.Employees.FirstOrDefault(item => item.EmployeeId == employee.EmployeeId);

                if (existingEmployee != null)
                {
                    // Update employee data in the database
                    employee.Name = textBox1.Text;
                    employee.Phone=textBox2.Text;
                    employee.Salary=salary;

                    existingEmployee.Name = employee.Name;
                    existingEmployee.Phone = employee.Phone;
                    existingEmployee.Salary = salary;

                    context.SaveChanges();
                    this.Close();
                }
                else
                {
                    errorMessage = "الموظف غير موجود في قاعدة البيانات\n";
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("من فضلك ادخل البيانات كاملة\n" + errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

