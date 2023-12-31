using DarAlArqamForm.Data;
using DarAlArqamForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarAlArqamForm
{
    public partial class DonationUpdate : Form
    {

        ApplicationDbContext context = new ApplicationDbContext();


        public DonationUpdate()
        {
            InitializeComponent();
            AddToDataGridView();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //get from database
        private void AddToDataGridView()
        {
            dataGridView2.RightToLeft = RightToLeft.Yes;

            var classes = context.Donations.Select(t => t).ToList();

            if (classes != null)
            {
                foreach (var item in classes)
                {
                    dataGridView2.Rows.
                        Add(item.Name, item.Value, item.Date, item.Description);
                }
            }

        }

        //button delete
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {

                // Get the cell value as a string
                var selectedId = dataGridView2.SelectedRows[0].Cells[1].Value;

                // Validate if the cell value is not null and is a valid integer
                if (selectedId != null)
                {

                    //{
                    string DonationName = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                    decimal DonationValue = decimal.Parse(dataGridView2.SelectedRows[0].Cells[1].Value.ToString());
                    DateTime DonationDate = DateTime.Parse(dataGridView2.SelectedRows[0].Cells[2].Value.ToString());
                    string DonationDescription = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();

                    // Get Donation Id
                    int DonationId = context.Donations
                        .Where(D => D.Name == DonationName && D.Description == DonationDescription && D.Value == DonationValue)
                        .Select(D => D.DonationId)
                        .FirstOrDefault();



                    var DonationToDelete = context.Donations
                        .FirstOrDefault(D =>
                           D.DonationId == DonationId &&
                           D.Name == DonationName &&
                           D.Description == DonationDescription);

                    context.Donations.Remove(DonationToDelete);

                    context.SaveChanges();
                    var dontion = context.Payments.FirstOrDefault();
                    dontion.Donation -= DonationToDelete.Value;

                    MessageBox.Show("تم الحذف بنجاح");


                    // Remove the selected row from the DataGridView
                    dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);

                }

                else
                {
                    MessageBox.Show("الجدول فارغ");
                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                int index = dataGridView2.SelectedRows[0].Index;
                string name = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();

                var item = context.Donations.FirstOrDefault(b => b.Name == name);



                // Create an instance of Form2 with the selected name
                DonnationUpdateData form2 = new DonnationUpdateData(item);
                var showform = form2.ShowDialog();
                if (showform == DialogResult.Cancel)
                {
                    dataGridView2.Rows[index].Cells[0].Value = item.Name;
                    dataGridView2.Rows[index].Cells[1].Value = item.Value;
                    dataGridView2.Rows[index].Cells[2].Value = item.Date;
                    dataGridView2.Rows[index].Cells[3].Value = item.Description;

                }
            }
            else
            {
                MessageBox.Show("من فضلك اختر صف واحد");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Donation donation = new Donation();

            // Create an instance of Form2 with the selected name
            AddDonation form2 = new AddDonation(donation);
            var showform = form2.ShowDialog();
            if (showform == DialogResult.Cancel)
            {
                if(donation.Value != 0 && donation.Description != null)
                    dataGridView2.Rows.Add(donation.Name, donation.Value, donation.Date, donation.Description);

            }

            else
            {
                MessageBox.Show("من فضلك اختر صف واحد");
            }


}
    }
}
