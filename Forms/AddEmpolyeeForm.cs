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

namespace DarAlArqamForm
{
    public partial class AddEmpolyeeForm : Form
        

    {
        private Employee employee;

        public AddEmpolyeeForm()
        {
            InitializeComponent();
            employee = new Employee();
            textBox1.DataBindings.Add("Text", employee, "Name");
            textBox2.DataBindings.Add("Text", employee, "Phone");
            textBox3.DataBindings.Add("Text", employee, "Salary");
        }

        private ApplicationDbContext GetApplicationDbContext()
        {
            return new ApplicationDbContext(); // Instantiate the DbContext properly
        }
        private bool ValidateName(string name)
        {
            string arabicPattern = @"^[\p{IsArabic}\s]{2,}$";

            Regex regex = new Regex(arabicPattern, RegexOptions.Compiled);
            string s = "";
            if (name.Length >= 2)
            {
                s = name.Substring(0, 2);
            }

            if (string.IsNullOrWhiteSpace(name) ||!regex.IsMatch(name) && s.Trim().Length == 2)
            {
                ErrorProvider.Text = "الإسم لا بد أن يحوي على الأقل حرفين";
                return false;
            }
            else
            {
                ErrorProvider.Text= ""; // Clear any previous error message
                return true;
            }
        }

        private bool ValidatePhoneNumber(string Number)
        {
            string PhoneNumber = new string(Number.Where(char.IsDigit).ToArray());

            if (PhoneNumber.Length == 11)
            {
                ErrorProvider.Text = ""; // Clear any previous error message
                return true;
               
            }
            else
            {
                ErrorProvider.Text = " الموبايل لابد لآن يكون 11 رقم";
                return false;
            }
        }
        private bool ValidateSalary(string salaryText, out decimal parsedSalary)
        {
            if (!decimal.TryParse(salaryText, out parsedSalary) || parsedSalary <= 0)
            {
                ErrorProvider.Text="الراتب لابد ان يكون أكبر من الصفر";
                return false;
            }
            else
            {
                ErrorProvider.Text = ""; // Clear any previous error message
                return true;
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            string EmployeeName = employee.Name;
            string EmployeePhone = employee.Phone;
            decimal EmployeeSalary = employee.Salary;

           

            //// Validate the name
            //if (!ValidateName(EmployeeName))
            //{

            //    // Validation failed, don't proceed with saving
            //    //return;
            //}
            //else
            //{
                
            //}

            //if (!ValidatePhoneNumber(EmployeePhone))
            //{
            //    // Validation failed, don't proceed with saving
            //   // return;
            //}

            //if (!ValidateSalary(textBox3.Text, out EmployeeSalary))
            //{
            //    // Validation failed for the salary, don't proceed with saving
            //  //  return;
            //}



            if (ValidateSalary(textBox3.Text, out EmployeeSalary)&& ValidatePhoneNumber(EmployeePhone)&& ValidateName(EmployeeName)) {
                using (var context = GetApplicationDbContext())
                {
                    context.Employees.Add(employee); // Add new employee
                    context.SaveChanges();
                }

                // After saving
                this.Close();
            }

        }

        private void AddEmpolyeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
