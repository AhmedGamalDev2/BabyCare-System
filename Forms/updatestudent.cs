using DarAlArqamForm.Data;
using DarAlArqamForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DarAlArqamForm.Forms
{
    public partial class updatestudent : Form
    {
        ApplicationDbContext context=new ApplicationDbContext();
        Student student;
        public updatestudent(Student st)
        {
            student= st;
            InitializeComponent();
        }


        //fill student data
        private void updatestudent_Load_1(object sender, EventArgs e)
        {
           
            txt_Name.Text = student.Name;
            txt_phone.Text = student.Phone;
            if(student.Gender==radioButton_F.Text){ radioButton_F.Checked = true; }
            else
            {
                radioButton_M.Checked = true;
            }
            date_birth.Value = student.BirthDate;
            ////////////combobox for countries
            comboBox_country1.DataSource = context.Countries.Select(o => o.Name).ToList();
            int index = comboBox_country1.Items.IndexOf(context.Countries.Where(w=>w.CountryId==student.CountryId).FirstOrDefault().Name);
            comboBox_country1.SelectedIndex = index;
////////////combobox for classes
            comboBox_class1.DataSource = context.ClassRooms.Select(o => o.Name).ToList();
            int index1 = comboBox_class1.Items.IndexOf(context.ClassRooms.Where(w => w.ClassRoomId == student.ClassRoomId).FirstOrDefault().Name);
            comboBox_class1.SelectedIndex = index1;
 ////////////combobox for branches
            comboBox_branch1.DataSource = context.Branches.Select(o => o.Name).ToList();
            int index2 = comboBox_branch1.Items.IndexOf(context.Branches.Where(w => w.BranchId == student.BranchId).FirstOrDefault().Name);
            comboBox_branch1.SelectedIndex = index2;
////////////combobox for levels
            comboBox_level1.DataSource = context.levels.Select(o => o.Name).ToList();
            int index3 = comboBox_level1.Items.IndexOf(context.levels.Where(w => w.LevelId == student.LevelId).FirstOrDefault().Name);
            comboBox_level1.SelectedIndex = index3;



        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int count = 0;


            // Define a regular expression pattern for Arabic text
            string arabicPattern = @"^[\p{IsArabic}\s]{2,}$";

            // Create a Regex object with the compiled pattern
            Regex regex = new Regex(arabicPattern, RegexOptions.Compiled);





            //name check

            if (regex.IsMatch(txt_Name.Text) && txt_Name.Text.Trim().Length >= 2)
            {
                count++;
                label_NameError.Visible = false;


            }
            else
            {
                label_NameError.Visible = true;
            }
            //phone check
            // Define a regular expression pattern for phone 
            string phonePattern = @"^(\+201|01|00201)[0-2,5]{1}[0-9]{8}$";

            // Create a Regex object with the compiled pattern
            Regex reg = new Regex(phonePattern, RegexOptions.Compiled);


            if (reg.IsMatch(txt_phone.Text))
            {
                count++;
                label_PhoneError.Visible = false;
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
                month = month - 12;
                year = year + 1;


            }
            int day = date_birth.Value.Day;
            if (DateTime.DaysInMonth(year, month) < day)
            {

                day = day - DateTime.DaysInMonth(year, month);
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




            if (birthdate <= checkdate && birthdate.AddYears(3) >= checkdate)
            {
                // MessageBox.Show($"{birthdate.AddYears( 3)}");
                count++;
                label_birth.Visible = false;
            }
            else
            {
                if (birthdate > checkdate)
                    label_birth.Text = "العمر اقل من السن المطلوب";
                else
                    label_birth.Text = "العمر اكبر من السن المطلوب";

                label_birth.Visible = true;

            }
            string gend = "";
            //gender check
            if (radioButton_F.Checked || radioButton_M.Checked)
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


            //fill object of student with data
            student.Name = txt_Name.Text;
            student.BirthDate =date_birth.Value;
            student.BranchId = context.Branches.Where(z => z.Name == comboBox_branch1.Text).FirstOrDefault().BranchId;
            student.ClassRoomId = context.ClassRooms.Where(z => z.Name == comboBox_class1.Text).FirstOrDefault().ClassRoomId;
            student.CountryId = context.Countries.Where(z => z.Name == comboBox_country1.Text).FirstOrDefault().CountryId;
            student.LevelId = context.levels.Where(z => z.Name == comboBox_level1.Text).FirstOrDefault().LevelId;
            student.TeacherId = context.ClassRooms.Where(z => z.Name == comboBox_class1.Text).FirstOrDefault().TeacherId;
            student.Phone = txt_phone.Text;
            student.Gender = gend;


            if (count == 4)
            {
              //updata student data in database
                DialogResult confirm = MessageBox.Show("هل تريد تعدبل بيانات هذا الطالب؟", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    foreach (var item in context.Students)
                    {
                        if (item.StudentId == student.StudentId)
                        {
                            item.Name = student.Name;
                            item.BirthDate = student.BirthDate;
                            item.BranchId = student.BranchId;
                            item.ClassRoomId = student.ClassRoomId;
                            item.CountryId = student.CountryId;
                            item.LevelId = student.LevelId;
                            item.TeacherId = student.TeacherId;
                            item.Phone = student.Phone;
                            item.Gender = student.Gender;
                        }
                    }
               
                    context.SaveChanges();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("من فضلك ادخل البيانات كامله");
            }









        }
    }
}
