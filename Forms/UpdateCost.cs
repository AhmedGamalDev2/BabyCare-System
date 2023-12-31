using DarAlArqamForm.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarAlArqamForm.Forms
{
    public partial class UpdateCost : Form
    {
        Models.Cost _cost;
        ApplicationDbContext _context ;
        public UpdateCost(Models.Cost cost)
        {
            _context = new ApplicationDbContext();
            this._cost = cost;
            InitializeComponent();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var oldvalue = _cost.Value;
            var newvalue = inputValue.Value;
            _cost.Value = inputValue.Value ;
            _cost.Description = inputDescription.Text;
            var dateBool =DateTime.TryParse( inputDate.Text,out DateTime ResultDate);
            _cost.Date = ResultDate;
            var descCheck = _context.Costs.Select(x => x.Description).FirstOrDefault(d => d == inputDescription.Text);



            if (inputValue.Value > 0)
            {
                if (descCheck == null || inputDescription.Text == descCheck)
                {
                    try
                    {
                        var costValue = _context.Payments.FirstOrDefault(); //get cost from database
                        //if(oldvalue> newvalue)
                        //{
                             
                        //    costValue.Cost -= oldvalue - newvalue;// sum value that deleted from cost database
                        //}
                        //else if(newvalue> oldvalue)
                        //{
                        //    costValue.Cost += newvalue - oldvalue;
                        //}
                         
                        costValue.Cost  =( costValue.Cost- oldvalue) + newvalue;
                          
                        _context.Costs.AddOrUpdate(_cost);
                         
                        _context.SaveChanges();
                        MessageBox.Show("تم التعديل بنجاح");
                    }
                    catch
                    {
                        MessageBox.Show("هناك هخأ في التعديل");

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

        private void UpdateCost_Load(object sender, EventArgs e)
        {
            inputValue.Value = _cost.Value;
            inputDescription.Text = _cost.Description;
            inputDate.Text= _cost.Date.ToString();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
