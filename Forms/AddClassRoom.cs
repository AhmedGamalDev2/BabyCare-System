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
    public partial class AddClassRoom : Form
    {



        private ApplicationDbContext dbContext = new ApplicationDbContext(); // Replace with your DbContext



        public AddClassRoom()
        {
            InitializeComponent();

            LoadBranchesDataToComboBox();
          //  LoadTechersDataToComboBox();

        }

        //combo box to display branches
        private void LoadBranchesDataToComboBox()
        {
            // Display the product names      
            comboBox1.DataSource = dbContext.Branches.Select(b => b.Name).ToList();

        }

        //combo box to display teachers
        //private void LoadTechersDataToComboBox()
        //{
           
        //    // Display the product names      
        //    comboBox2.DataSource = dbContext.Teachers
        //        .Where(t => t.BranchId == BranchId).Select((t) => t.Name).ToList();       // Filter teachers by branch ID



        //}




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var branchName = comboBox1.SelectedItem as string;

           var BranchId = dbContext.Branches.FirstOrDefault(b => b.Name == branchName).BranchId;
            // Display the product names      
            comboBox2.DataSource = dbContext.Teachers
                .Where(t => t.BranchId == BranchId).Select((t) => t.Name).ToList();       // Filter teachers by branch ID


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string className = textBox1.Text;        //from text box
            string arabicPattern = @"^[\p{IsArabic}\s]{3,}$";
            Regex regex = new Regex(arabicPattern, RegexOptions.Compiled);

            if (string.IsNullOrEmpty(className) || !regex.IsMatch(className))
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;

                bool classExists = dbContext.ClassRooms
                    .Any(b => b.Name == textBox1.Text);

                if (classExists)
                {
                    MessageBox.Show("الاسم موجود بالفعل");

                }

                else
                {

                    var branchName = comboBox1.SelectedItem as string;
                    var BranchId = dbContext.Branches.FirstOrDefault(b => b.Name == branchName).BranchId;

                    var teacherName = comboBox2.SelectedItem as string; // Retrieve the selected teacher name from comboBox2
                    var TeacherId = dbContext.Teachers.FirstOrDefault(t => t.Name == teacherName).TeacherId; // Use the retrieved teacher name to find the corresponding ID

                    var name = textBox1.Text;

                    dbContext.ClassRooms.Add(new ClassRoom { Name = name, BranchId = BranchId, TeacherId = TeacherId });
                    MessageBox.Show("تم الاضافه بنجاح");
                    textBox1.Text = "";
                    dbContext.SaveChanges();

                }
            }
        }




        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void AddClassRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
