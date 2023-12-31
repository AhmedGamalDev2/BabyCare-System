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
    public partial class AddLevel : Form
    {
        Level level;
        ApplicationDbContext context = new ApplicationDbContext();


        public AddLevel(Level _level)
        {
            level = _level;
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int GeneralSettingId1 = context.GeneralSettings.FirstOrDefault()?.GeneralSettingId ?? 0;


            try
            {
                string LevelName = txt_name.Text;
               


                //check if this description is found or not
                //var descCheck = context.Donations.Select(x => x.Description).FirstOrDefault(d => d == DonationDescription);

                List<string> validationErrors = new List<string>();

                string arabicPattern = @"^[\p{IsArabic}\s]{2,}$";
                Regex regex = new Regex(arabicPattern, RegexOptions.Compiled);

                if (string.IsNullOrEmpty(LevelName) || !regex.IsMatch(LevelName))
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
                    
                    level.Name = LevelName;


                    context.levels.Add(new Models.Level
                    {
                        Name = LevelName,
                        GeneralSettingId = GeneralSettingId1

                    }) ;


                    lbl_name.Visible = false;
             

                    context.SaveChanges();

                    MessageBox.Show("تم الإضافة بنجاح.");

                    this.Close();

                }
            }
            catch
            {
                MessageBox.Show("حدث خطأ بسبب قاعدة البيانات.");
            }


        }
    }
}
