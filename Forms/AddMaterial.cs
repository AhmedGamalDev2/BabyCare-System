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

namespace DarAlArqamForm.Forms
{
    public partial class AddMaterial : Form
    {
        ApplicationDbContext context = new ApplicationDbContext();
        private Material material;
        public AddMaterial()
        {
            InitializeComponent();
            material = new Material();

            textBox2.DataBindings.Add("Text", material, "Name");
            textBox3.DataBindings.Add("Text", material, "MaxDegree");
            textBox4.DataBindings.Add("Text", material, "MinDegree");
        }

        private bool ValidateName(string name)
        {
            string arabicPattern = @"^[\p{IsArabic}]{2,}$";
            Regex regex = new Regex(arabicPattern, RegexOptions.IgnoreCase);
            

            if (string.IsNullOrWhiteSpace(name) || !regex.IsMatch(name))
            {
                ErrorProvider.Text = " الإسم لابد ان يحوي على الاقل حرفين باللغة العربية";
                return false;
            }
            else
            {
                ErrorProvider.Text = ""; // Clear any previous error message
                return true;
            }
        }

        private bool ValidateMaxDegree(string Number)
        {
            string MaxDegree = new string(Number.Where(char.IsDigit).ToArray());

            if (MaxDegree.Length <= 3 & MaxDegree.Length > 0)
            {
                ErrorProvider.Text = ""; // Clear any previous error message
                return true;

            }
            else
            {
                ErrorProvider.Text = " خانة الدرجة النهائية غير صحيحة";
                return false;
            }
        }

        private bool ValidateMinDegree(string Number)
        {
            string MinDegree = new string(Number.Where(char.IsDigit).ToArray());

            if (MinDegree.Length <= 3 & MinDegree.Length > 0)
            {
                ErrorProvider.Text = ""; // Clear any previous error message
                return true;

            }
            else
            {
                ErrorProvider.Text = " خانة الدرجة الصغرى غير صحيحة";
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MaterialName = material.Name;
            string MaterialMaxDegree = material.MaxDegree.ToString();
            string materialmindegree = material.MinDegree.ToString();



            // Validate the name
            if (!ValidateName(MaterialName))
            {
                // Validation failed, don't proceed with saving
                return;
            }
            else
            {

            }

            if (!ValidateMaxDegree(MaterialMaxDegree))
            {
                // Validation failed, don't proceed with saving
                return;
            }


            if (!ValidateMinDegree(materialmindegree))
            {
                // Validation failed, don't proceed with saving
                return;
            }


            context.Materials.Add(material);
            context.SaveChanges();
            this.Close();

         


        }
    }
    }

