using DarAlArqamForm.Data;
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
    public partial class Countrydata : Form
    {

        private ApplicationDbContext dbContext = new ApplicationDbContext(); // Replace with your DbContext


        public Countrydata()
        {
            InitializeComponent();
            fillGridView();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void fillGridView()
        {

            var countries = dbContext.Countries.Select(t => t).ToList();

            if (countries != null)
            {
                foreach (var item in countries)
                {
                    dataGridView1.Rows.Add(item.Name);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedValue = dataGridView1.SelectedRows[0].Cells[0].Value;

                if (selectedValue != null)
                {
                    string countryNameValue = selectedValue.ToString();

                    var countryToDelete = dbContext.Countries.FirstOrDefault(c => c.Name == countryNameValue);

                    if (countryToDelete != null)
                    {
                        dbContext.Countries.Remove(countryToDelete);
                        dbContext.SaveChanges();
                        MessageBox.Show("تم الحذف بنجاح");

                        // Remove the selected row from the DataGridView
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    }
                    else
                    {
                        MessageBox.Show("القرية غير موجودة في قاعدة البيانات");
                    }
                }
                else
                {
                    MessageBox.Show("الجدول فارغ.");
                }
            }
            else
            {
                MessageBox.Show("لم يتم اختيار عنصر.");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                var item = dbContext.Countries.FirstOrDefault(b => b.Name == name);



                // Create an instance of Form2 with the selected name
                UpdateCountryData form2 = new UpdateCountryData(item);
                var showform = form2.ShowDialog();
                if (showform == DialogResult.Cancel)
                {

                    dataGridView1.Rows[index].Cells[0].Value = item.Name;


                }
            }
            else
            {
                MessageBox.Show("من فضلك اختر صف واحد");
            }
        }


        public void UpdateDataGridViewValue(string newValue)
        {
            // Update the DataGridView with the new value
            int rowIndex = dataGridView1.SelectedRows[0].Index;
            dataGridView1.Rows[rowIndex].Cells[0].Value = newValue;
        }

    }
}