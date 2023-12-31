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
    public partial class EditMaterial : Form
    {
        ApplicationDbContext context = new ApplicationDbContext();
        Material material;
            public EditMaterial(Material _material)
        {
            material = _material;
            InitializeComponent();
        }

        private void EditMaterial_Load(object sender, EventArgs e)
        {
            textBox1.Text = material.Name;
            textBox2.Text = material.MaxDegree.ToString();
            textBox3.Text = material.MinDegree.ToString();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            string errorMessage = "";

            // Define a regular expression pattern for Arabic text
            string arabicPattern = @"^[\p{IsArabic}\s]{2,}$";

            // Create a Regex object with the compiled pattern
            Regex regex = new Regex(arabicPattern, RegexOptions.Compiled);

            // Name check
            if (regex.IsMatch(textBox1.Text) && textBox1.Text.Trim().Length >= 3)
            {
                count++;
            }
            else
            {
                errorMessage = "أدخل الإسم صحيحًا\n";
            }

    
            if (textBox2.Text.Length >= 2 && textBox2.Text.All(char.IsDigit))
            {
                count++;
            }
            else
            {
                errorMessage += "أدخل الرقم صحيحًا\n";
            }

            
           
            if (textBox3.Text.Length >= 2 && textBox2.Text.All(char.IsDigit))
            {
                count++;
            }
            else
            {
                errorMessage += "أدخل الراتب صحيحًا\n";
            }

            if (count == 3)
            {
                // Validate that a material with the specified MaterialId exists
                var existing = context.Materials.FirstOrDefault(item => item.MaterialId == material.MaterialId);

                if (existing != null)
                {
                    // Update material data in the database
                    existing.Name = textBox1.Text;
                    existing.MaxDegree = int.Parse(textBox2.Text) ;
                    existing.MinDegree = int.Parse(textBox3.Text);

                    context.SaveChanges();
                    this.Close();
                }
                else
                {
                    errorMessage += "المادة غير موجودة في قاعدة البيانات\n";
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("من فضلك ادخل البيانات كاملة\n" + errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
