using DarAlArqamForm.Data;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace DarAlArqamForm
{
    public partial class AddBranch : Form
    {

        private ApplicationDbContext dbContext = new ApplicationDbContext(); // Replace with your DbContext


        public AddBranch()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string branchName = textBox1.Text;


            string arabicPattern = @"^[\p{IsArabic}\s]{3,}$";
            Regex regex = new Regex(arabicPattern, RegexOptions.Compiled);

            if (string.IsNullOrEmpty(branchName) || !regex.IsMatch(branchName))
            {
                lbl2.Visible = true;
            }
            else
            {
                lbl2.Visible = false;

                bool branchExists = dbContext.Branches
                    .Any(b => b.Name == textBox1.Text);

                if (branchExists)
                {
                    MessageBox.Show("الاسم موجود بالفعل");

                }

                else
                {
                    dbContext.Branches.Add(new Models.Branch { Name =textBox1.Text});
                    MessageBox.Show("تم الاضافه بنجاح");
                    textBox1.Text="";
                    dbContext.SaveChanges();
                }

            }






        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
