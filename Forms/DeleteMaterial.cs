using DarAlArqamForm.Data;
using DarAlArqamForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DarAlArqamForm.Forms
{
    public partial class DeleteMaterial : Form
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public DeleteMaterial()
        {
            InitializeComponent();
            //DataGridView();
            //DeleteMaterial_Load();
        }
        private void DeleteMaterial_Load(object sender, EventArgs e)
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

            dataGridView1.DataSource = materialsList;
        }

      



        private void button1_Click(object sender, EventArgs e)


        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    // Get the object from the DataGridView
                    var removedMaterial = (Material)row.DataBoundItem;

                    if (!context.Entry(removedMaterial).State.Equals(EntityState.Deleted))
                    {
                        context.Materials.Attach(removedMaterial);
                    }

                    context.Materials.Remove(removedMaterial);
                    //dataGridView1.Rows.Remove(row);
                }

                // Save changes to the database context
                context.SaveChanges();
                MessageBox.Show("Material Deleted sucessfully");

                this.Close();
            }


        }
        }

       

    }


  

   


