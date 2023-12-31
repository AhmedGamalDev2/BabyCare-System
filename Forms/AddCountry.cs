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
    public partial class AddCountry : Form
    {
        private ApplicationDbContext dbContext = new ApplicationDbContext(); // Replace with your DbContext

        public AddCountry()
        {
            InitializeComponent();
        }

        private void AddCountry_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string countryName = textBox1.Text;


            string arabicPattern = @"^[\p{IsArabic}\s]{3,}$";
            Regex regex = new Regex(arabicPattern, RegexOptions.Compiled);

            if (string.IsNullOrEmpty(countryName) || !regex.IsMatch(countryName))
            {
                lbl2.Visible = true;
            }
            else
            {
                lbl2.Visible = false;

                bool countryExists = dbContext.Countries
                    .Any(b => b.Name == textBox1.Text);

                if (countryExists)
                {
                    MessageBox.Show("الاسم موجود بالفعل");

                }

                else
                {
                    dbContext.Countries.Add(new Models.Country { Name = textBox1.Text });
                    MessageBox.Show("تم الاضافه بنجاح");
                    textBox1.Text = "";
                    dbContext.SaveChanges();
                }

            }


        }



    }
    }

