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
    public partial class UpdateLevelData : Form
    {
        private ApplicationDbContext context = new ApplicationDbContext(); // Replace with your DbContext
        Level level;

        string name1;



        public UpdateLevelData(Level _level)
        {
            level = _level;
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            try
            {
                level.Name = txt_name.Text;
             
                var existingLevel = context.levels.FirstOrDefault(L => L.Name == name1);

                List<string> validationErrors = new List<string>();

                string arabicPattern = @"^[\p{IsArabic}\s]{2,}$";
                Regex regex = new Regex(arabicPattern, RegexOptions.Compiled);

                if (existingLevel != null)
                {
                    // Donation with the same name found, proceed with update
                

                  

                    if (string.IsNullOrEmpty(level.Name) || !regex.IsMatch(level.Name))
                    {
                        validationErrors.Add("الاسم غير صحيح");
                        lbl_name.Visible = true;
                    }

                    if (validationErrors.Count > 0)
                    {
                        string errorMessage = "الرجاء تصحيح الأخطاء التالية\n" + string.Join("\n", validationErrors);
                        MessageBox.Show(errorMessage);
                    }
                    else
                    {
                        DialogResult confirm = MessageBox.Show("هل تريد تحديث بيانات هذا الصف؟", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirm == DialogResult.Yes)
                        {
                            // Update the existing donation
                            existingLevel.Name = level.Name;
                      
                            // Hide error labels
                            lbl_name.Visible = false;
                          
                            // Clear input fields
                            txt_name.Text = "";
                  
                            MessageBox.Show("تم التحديث بنجاح.");
                            context.SaveChanges();
                            this.Close();
                        }
                    }
                }
                else
                {
                    validationErrors.Add("الاسم غير موجود في قاعدة البيانات");
                    lbl_name.Visible = true;

                    string errorMessage = "الرجاء تصحيح الأخطاء التالية\n" + string.Join("\n", validationErrors);
                    MessageBox.Show(errorMessage);
                }
            }
            catch
            {
                MessageBox.Show("حدث خطأ بسبب قاعدة البيانات.");
            }



        }

        private void UpdateLevelData_Load(object sender, EventArgs e)
        {
            txt_name.Text = level.Name;
            name1 = level.Name;
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
