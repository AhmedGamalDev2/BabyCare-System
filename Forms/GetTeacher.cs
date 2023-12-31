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
    public partial class GetTeacher : Form
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public GetTeacher()
        {
            InitializeComponent();
        }

        
        

        private void GetTeacher_Load(object sender, EventArgs e)
        {

            var teachers = context.Teachers.Include("Branch").Select(t => t);
            if(teachers != null)
            {
                foreach(var item in  teachers)
                {
                    dataGridViewTeachers.Rows.Add(item.Name,item.Salary,item.Phone,item.Branch.Name);
                }
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //dataGridViewTeachers.SelectedRows[0].Cells[0].Value ;
            if (dataGridViewTeachers.SelectedRows.Count == 1)
            {
            
                var teacher = dataGridViewTeachers.SelectedRows[0].Cells[0].Value as string;
                var teacher2 = context.Teachers.Where(c => c.Name == teacher).FirstOrDefault();
                 
                // عرض رسالة تأكيد قبل الحذف
                DialogResult result = MessageBox.Show("هل أنت متأكد من حذف هذا العنصر؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // هنا يجب تنفيذ الكود الذي يقوم بالحذف
                    // إذا تم التأكيد على الحذف
                    context.Teachers.Remove(teacher2);

                }


                try
                {
                    context.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("هناك خطأ ما ");
                }

            }
            else
            {
                MessageBox.Show("اخيار خاطئ ");
            }
        }

            private void btnUpdate_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(teacher as string);
            if (dataGridViewTeachers.SelectedRows.Count == 1)
            {

                //TODO:: Unique name 
                var teacher = dataGridViewTeachers.SelectedRows[0].Cells[0].Value as string;

                var teacher2 =  context.Teachers.Where(c => c.Name == teacher).FirstOrDefault();
                UpdateTeacher f = new UpdateTeacher(teacher2);
                f.ShowDialog();


            }
            else
            {
                MessageBox.Show("اخيار خاطئ ");
            }


        }

        private void dataGridViewTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewTeachers.Rows.Clear();

            var teachers = context.Teachers.Include("Branch").Select(t => t);
            if (teachers != null)
            {
                foreach (var item in teachers)
                {
                    //context.Branches.Find(item.BranchId);
                    dataGridViewTeachers.Rows.Add(item.Name, item.Salary, item.Phone, context.Branches.Find(item.BranchId).Name);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTeacher AddForm = new AddTeacher();
            AddForm.ShowDialog();

        }
    }
}
