using DarAlArqamForm.Data;
using DarAlArqamForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarAlArqamForm.Forms
{
    public partial class UpdateTeacher : Form
    {
        Teacher teacher;
        ApplicationDbContext context = new ApplicationDbContext();

        public UpdateTeacher(Teacher teacher)
        {
            this.teacher = teacher;
            InitializeComponent();
        }
        
        private void RemoveTeacher_Load(object sender, EventArgs e)
        {
            txtName.Text = teacher.Name;
            txtPhone.Text = teacher.Phone;
            txtSalary.Text=Convert.ToString( teacher.Salary) ;
            comboBoxTEeacher.DataSource = context.Branches.Select(b => b.Name).ToList();// teacher.Branch.Name;


            // lstBranch.Text = Convert.ToString(teacher.Branch.Name);
            //comboBoxTEeacher.DisplayMember = "Name";
            //comboBoxTEeacher.ValueMember = "BranchId";
            // comboBoxTEeacher.SelectedValue = teacher.Branch.Name as string;
            //lstBranch.DataSource = context.Branches.Select(b => b.Name).ToList();

            // Find the branch with the same name as teacher.Branch.Name
            //var selectedBranch = context.Branches.FirstOrDefault(b => b.Name == teacher.Branch.Name);

            //if (selectedBranch != null)
            //{
            //    comboBoxTEeacher.SelectedValue = selectedBranch.BranchId; // Set the selected value to the branch's Id
            //}

        }

        private void  btnSave_Click(object sender, EventArgs e)
        {
            //TODO:: Unique Names 
            //txtName.Text=teacher.Name;
            //txtPhone.Text=teacher.Phone;
            // txtSalary.Text = Convert.ToString(teacher.Salary);
           // teacher.Name = txtName.Text;
           // teacher.Phone= txtPhone.Text;
           // teacher.Salary = Convert.ToDecimal(txtSalary.Text);
            //teacher.BranchId= comboBoxTEeacher.selected
            //TODO:: Unique Names 
            //teacher.BranchId =context.Branches.FirstOrDefault(b=>b.Name==comboBoxTEeacher.SelectedItem.ToString() ).BranchId;

            //MessageBox.Show(comboBoxTEeacher.SelectedItem.ToString() );
            //MessageBox.Show( comboBoxTEeacher.SelectedValue.ToString());
            //MessageBox.Show( comboBoxTEeacher.SelectedIndex.ToString());
            //MessageBox.Show(comboBoxTEeacher.SelectedText.ToString());
            
            //context.Teachers.AddOrUpdate(teacher);
            //try
            //{
            //    context.SaveChanges();
            //    MessageBox.Show("تم حفظ البيانات");

            //}catch 
            //{
            //    MessageBox.Show("هناك خطأ في حفظ البيانات");
            //}
            /********************************/
            var name = txtName.Text;
            var phone = txtPhone.Text;
            var salaryBool = decimal.TryParse(txtSalary.Text, out decimal salary);
            var branch = comboBoxTEeacher.SelectedItem as string; //unboxing
            //TODO:: Branch validation
            var branchOne = context.Branches.Where(w => w.Name == branch).FirstOrDefault();
            

            string arabicPattern = @"^[\p{IsArabic} ]+$";
            Regex regex = new Regex(arabicPattern, RegexOptions.IgnoreCase);

            string PhonePattern = @"^01\d{9}$";
            Regex regexPhone = new Regex(PhonePattern, RegexOptions.IgnoreCase);

         
            if (string.IsNullOrEmpty(name) || !regex.IsMatch(name))
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
                    if (!salaryBool || (salaryBool && salary < 0))
                    {
                        lblErrorSalary.Visible = true;
                    }
                    else
                    {
                        //TODO:: Branch validation
                        lblErrorSalary.Visible = false;
                        //var newTeacher = new Teacher()
                        //{
                        //    Name = name,
                        //    Phone = phone,
                        //    Salary = Convert.ToDecimal(salary),
                        //    BranchId = context.Branches.FirstOrDefault(b => b.Name == branch).BranchId
                        //};

                        //context.Teachers.Add(newTeacher);
                        //context.SaveChanges();
                        //MessageBox.Show("تم التسجيل بنجاح");
                        //call function to empty inputs
                        // EmptyTeacherInputs();

                        teacher.Name = name;
                        teacher.Phone = phone;
                        teacher.Salary=salary;
                        teacher.BranchId = context.Branches.FirstOrDefault(b => b.Name == comboBoxTEeacher.SelectedItem.ToString()).BranchId;
                        context.Teachers.AddOrUpdate(teacher);
                        try
                        {
                            context.SaveChanges();
                            MessageBox.Show("تم حفظ البيانات");

                        }
                        catch
                        {
                            MessageBox.Show("هناك خطأ في حفظ البيانات");
                        }

                    }
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblErrorSalary_Click(object sender, EventArgs e)
        {

        }
    }
}
