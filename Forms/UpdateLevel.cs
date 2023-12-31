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
    public partial class UpdateLevel : Form
    {

        ApplicationDbContext context = new ApplicationDbContext();

        public UpdateLevel()
        {
            InitializeComponent();
            AddToDataGridView();

        }

        //fill gridview  from database
        private void AddToDataGridView()
        {
            dataGridView2.RightToLeft = RightToLeft.Yes;

            var leveles = context.levels.Select(t => t).ToList();

            if (leveles != null)
            {
                foreach (var item in leveles)
                {
                    dataGridView2.Rows.
                        Add(item.Name);
                }
            }

        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Level level = new Level();

            // Create an instance of Form2 with the selected name
            AddLevel form2 = new AddLevel(level);
            var showform = form2.ShowDialog();
            if (showform == DialogResult.Cancel)
            {
                if (level.Name != null)
                    dataGridView2.Rows.Add(level.Name);

            }

            else
            {
                MessageBox.Show("من فضلك اختر صف واحد");
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {

                // Get the cell value as a string
                var selectedId = dataGridView2.SelectedRows[0].Cells[0].Value;

                // Validate if the cell value is not null and is a valid integer
                if (selectedId != null)
                {

                    //{
                    string LevelName = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();

                    // Get Donation Id
                    int LevelId = context.levels
                        .Where( L => L.Name == LevelName)
                        .Select(L => L.LevelId)
                        .FirstOrDefault();



                    var LevelToDelete = context.levels
                        .FirstOrDefault(L =>
                           L.LevelId == LevelId &&
                           L.Name == LevelName);

                    context.levels.Remove(LevelToDelete);
                    context.SaveChanges();

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

                var item = context.levels.FirstOrDefault(L => L.Name == name);



                // Create an instance of Form2 with the selected name
                UpdateLevelData form2 = new UpdateLevelData(item);
                var showform = form2.ShowDialog();
                if (showform == DialogResult.Cancel)
                {
                    dataGridView2.Rows[index].Cells[0].Value = item.Name;
                  
                }
            }
            else
            {
                MessageBox.Show("من فضلك اختر صف واحد");
            }
        }
    }
}
