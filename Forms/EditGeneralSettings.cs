using com.sun.org.apache.bcel.@internal.generic;
using DarAlArqamForm.Data;
using DarAlArqamForm.Models;
using IKVM.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarAlArqamForm.Forms
{
    public partial class EditGeneralSettings : Form
    {
        ApplicationDbContext context = new ApplicationDbContext();
        GeneralSetting generalSetting;
        public EditGeneralSettings(GeneralSetting _generalSetting)
        {
            this.generalSetting = _generalSetting;
            
            InitializeComponent();
        }

        private void EditGeneralSettings_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = generalSetting.AcceptanceDate;
            dateTimePicker2.Value = generalSetting.StudyEnd;
            textBox1.Text = generalSetting.YearAge.ToString();
            textBox2.Text = generalSetting.MonthAge.ToString();
            textBox3.Text = generalSetting.PaymentValue.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            //string errorMessage = ""; // Accumulate error messages

            // Define a regular expression pattern for Arabic text
            //string arabicPattern = @"^[\p{IsArabic}\s]{2,}$";

            // Create a Regex object with the compiled pattern
            //Regex regex = new Regex(arabicPattern, RegexOptions.Compiled);
            if (dateTimePicker1.Value < dateTimePicker2.Value && dateTimePicker1.Value.Year == DateTime.Now.Year)
            {
                count++;
            }
            if (int.TryParse(textBox1.Text, out int number))
            {
                count++;
            }
            if (int.TryParse(textBox2.Text, out int number2))
            {
                count++;
            }
            if (int.TryParse(textBox3.Text, out int number3))
            {
                count++;
            }

            if (count == 4)
            {

                // Validate that an employee with the specified EmployeeId exists
                var found = context.GeneralSettings.FirstOrDefault(item => item.GeneralSettingId == generalSetting.GeneralSettingId);

                if (found != null)
                {
                    generalSetting.AcceptanceDate = dateTimePicker1.Value;
                    generalSetting.StudyEnd = dateTimePicker2.Value;
                    generalSetting.YearAge = int.Parse(textBox1.Text);
                    generalSetting.MonthAge = int.Parse(textBox2.Text);
                    generalSetting.PaymentValue = decimal.Parse(textBox3.Text);
                    // Update employee data in the database
                    found.AcceptanceDate = dateTimePicker1.Value;
                    found.StudyEnd = dateTimePicker2.Value;
                    found.YearAge = int.Parse(textBox1.Text);
                    found.MonthAge = int.Parse(textBox2.Text);
                    found.PaymentValue =decimal.Parse( textBox3.Text);

                    context.GeneralSettings.AddOrUpdate(found);

                    context.SaveChanges();
                    this.Close();
                }
                else
                {
                    //errorMessage = "البيانات غير موجودة في قاعدة البيانات";
                    MessageBox.Show("البيانات غير موجودة في قاعدة البيانات");
                }
            }
            else
            {
                MessageBox.Show("من فضلك ادخل البيانات كاملة");
            }


        }
    }
}

