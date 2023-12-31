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
    public partial class Cost : Form
    {
        ApplicationDbContext context = new ApplicationDbContext();
       
        public Cost()
        {
           
            InitializeComponent();
        }
        private void Cost_Load(object sender, EventArgs e)
        {
           
            var costs = context.Costs.Select(s => s);
            if (costs != null)
            {
                foreach (var item in costs)
                {
                    dataGridViewCost.Rows.Add(item.Value,item.Description,item.Date);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
             
           AddCost addCost = new AddCost();
          var dd =  addCost.ShowDialog();


        }

        private void dataGridViewCost_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewCost.Rows.Clear();
            var costs = context.Costs.Select(s => s);
            if (costs != null)
            {
                foreach (var item in costs)
                {
                    dataGridViewCost.Rows.Add(item.Value, item.Description, item.Date);
                }
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {

            // MessageBox.Show(teacher as string);
            if (dataGridViewCost.SelectedRows.Count == 1)
            {
                var s = dataGridViewCost.SelectedRows[0];
                //TODO:: Unique name 
                var costBool =decimal.TryParse( dataGridViewCost.SelectedRows[0].Cells[0].Value.ToString(),out   decimal ResultValue) ;
                
                var description = dataGridViewCost.SelectedRows[0].Cells[1].Value.ToString();
                var dateBool =DateTime.TryParse( dataGridViewCost.SelectedRows[0].Cells[2].Value.ToString(), out DateTime ResultDate)  ;

                var newCost = context.Costs.Where( c=> c.Description == description).FirstOrDefault();
                if(newCost != null)
                {
                    UpdateCost updateCost = new UpdateCost(newCost);
                    updateCost.ShowDialog();
                }
                

                
            }
            else
            {
                MessageBox.Show("اختيار خاطئ ");
            }

             
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dataGridViewCost.SelectedRows.Count == 1)
            {

                //TODO:: Unique name 
                var costBool = decimal.TryParse(dataGridViewCost.SelectedRows[0].Cells[0].Value.ToString(), out decimal ResultValue);

                var description = dataGridViewCost.SelectedRows[0].Cells[1].Value.ToString();
                var dateBool = DateTime.TryParse(dataGridViewCost.SelectedRows[0].Cells[2].Value.ToString(), out DateTime ResultDate);

                var newCost = context.Costs.Where(c => c.Description == description).FirstOrDefault();
                //UpdateCost updateCost = new UpdateCost(newCost);
                //TODO:: handel if selected row is null 
                if(newCost != null)
                {
                    

                    var costValue = context.Payments.FirstOrDefault(); //get cost from database
                    if(costValue != null)
                    {
                        
                            context.Costs.Remove(newCost);
                            costValue.Cost -= newCost.Value; // minus value that deleted from cost database
                            context.SaveChanges();
                            dataGridViewCost.Rows.RemoveAt(dataGridViewCost.SelectedRows[0].Index);
                            MessageBox.Show("تم الحذف");
                        

                    }
                    else
                    {
                        MessageBox.Show("هناك خطأ ما ");
                    }


                }
                else
                {
                    MessageBox.Show("هناك خطأ ما ");
                }



            }
            else
            {
                MessageBox.Show("اختيار خاطئ ");
            }

        }
    }
}
