using DarAlArqamForm.Data;
using DarAlArqamForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarAlArqamForm.Forms
{
    public partial class UpdateStudentMaterial : Form
    {
        List<Student> lstStudents = new List<Student>();
        List<Material> lstMatarils = new List<Material>();
        ApplicationDbContext _context = new ApplicationDbContext();
        StudentMaterial _studentMaterial;
        public UpdateStudentMaterial(StudentMaterial studentMaterial)
        {
            _studentMaterial = studentMaterial;
            InitializeComponent();
        }

        private void UpdateStudentMaterial_Load(object sender, EventArgs e)
        {
            
            inputStudent.Text = _studentMaterial.Student.Name;
            inputMaterial.Text = _studentMaterial.Material.Name;
            inputGrade.Value = (decimal)_studentMaterial.ExamGrade;
            inputDate.Text = _studentMaterial.ExamDate.ToShortDateString();
            inputDescription.Text = _studentMaterial.Description;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            var grade = inputGrade.Value;
             
            var description = inputDescription.Text;

             if(grade<=  _studentMaterial.Material.MaxDegree )
            {
                _studentMaterial.ExamGrade = (double)grade;
                _studentMaterial.Description = description;
                try
                {
                    _context.StudentMaterials.AddOrUpdate(_studentMaterial);
                    _context.SaveChanges();
                    var autoHideMessageBox = new AutoHideMessageBoxForm("تم التعديل ", 2000); // Display for 2 seconds
                    autoHideMessageBox.Show();

                }
                catch
                {
                    MessageBox.Show("هناك خطأ ما");
                }
            }
            else
            {
                MessageBox.Show("الدرجة أعلى من الدرجة النهائية للمادة");
            }
            
             

        }
    }
}
