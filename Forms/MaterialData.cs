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

namespace DarAlArqamForm.Forms
{
    public partial class MaterialData : Form
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public MaterialData()
        {
            InitializeComponent();



        }







        private void MaterialData_Load(object sender, EventArgs e)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var materialdata = context.Materials.ToList();
            var materialsList = materialdata.Select(m => new Material
            {
                MaterialId = m.MaterialId,
                Name = m.Name,
                MaxDegree = m.MaxDegree,
                MinDegree = m.MinDegree
            }).ToList();



            // Set the DataPropertyName for each column after setting the DataSource
            dataGridView1.Columns[0].DataPropertyName = "MaterialId";
            dataGridView1.Columns[1].DataPropertyName = "Name";
            dataGridView1.Columns[2].DataPropertyName = "MaxDegree";
            dataGridView1.Columns[3].DataPropertyName = "MinDegree";
            //dataGridView1.Columns[4].Visible = false;




            dataGridView1.DataSource = materialsList;

            dataGridView1.Columns[4].Visible = false;










        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMaterial addMaterial = new AddMaterial();

            addMaterial.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var materialdata = context.Materials.ToList();
            var materialsList = materialdata.Select(m => new Material
            {
                MaterialId = m.MaterialId,
                Name = m.Name,
                MaxDegree = m.MaxDegree,
                MinDegree = m.MinDegree
            }).ToList();



            // Set the DataPropertyName for each column after setting the DataSource
            dataGridView1.Columns[0].DataPropertyName = "MaterialId";
            dataGridView1.Columns[1].DataPropertyName = "Name";
            dataGridView1.Columns[2].DataPropertyName = "MaxDegree";
            dataGridView1.Columns[3].DataPropertyName = "MinDegree";
            dataGridView1.Columns[4].Visible = false;




            dataGridView1.DataSource = materialsList;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteMaterial deleteMaterial = new DeleteMaterial();
            deleteMaterial.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                var maxdegree = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                var mindegree = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                int ind = dataGridView1.SelectedRows[0].Index;
                var edited = context.Materials.Where(a => a.Name == name).FirstOrDefault();
                EditMaterial editingform = new EditMaterial(edited);
                var dialogResult = editingform.ShowDialog();
                if (dialogResult == DialogResult.Cancel)
                {
                    //update date in datagridview in selected column
                    edited = context.Materials.Where(a => a.MaterialId == edited.MaterialId).FirstOrDefault();
                    dataGridView1.Rows[ind].Cells[1].Value = edited.Name;
                    dataGridView1.Rows[ind].Cells[2].Value = edited.MaxDegree;
                    dataGridView1.Rows[ind].Cells[3].Value = edited.MinDegree;
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("حدث خطأ");

            }
            
        }
    }
}
