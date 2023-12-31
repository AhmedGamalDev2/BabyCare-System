using DarAlArqamForm.Data;
using DarAlArqamForm.Models;
using iTextSharp.text.pdf;
using iTextSharp.text;
using java.lang.management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using java.awt;

namespace DarAlArqamForm
{
    public partial class AddStudent : Form
    {

       



        ApplicationDbContext context =new ApplicationDbContext() ;
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
    
            int count = 0;


            // Define a regular expression pattern for Arabic text
            string arabicPattern = @"^[\p{IsArabic}\s]{2,}$";
           
            // Create a Regex object with the compiled pattern
            Regex regex = new Regex(arabicPattern, RegexOptions.Compiled);
            string s="";
            if (txt_Name.Text.Length>=2)
            {
                 s = txt_Name.Text.Substring(0, 2);
            }
           


         

            //name check

            if (regex.IsMatch(txt_Name.Text)&& txt_Name.Text.Trim().Length>=2&& s.Trim().Length == 2) 
            {
                count++;
                label_NameError.Visible = false;


            }
            else
            {
                label_NameError.Visible = true;
            }
            //phone check
            string phonePattern = @"^(\+201|01|00201)[0-2,5]{1}[0-9]{8}$";

            // Create a Regex object with the compiled pattern
            Regex reg = new Regex(phonePattern, RegexOptions.Compiled);

            if (reg.IsMatch(txt_phone.Text))
            {
                count++;
                label_PhoneError.Visible= false;
            }
            else
            {
                label_PhoneError.Visible = true;
            }
            //birthdate check
            GeneralSetting generalSetting = context.GeneralSettings.FirstOrDefault();
            int year = date_birth.Value.Year + generalSetting.YearAge;
            int month = date_birth.Value.Month + generalSetting.MonthAge;
            if (month > 12)
            {
                month =month-12;
                year=year+1;
              
            
            }
            int day = date_birth.Value.Day;
            if(DateTime.DaysInMonth(year, month)<day)
            {
            
            day =day- DateTime.DaysInMonth(year, month);
                month++;
                if (month > 12)
                {
                    month = month - 12;
                    year = year + 1;


                }


            }


            
            DateTime checkdate = new DateTime(DateTime.Now.Year,
                generalSetting.AcceptanceDate.Month, generalSetting.AcceptanceDate.Day);
        
          
            DateTime birthdate = new DateTime(year, month, day);
            
            

       
            if (birthdate<=checkdate&& birthdate.AddYears(3) >= checkdate)
            {
               // MessageBox.Show($"{birthdate.AddYears( 3)}");
                count++;
                label_birth.Visible= false;
            }
            else
            {
                if (birthdate > checkdate)
                    label_birth.Text = "العمر اقل من السن المطلوب";
                else
                    label_birth.Text = "العمر اكبر من السن المطلوب";

                label_birth.Visible = true;
              
            }
            string gend="";
          //gender check
            if (radioButton_F.Checked||radioButton_M.Checked)
            {
                if (radioButton_F.Checked) 
                {
                    gend = radioButton_F.Text;
                }
                else
                {
                    gend = radioButton_M.Text;

                }
                count++;
                label_gender.Visible = false;
            }
            else
            {
                label_gender.Visible = true;

            }
           
            Student student = new Student() {

                Name = txt_Name.Text,
                BirthDate = date_birth.Value,
                BranchId = context.Branches.Where(z => z.Name == comboBox_branch.Text).FirstOrDefault().BranchId,
                ClassRoomId = context.ClassRooms.Where(z => z.Name == comboBox_class.Text).FirstOrDefault().ClassRoomId,
                CountryId = context.Countries.Where(z => z.Name == comboBox_country.Text).FirstOrDefault().CountryId,
                LevelId = context.levels.Where(z => z.Name == comboBox_level.Text).FirstOrDefault().LevelId,
                TeacherId = context.ClassRooms.Where(z => z.Name == comboBox_class.Text).FirstOrDefault().TeacherId,
                Phone = txt_phone.Text,
                Gender = gend,
                studentpay=input_money.Value
                
            };










            if (count==4)
            {
               
               DialogResult confirm= MessageBox.Show("هل تريد اضافة هذا الطالب؟", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    StudentPayment studentPayment = new StudentPayment();
                    context.Students.Add(student);
                    studentPayment.AddPaidValue = student.studentpay;
                    studentPayment.paymentYear = DateTime.Now;
                    studentPayment.StudentId = student.StudentId;
                    var fee = context.Payments.FirstOrDefault();
                    fee.Fees += student.studentpay;
                   
                    
                    DialogResult confirm1 = MessageBox.Show("هل تريد طباعه ايصال بالمقدم؟", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (confirm1 == DialogResult.OK)
                    {
                        reciept reciept = new reciept(student);
                        
                        reciept.addpaid(student.studentpay);
                        reciept.Show();
                        fee.Fees -= student.studentpay;
                        student.studentpay -= input_money.Value;
                    }
                    context.SaveChanges();

                    txt_Name.Text = "";
                    txt_phone.Text = "";
                    radioButton_F.Checked = false; radioButton_M.Checked = false;
                    date_birth.Value = DateTime.Now;
                    input_money.Value = 0;
                }
            
                
            }
            else
            {
                MessageBox.Show("من فضلك ادخل البيانات كامله");
            }












        }

        private void comboBox_level_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {



            //fill  class, country,branch and level combobox 

            comboBox_country.DataSource = context.Countries.Select(o => o.Name).ToList();
            comboBox_class.DataSource = context.ClassRooms.Select(o => o.Name).ToList();
            comboBox_branch.DataSource = context.Branches.Select(o => o.Name).ToList();
            comboBox_level.DataSource = context.levels.Select(o => o.Name).ToList();

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label_NameError_Click(object sender, EventArgs e)
        {

        }

        private void label_PhoneError_Click(object sender, EventArgs e)
        {

        }

        private void label_gender_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_country_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_branch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_class_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void date_birth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_F_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_M_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_birth_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

       




    }
}
