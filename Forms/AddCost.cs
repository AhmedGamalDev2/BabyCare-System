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

namespace DarAlArqamForm.Forms
{
    public partial class AddCost : Form
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public AddCost()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             //get data from form
            var value = inputValue.Value;
            var desc = inputDescription.Text;
            var date = inputDate.Value;
            var descCheck = context.Costs.Select(x => x.Description).FirstOrDefault(d=>d==desc);

            if (value > 0)
            {
               if(descCheck ==null)
                {
                    var newCost = new Models.Cost()
                    {
                        Value = value,
                        Description = desc,
                        Date = date
                    };
                    try
                    {
                        context.Costs.Add(newCost);//add row to costs

                        var costValue = context.Payments.FirstOrDefault(); //get cost from database
                        costValue.Cost += value;//or cost.value // minus value that deleted from cost database

                        context.SaveChanges();
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("هناك خطأ في تخزين البيانات");
                    }
                }
                else
                {
                    MessageBox.Show("هذا البيان موجود من قبل");
                    

                }
            }
            else
            {
                MessageBox.Show("ادخل المبلغ صحيحا");
            }
           

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCost_Load(object sender, EventArgs e)
        {

        }
    }
}
