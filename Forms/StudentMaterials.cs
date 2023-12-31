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
    public partial class StudentMaterialsForm : Form
    {
        ApplicationDbContext _context = new ApplicationDbContext();
        List<Student> lstStudents = new List<Student>();
        List<Material> lstMatarils = new List<Material>();

        public StudentMaterialsForm()
        {
            InitializeComponent();
        }
         
        private void StudentMaterialsForm_Load(object sender, EventArgs e)
        {
            //var students = _context.Students.Select(s => s);
            //var materials = _context.Materials.Select(m => m);
            //foreach (var item in students)
            //{
            //    lstStudents.Add(item);
            //}
            //foreach (var item in materials)
            //{
            //    lstMatarils.Add(item);
            //}


            var studentMaterials = _context.StudentMaterials.Include("Student").Include("Material").Select(t => t);
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {
                    dataGridViewStudentMaterial.Rows.Add(item.Student.Name, item.Material.Name, item.ExamGrade, item.ExamDate.ToShortDateString(), item.Description);
                }


            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           var students=  _context.Students.Select(s => s);
           var materials= _context.Materials.Select(m => m);

            AddStudentMaterial studentMaterialsForm = new AddStudentMaterial();
           
           studentMaterialsForm.ShowDialog();
             
         


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewStudentMaterial.Rows.Clear();
            var studentMaterials = _context.StudentMaterials.Include("Student").Include("Material").Select(t => t);
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                {
                    dataGridViewStudentMaterial.Rows.Add(item.Student.Name, item.Material.Name, item.ExamGrade, item.ExamDate.ToShortDateString(), item.Description);
                }


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudentMaterial.SelectedRows.Count == 1)
            {
                var studentName = dataGridViewStudentMaterial.SelectedRows[0].Cells[0].Value.ToString();
                var materialName = dataGridViewStudentMaterial.SelectedRows[0].Cells[1].Value.ToString();
                var date =DateTime.Parse( dataGridViewStudentMaterial.SelectedRows[0].Cells[3].Value.ToString());

                var studentMaterialDb =  _context.StudentMaterials.Include("Student").Include("Material").FirstOrDefault(sm => sm.Student.Name == studentName && sm.Material.Name == materialName && sm.ExamDate.Year == date.Year && sm.ExamDate.Month == date.Month);
                if(studentMaterialDb != null)
                {
                    DialogResult result = MessageBox.Show("هل متأكد من الحذف؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            _context.StudentMaterials.Remove(studentMaterialDb);
                            _context.SaveChanges();
                            dataGridViewStudentMaterial.Rows.RemoveAt(dataGridViewStudentMaterial.SelectedRows[0].Index);
                            //MessageBox.Show("تم الحذف");
                            var autoHideMessageBox = new AutoHideMessageBoxForm("تم الحذف ", 2000); // Display for 2 seconds
                            autoHideMessageBox.Show();


                        }
                        catch
                        {
                            MessageBox.Show("هناك خطأ ما");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("غير موجود");
                }
            }
            else
            {
                MessageBox.Show("اختيار خاطئ");
            }

                //var studentMaterial = _context.StudentMaterials.Remove();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudentMaterial.SelectedRows.Count == 1)
            {
                //get from gridview
                var studentName = dataGridViewStudentMaterial.SelectedRows[0].Cells[0].Value.ToString();
                var materialName = dataGridViewStudentMaterial.SelectedRows[0].Cells[1].Value.ToString();
                var date = DateTime.Parse(dataGridViewStudentMaterial.SelectedRows[0].Cells[3].Value.ToString());

                var studentMaterialDb = _context.StudentMaterials.Include("Student").Include("Material").FirstOrDefault(sm => sm.Student.Name == studentName && sm.Material.Name == materialName && sm.ExamDate.Year == date.Year && sm.ExamDate.Month == date.Month);

                UpdateStudentMaterial updateStudentMaterial = new UpdateStudentMaterial(studentMaterialDb);
                updateStudentMaterial.ShowDialog();
            }


            }
        }
}
