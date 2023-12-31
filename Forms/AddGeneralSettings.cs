using com.sun.tools.@internal.xjc.reader.gbind;
using DarAlArqamForm.Data;
using DarAlArqamForm.Models;
using javax.xml.crypto;
using org.omg.CORBA.DynAnyPackage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DarAlArqamForm.Forms
{
    public partial class AddGeneralSettings : Form

    {
        ApplicationDbContext context = new ApplicationDbContext();
        private GeneralSetting generalSetting = new GeneralSetting();   

        public AddGeneralSettings()
        {
            InitializeComponent();
       
    
        }

        private bool ValidateInput()
        {
            //bool isValid = true;
            //string errorMessage = "";
            int count = 0;

            // Validate the DateTime pickers
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
            if (textBox3.Value>=0)
            {
                count++;
            }

            if (count == 4)
            {
                return true;

            }
            else
                return false;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
           
        }

        private void AddGeneralSettings_Load(object sender, EventArgs e)
        {
            
           
        }
        private void reloading()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                generalSetting.AcceptanceDate = dateTimePicker1.Value;
                generalSetting.StudyEnd = dateTimePicker2.Value;
                generalSetting.PaymentValue = textBox3.Value;
                generalSetting.YearAge = int.Parse(textBox1.Text);
                generalSetting.MonthAge = int.Parse(textBox2.Text);
                try
                {
                    context.GeneralSettings.Add(generalSetting);
                    context.SaveChanges();
                    MessageBox.Show("تم الحفظ");
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ");

                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
