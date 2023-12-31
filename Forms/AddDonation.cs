using com.sun.xml.@internal.bind.v2.model.core;
using DarAlArqamForm.Data;
using DarAlArqamForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DarAlArqamForm
{
    public partial class AddDonation : Form
    {
        Donation donation;
        ApplicationDbContext context = new ApplicationDbContext();

        public AddDonation(Donation _donation)
        {

            InitializeComponent();
            this.donation = _donation;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string DonationName = txt_name.Text;
                decimal DonationValue = decimal.Parse(txt_value.Text);
                DateTime DonationDate = date_time.Value.Date;
                string DonationDescription = txt_description.Text;

                //check if this description is found or not
                var descCheck = context.Donations.Select(x => x.Description).FirstOrDefault(d => d == DonationDescription);

                List<string> validationErrors = new List<string>();

                string arabicPattern = @"^[\p{IsArabic}\s]{0,}$";
                Regex regex = new Regex(arabicPattern, RegexOptions.Compiled);

                if (string.IsNullOrEmpty(DonationName) || !regex.IsMatch(DonationName))
                {
                    validationErrors.Add("الاسم غير صحيح");
                    lbl_name.Visible = true;
                }

                if (!decimal.TryParse(txt_value.Text, out DonationValue) || DonationValue <= 0)
                {
                    validationErrors.Add("قيمة التبرع غير صحيحة");
                    lbl_value.Visible = true;
                }

                if (DonationDate > DateTime.Today)
                {
                    validationErrors.Add("التاريخ لا يجب أن  يكون في المستقبل");
                    lbl_date.Visible = true;
                }
                if (string.IsNullOrEmpty(DonationDescription) || !regex.IsMatch(DonationName) || descCheck != null)
                {
                    validationErrors.Add("هذا الوصف موجود بالفعل");
                    lbl_description.Visible = true;
                }

                if (validationErrors.Count > 0)
                {
                    string errorMessage = "الرجاء تصحيح الأخطاء التالية\n" + string.Join("\n", validationErrors);
                    MessageBox.Show(errorMessage);
                }
                else
                {
                    donation.Value = DonationValue;
                    donation.Date = DonationDate;
                    donation.Description = DonationDescription;
                    donation.Name = DonationName;


                    context.Donations.Add(new Models.Donation
                    {
                        Name = DonationName,
                        Value = DonationValue,
                        Date = DonationDate,
                        Description = DonationDescription
                    });


                    lbl_name.Visible = false;
                    lbl_value.Visible = false;
                    lbl_description.Visible = false;
                    lbl_date.Visible = false;

                    var dontion = context.Payments.FirstOrDefault();
                    dontion.Donation += DonationValue;

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

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDonation_Load(object sender, EventArgs e)
        {

        }
    }
}
