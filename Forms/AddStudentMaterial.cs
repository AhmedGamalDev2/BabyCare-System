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
    public partial class AddStudentMaterial : Form
    {
        List<Student> lstStudents = new List<Student>() ;
        List<Material> lstMatarils = new List<Material>() ;
        
        ApplicationDbContext _context = new ApplicationDbContext();
        
        public AddStudentMaterial()
        {
           
            InitializeComponent();
            
        }
        private void AddStudentMaterial_Load(object sender, EventArgs e)
        {
            
            var students = _context.Students.Select(s => s);
            var materials = _context.Materials.Select(m => m);
            inputStudent.DataSource = students.Select(s=>s.Name).ToList();
            inputMaterial.DataSource = materials.Select(s => s.Name).ToList();
            foreach(var item in students)
            {
                lstStudents.Add(item);
            }
            foreach(var item in materials)
            {
                lstMatarils.Add(item);
            }
            
            //foreach (var item in students)
            // {
            //     inputStudent.Items.Add(item.Name);
            //     inputStudent.SelectedText = item.Name;
            //     inputStudent.SelectedValue = item.StudentId;
            //        }
            // foreach (var item in materials)
            // {
            //     inputMaterial.Items.Add(item.Name);
            //     inputMaterial.SelectedValue = item.MaterialId;
            //     inputMaterial.Items.Add(new KeyValuePair<int, string>(item.MaterialId, item.Name));

            // }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var student = inputStudent.Text;
            var material = inputMaterial.Text;
            var grade = inputGrade.Value;
            var date = inputDate.Value;
            var description = inputDescription.Text;

            var studentIndex  = inputStudent.SelectedIndex;
            var materialIdIndex =inputMaterial.SelectedIndex;
            var studentId = lstStudents[studentIndex].StudentId;
            var materialId = lstMatarils[materialIdIndex].MaterialId;
            var materialDb = _context.Materials.FirstOrDefault(m=>m.MaterialId==materialId);
            //check year and month only of examdate 
            var checkstudentMaterial = _context.StudentMaterials
                    .FirstOrDefault(s => s.StudentId == studentId && s.MaterialId == materialId
                     && s.ExamDate.Year == date.Year && s.ExamDate.Month ==date.Month);
           
            if (checkstudentMaterial == null)
            {
                if (grade <= materialDb.MaxDegree)
                {
                    StudentMaterial studentMaterial = new StudentMaterial()
                    {
                        StudentId = studentId,
                        MaterialId = materialId,
                         ExamGrade= (double)grade,
                         ExamDate = date,
                         Description=description

                    };
                    try
                    {
                        _context.StudentMaterials.Add(studentMaterial);
                        _context.SaveChanges();
                        //MessageBox.Show("تم الحفظ ");
                        var autoHideMessageBox = new AutoHideMessageBoxForm("تم الحفظ ", 2000); // Display for 2 seconds
                        autoHideMessageBox.Show();

                    }
                    catch
                    {
                        MessageBox.Show("هناك خطأ في قاعدة البيانات");
                    }
                }
                else
                {
                    MessageBox.Show("الدرجة أعلى من القيمة النهائية للمادة");
                }
            }
            else
            {
                MessageBox.Show("هذا الطالب مكرر");
            }






          


          



            // MessageBox.Show($"{id}");
            // MessageBox.Show($"{std[id].Name}");
            // MessageBox.Show($"{std[id].StudentId}");



            //var studentMaterial = new StudentMaterial()
            //{


            //};


            //_context.StudentMaterials.Add()


        }

        private void inputGrade_Leave(object sender, EventArgs e)
        {
            

        }

        private void inputGrade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
