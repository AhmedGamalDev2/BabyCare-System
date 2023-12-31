using DarAlArqamForm.Data;
using DarAlArqamForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DarAlArqamForm.Forms
{
    public partial class AddTeacher : Form
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public AddTeacher(  )
        {
            InitializeComponent();
        }


        private void AddTeacher_Load(object sender, EventArgs e)
        {
            // Display the Branches names in list
            lstBranch.DataSource = context.Branches.Select(b => b.Name).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var name = txtName.Text;
            var phone = txtPhone.Text;
            var salaryBool = decimal.TryParse(txtSalary.Text, out decimal salary);
            var branch =  lstBranch.SelectedItem as string; //unboxing
            //TODO:: Branch validation
            var branchOne = context.Branches.Where(w => w.Name == branch).FirstOrDefault();
            // Create a Regex object with the compiled pattern
            //Regex regex = new Regex(pattern, RegexOptions.Compiled);
            //string className = textBox1.Text;        //from text box
            //string Pattern = @"^(\d+-\d+|[\p{IsArabic}\d]{2,})$";
            //Regex regex = new Regex(Pattern, RegexOptions.IgnoreCase);
            // Match the input string against the pattern
            // return regex.IsMatch(input);
            //string arabicPattern = @"^[\p{IsArabic}]{2,}[\p{IsArabic} ]*$";//هذا النمط يشير إلى أن الاسم الأول يجب أن يحتوي على حرفين عربيين على الأقل، ومن ثم يمكن أن يتبعه أي عدد من المسافات أو حروف عربية إضافية.
            //string arabicPattern = @"^[\p{IsArabic}]{2,}$";
            //string arabicPattern = @"^[\p{IsArabic}]{2,}(?:[\p{IsArabic}]{2,})*$

            //if (string.IsNullOrEmpty(className) || !regex.IsMatch(className))
            //{
            //    label1.Visible = true;
            //}


            string arabicPattern = @"^[\p{IsArabic} ]+$";
            Regex regex = new Regex(arabicPattern, RegexOptions.IgnoreCase);

            string PhonePattern = @"^01\d{9}$";
            Regex regexPhone = new Regex(PhonePattern, RegexOptions.IgnoreCase);

            if (branchOne == null)
            {

            }

            if (string.IsNullOrEmpty( name) || ! regex.IsMatch(name))
            {
                lblErrorName.Visible = true;
                lblErrorPhone.Visible = false;
                lblErrorSalary.Visible = false;
            }
            else
            {

                lblErrorName.Visible = false;
                //if (phone.Length == 0  )
                if (string.IsNullOrEmpty(phone) || !regexPhone.IsMatch(phone))
                {
                    lblErrorPhone.Visible = true;
                }
                else
                {
                    lblErrorPhone.Visible = false;
                    if (!salaryBool || (salaryBool && salary <  0) )
                    {
                        lblErrorSalary.Visible = true;
                    }
                    else
                    {
                        //TODO:: Branch validation
                        lblErrorSalary.Visible = false;
                        var newTeacher = new Teacher()
                        {
                            Name = name,
                            Phone = phone,
                            Salary = Convert.ToDecimal(salary),
                            BranchId = context.Branches.FirstOrDefault(b => b.Name == branch).BranchId
                        };

                        context.Teachers.Add(newTeacher);
                        context.SaveChanges();
                        MessageBox.Show("تم التسجيل بنجاح");
                        //call function to empty inputs
                        EmptyTeacherInputs();

                    }
                }
            }
  
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            //call function to empty inputs
            EmptyTeacherInputs();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void lstBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(lstBranch.Text);
        }

        #region Functions
        //function to empty all inputs in teacher
        void EmptyTeacherInputs()
        {
            txtName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtSalary.Text = string.Empty;
            lstBranch.Text = string.Empty;
        }


        #endregion
    }
}
