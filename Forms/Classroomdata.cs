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
    public partial class Classroomdata : Form
    {

        private ApplicationDbContext dbContext = new ApplicationDbContext(); // Replace with your DbContext








        public Classroomdata()
        {
            InitializeComponent();
            AddToDataGridView();





        }

        private void AddToDataGridView()
        {
            dataGridView1.RightToLeft = RightToLeft.Yes;

            var classes = dbContext.ClassRooms.Include("Branch").
                Include("Teacher").Select(t => t).ToList();

            if (classes != null)
            {
                foreach (var item in classes)
                {
                    dataGridView1.Rows.
                        Add(item.Name, item.Branch.Name, item.Teacher.Name);
                }
            }

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }
        //button to delete
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                // Get the cell value as a string
                var selectedId  = dataGridView1.SelectedRows[0].Cells[1].Value;

                // Validate if the cell value is not null and is a valid integer
                if (selectedId != null)
                {
                    
                    //{
                        string classNameValue = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        string branchNameValue = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        string teacherNameValue = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

                        // Get branch Id
                        int branchId = dbContext.Branches
                            .Where(b => b.Name == branchNameValue)
                            .Select(b => b.BranchId)
                            .FirstOrDefault();

                        // Get teacher Id
                        int teacherId = dbContext.Teachers
                            .Where(t => t.Name == teacherNameValue)
                            .Select(t => t.TeacherId)
                            .FirstOrDefault();

                        var classroomToDelete = dbContext.ClassRooms
                            .FirstOrDefault(c =>
                                c.Name == classNameValue &&
                                c.BranchId == branchId &&
                                c.TeacherId == teacherId);

                        dbContext.ClassRooms.Remove(classroomToDelete);
                        dbContext.SaveChanges();

                        MessageBox.Show("تم الحذف بنجاح");
                        

                        // Remove the selected row from the DataGridView
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                
                }

                else
                {
                    MessageBox.Show("الجدول فارغ");
                }

            }
        }





        private void UpdateClassRoom_Load(object sender, EventArgs e)
        {

        }

       


        private void updateBtn_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                var item = dbContext.ClassRooms.FirstOrDefault(b => b.Name == name);



                // Create an instance of Form2 with the selected name
                UpdateClassRoomData form2 = new UpdateClassRoomData(item);
                var showform = form2.ShowDialog();
                if (showform == DialogResult.Cancel)
                {

                    dataGridView1.Rows[index].Cells[0].Value = item.Name;


                }
            }
            else
            {
                MessageBox.Show("من فضلك اختر صف واحد");
            }
        }

















        //   private void button1_Click(object sender, EventArgs e)
        //   {
        //       if (dataGridView1.SelectedRows.Count > 0)
        //       {
        //           string columnName = "Column1"; // Replace with the actual column name

        //           var selectedId = (int)(dataGridView1.SelectedRows[0].Cells[columnName].Value);

        //           {
        //               var entityToDelete = dbContext.ClassRooms.Find(selectedId);

        //               if (entityToDelete != null)
        //               {

        //                   string classNameValue = 
        //                       dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        //                   string branchNameValue =
        //                       dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        //                   string teacherNameValue = 
        //                       dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

        //                   //get branch Id
        //                   int branchId = dbContext.Branches
        //                .Where(b => b.Name == branchNameValue)
        //                .Select(b => b.BranchId)
        //                .FirstOrDefault();
        //                   //get teacher Id
        //                   int teacherId = dbContext.Teachers
        //.Where(t => t.Name == teacherNameValue)
        //.Select(t => t.TeacherId)
        //.FirstOrDefault();

        //                   var classroomToDelete = dbContext.ClassRooms
        //    .FirstOrDefault(c =>
        //        c.Name == classNameValue &&
        //        c.BranchId == branchId &&
        //        c.TeacherId == teacherId);

        //                   dbContext.ClassRooms.Remove(classroomToDelete);
        //                   dbContext.SaveChanges();


        //                   MessageBox.Show("تم الحذف بنجاح"); // Display the value in a message box or use it as needed.

        //               }

        //               // Remove the selected row from the DataGridView
        //               dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
        //           }
        //       }




        //   }

    }
}