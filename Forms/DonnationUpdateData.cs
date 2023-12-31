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
    public partial class DonnationUpdateData : Form
    {
        private ApplicationDbContext context = new ApplicationDbContext(); // Replace with your DbContext
        Donation donation;

        string name1;
        string desc1;

        public DonnationUpdateData(Donation _donation)
        {
            InitializeComponent();
            donation = _donation;
        }

        private void DonnationUpdateData_Load(object sender, EventArgs e)
        {
            txt_name.Text = donation.Name;
            txt_value.Text = donation.Value.ToString(); // Assuming Value is a decimal
            date_time.Value = donation.Date; // Assuming Date is a DateTime
            txt_description.Text = donation.Description;

            name1 = donation.Name;
            desc1 = donation.Description;


        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                donation.Name = txt_name.Text;
                 donation.Value = decimal.Parse(txt_value.Text.ToString());
                 donation.Date = date_time.Value.Date;
                 donation.Description = txt_description.Text;

                var existingDonation = context.Donations.FirstOrDefault(d => d.Name == name1 &&
                d.Description ==desc1);

                List<string> validationErrors = new List<string>();

                string arabicPattern = @"^[\p{IsArabic}\s]{3,}$";
                Regex regex = new Regex(arabicPattern, RegexOptions.Compiled);

                if (existingDonation != null)
                {
                    // Donation with the same name found, proceed with update
                    if (!decimal.TryParse(txt_value.Text, out  decimal value) || donation.Value <= 0)
                    {
                        validationErrors.Add("قيمة التبرع غير صحيحة");
                        lbl_value.Visible = true;
                    }

                    if (donation.Date > DateTime.Today)
                    {
                        validationErrors.Add("التاريخ لا يجب أن يكون في المستقبل");
                        lbl_date.Visible = true;
                    }

                    if (string.IsNullOrEmpty(donation.Description) || !regex.IsMatch(donation.Description))
                    {
                        validationErrors.Add("الوصف غير صحيح");
                        lbl_description.Visible = true;
                    }

                    if (validationErrors.Count > 0)
                    {
                        string errorMessage = "الرجاء تصحيح الأخطاء التالية\n" + string.Join("\n", validationErrors);
                        MessageBox.Show(errorMessage);
                    }
                    else
                    {
                        DialogResult confirm = MessageBox.Show("هل تريد تحديث بيانات هذا التبرع؟", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirm == DialogResult.Yes)
                        {
                            // Update the existing donation
                            existingDonation.Name = donation.Name;
                            existingDonation.Value = donation.Value;
                            existingDonation.Date = donation.Date;
                            existingDonation.Description = donation.Description;

                            // Hide error labels
                            lbl_name.Visible = false;
                            lbl_value.Visible = false;
                            lbl_description.Visible = false;
                            lbl_date.Visible = false;

                            // Clear input fields
                            txt_name.Text = "";
                            txt_value.Text = "";
                            txt_description.Text = "";
                            var dontion = context.Payments.FirstOrDefault();
                            dontion.Donation += donation.Value;
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




        //private void SaveBtn_Click(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        string DonationName = txt_name.Text;
        //        decimal DonationValue;
        //        DateTime DonationDate = date_time.Value.Date;
        //        string DonationDescription = txt_description.Text;

        //        //donation.Name = txt_name.Text;
        //        //donation.Value = decimal.Parse(txt_value.Text);
        //        //donation.Date = date_time.Value.Date;
        //        //donation.Description = txt_description.Text;






        //        //check if this description is found or not
        //        var descCheck = context.Donations.Select(x => x.Description).
        //            FirstOrDefault(d => d == DonationDescription);

        //        List<string> validationErrors = new List<string>();

        //        //updata student data in database
        //        string arabicPattern = @"^[\p{IsArabic}\s]{3,}$";
        //        // Create a Regex object with the compiled pattern
        //        Regex regex = new Regex(arabicPattern, RegexOptions.Compiled);

        //        if (regex.IsMatch(txt_name.Text) || string.IsNullOrEmpty(txt_name.Text) || context.Donations.FirstOrDefault(D => D.Name == txt_name.Text) != null)

        //        {
        //            validationErrors.Add("الاسم غير صحيح");
        //            lbl_name.Visible = true;
        //        }

        //        if (!decimal.TryParse(txt_value.Text, out DonationValue) || DonationValue <= 0)
        //        {
        //            validationErrors.Add("قيمة التبرع غير صحيحة");
        //            lbl_value.Visible = true;
        //        }

        //        if (DonationDate > DateTime.Today)
        //        {
        //            validationErrors.Add("التاريخ لا يجب أن  يكون في المستقبل");
        //            lbl_date.Visible = true;
        //        }
        //        if (string.IsNullOrEmpty(DonationDescription) ||!regex.IsMatch(DonationDescription) ||
        //            descCheck != null)
        //        {
        //            validationErrors.Add("هذا الوصف موجود بالفعل");
        //            lbl_description.Visible = true;
        //        }

        //        if (validationErrors.Count > 0)
        //        {
        //            string errorMessage = "الرجاء تصحيح الأخطاء التالية\n" + string.Join("\n", validationErrors);
        //            MessageBox.Show(errorMessage);
        //        }
        //        else
        //        {
        //            DialogResult confirm = MessageBox.Show("هل تريد تعدبل بيانات هذا التبرع؟", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //            if (confirm == DialogResult.Yes)
        //            {
        //                foreach (var item in context.Donations)
        //                {
        //                    if (item.DonationId == donation.DonationId)
        //                    {
        //                        item.Name = donation.Name;
        //                        item.Value = donation.Value;
        //                        item.Date = donation.Date;
        //                        item.Description = donation.Description;

        //                        //to hide labels error
        //                        lbl_name.Visible = false;
        //                        lbl_value.Visible = false;
        //                        lbl_description.Visible = false;
        //                        lbl_date.Visible = false;

        //                        //to remove text from inputs
        //                        txt_name.Text = "";
        //                        txt_value.Text = "";
        //                        txt_description.Text = "";
        //                    }
        //                }


        //                MessageBox.Show("تم التحديث بنجاح.");
        //                context.SaveChanges();
        //                this.Close();
        //            }






        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("حدث خطأ بسبب قاعدة البيانات.");
        //    }





        //}

        private void date_time_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
