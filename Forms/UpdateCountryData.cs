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
    public partial class UpdateCountryData : Form
    {

        private ApplicationDbContext dbContext = new ApplicationDbContext(); // Replace with your DbContext




        Country country;

        public UpdateCountryData(Country _country)
        {
            InitializeComponent();

            this.country = _country;

        }

        private void UpdateCountryData_Load(object sender, EventArgs e)
        {
            textBox1.Text = country.Name;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            country.Name = textBox1.Text;


            string arabicPattern = @"^[\p{IsArabic}\s]{3,}$";
            Regex regex = new Regex(arabicPattern, RegexOptions.Compiled);


            if (regex.IsMatch(textBox1.Text)
                && dbContext.Countries.FirstOrDefault(b => b.Name == textBox1.Text) == null)
            {


                DialogResult confirm = MessageBox.Show("هل تريد تعدبل بيانات هذه القرية ؟", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    foreach (var item in dbContext.Countries)
                    {
                        if (item.CountryId == country.CountryId)
                        {
                            item.Name = country.Name;

                            // item.Gender = student.Gender;
                        }
                    }


                    dbContext.SaveChanges();
                    this.Close();
                }
            }

            else
            {
                if (dbContext.Countries.FirstOrDefault(b => b.Name == textBox1.Text) != null)
                {
                    label1.Visible = true;
                    label1.Text = "الاسم موجود بالفعل ";
                }

                else
                {
                    label1.Visible = true;
                    label1.Text = "ادخل اسم صحيح";

                }
                MessageBox.Show("اكمل البيانات");

            }


        }






    }
}
