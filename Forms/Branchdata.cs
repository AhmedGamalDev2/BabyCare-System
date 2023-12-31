using DarAlArqamForm.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarAlArqamForm
{
    public partial class Branchdata : Form
    {

        private ApplicationDbContext dbContext = new ApplicationDbContext(); // Replace with your DbContext


        public Branchdata()
        {
            InitializeComponent();
            fillGridView();

        }

        public void fillGridView()
        {

            var branches = dbContext.Branches.Select(t => t).ToList();

            if (branches != null)
            {
                foreach (var item in branches)
                {
                    dataGridView1.Rows.Add(item.Name);
                }
            }
        }






        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var selectedValue = dataGridView1.SelectedRows[0].Cells[0].Value;

                    if (selectedValue != null)
                    {
                        string branchNameValue = selectedValue.ToString();

                        var branchToDelete = dbContext.Branches.
                            FirstOrDefault(c => c.Name == branchNameValue);

                        if (branchToDelete != null)
                        {
                            dbContext.Branches.Remove(branchToDelete);
                            dbContext.SaveChanges();
                            MessageBox.Show("تم الحذف بنجاح");

                            // Remove the selected row from the DataGridView
                            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                        }
                        else
                        {
                            MessageBox.Show("الفرع غير موجودة في قاعدة البيانات");
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
            catch (DbUpdateException ex)
            {
                var innerException = ex.InnerException;
                // Log or display the inner exception message
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                var item = dbContext.Branches.FirstOrDefault(b => b.Name == name);



                // Create an instance of Form2 with the selected name
                UpdateBranchData form2 = new UpdateBranchData(item);
                var showform = form2.ShowDialog();
                if(showform  ==DialogResult.Cancel)
                {

                    dataGridView1.Rows[index].Cells[0].Value = item.Name;


                }
            }
            else
            {
                MessageBox.Show("من فضلك اختر صف واحد");
            }
        }




        private void UpdateBranch_Load(object sender, EventArgs e)
        {

        }


        public void UpdateDataGridViewValue(string newValue)
        {
            // Update the DataGridView with the new value
            int rowIndex = dataGridView1.SelectedRows[0].Index;
            dataGridView1.Rows[rowIndex].Cells[0].Value = newValue;
        }


        

        


    }
}
