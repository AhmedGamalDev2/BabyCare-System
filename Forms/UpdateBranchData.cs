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
    public partial class UpdateBranchData : Form
    {

        private ApplicationDbContext dbContext = new ApplicationDbContext(); // Replace with your DbContext

        Branch branch;

        public UpdateBranchData(Branch _branch)
        {
            InitializeComponent();

            this.branch = _branch;

        }


   

        private void UpdateBranchData_Load(object sender, EventArgs e)
        {
            textBox1.Text = branch.Name;
        }

     

       

       

        private void button1_Click(object sender, EventArgs e)
        {
            branch.Name = textBox1.Text;


            //updata student data in database
            string arabicPattern = @"^[\p{IsArabic}\s]{3,}$";
            // Create a Regex object with the compiled pattern
            Regex regex = new Regex(arabicPattern, RegexOptions.Compiled);


            if (regex.IsMatch(textBox1.Text)
                && dbContext.Branches.FirstOrDefault( b=>b.Name ==textBox1.Text) == null )
            {
                DialogResult confirm = MessageBox.Show("هل تريد تعدبل بيانات هذا الفرع؟", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    foreach (var item in dbContext.Branches)
                    {
                        if (item.BranchId == branch.BranchId)
                        {
                            item.Name = branch.Name;

                            // item.Gender = student.Gender;
                        }
                    }


                    dbContext.SaveChanges();
                    this.Close();
                }
            }

            else
            {
                if (dbContext.Branches.FirstOrDefault(b => b.Name == textBox1.Text) != null)
                {
                    label1.Visible = true;
                    label1.Text = "الاسم موجود بالفعل ";
                }

                else
                {
                    label1.Visible = true;
                    label1.Text = "ادخل اسم صحيح";

                }
                MessageBox.Show("اكمل البيانات");

            }


        }





    }
}