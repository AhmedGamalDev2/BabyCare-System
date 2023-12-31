using DarAlArqamForm.Forms;
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

namespace DarAlArqamForm
{
    public partial class DarAlArqam : Form
    {
        public DarAlArqam()
        {
            InitializeComponent();
        }

        private void DarAlArqam_Load(object sender, EventArgs e)
        {

        }



        private void Title_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void المصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            AddEmpolyeeForm addemp= new AddEmpolyeeForm();
            addemp.ShowDialog();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            AddStudent addstudent = new AddStudent();
            addstudent.ShowDialog();
        }

        private void remove(object sender, EventArgs e)
        {

        }

        private void StudentDetails_Click(object sender, EventArgs e)
        {
            studentdata stddetails = new studentdata();
            stddetails.ShowDialog();
        }

        private void اضافهToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddClassRoom addclass = new AddClassRoom();
           addclass.ShowDialog();
        }

        private void حذفموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteEmpolyee delemp = new DeleteEmpolyee();
            delemp.ShowDialog();
        }

        private void بياناتالمواظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpolyeeData empolyeeData = new EmpolyeeData();
            empolyeeData.ShowDialog();
        }

        private void DarAlArqam_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {

        }

        private void الموادToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اضافهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacher teacher= new AddTeacher();
            teacher.ShowDialog();
        }

        private void بياناتالمرسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetTeacher getTeacher = new GetTeacher();
            getTeacher.ShowDialog();
        }

        private void حذففصلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classroomdata classroomdata = new Classroomdata();
            classroomdata.ShowDialog();
        }

        private void اToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBranch branch = new AddBranch();
            branch.ShowDialog();
        }

        private void حذففرعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Branchdata branchdata = new Branchdata();
            branchdata.ShowDialog();
        }

        private void اضافهقريهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCountry addCountry = new AddCountry();
            addCountry.ShowDialog();
        }

        private void حذفقريهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Countrydata countrydata = new Countrydata();
            countrydata.ShowDialog();
        }

        private void عرضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialData materialData = new MaterialData(); 
            materialData.ShowDialog();
        }

        private void دفعفواتيرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Cost Cost1 = new Forms.Cost();
            Cost1.ShowDialog();
        }

        private void الخزنهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            payments.ShowDialog();
        }

        private void دفعرواتبالمدرسينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teachersalary teachersalary = new Teachersalary();
            teachersalary.ShowDialog();
        }

        private void دفعرواتبالعمالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSalarys employeeSalarys = new EmployeeSalarys();
            employeeSalarys.ShowDialog();
        }

        private void توريددعمخارجيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonationUpdate donation = new DonationUpdate();
            donation.ShowDialog();
        }

        private void شروطالقبولللعامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void اضافةطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
        }

        private void حذفوتعديلالطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentdata studentdata = new studentdata();
            studentdata.ShowDialog();
        }

        private void القواعدالقبولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneralSettings generalSetting = new GeneralSettings();
            generalSetting.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StudentMaterialsForm studentMaterial = new StudentMaterialsForm();
            studentMaterial.ShowDialog();
        }

        private void عرضالمستوياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateLevel updateLevel = new UpdateLevel() ;
            updateLevel.ShowDialog();
        
        }

        private void جماليالمصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports() ;
            reports.ShowDialog();
        }

        private void اجماليالايراداتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonationReport donationReport = new DonationReport() ;
            donationReport.ShowDialog();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            StudentGradeReports studentGradeReports = new StudentGradeReports();
            studentGradeReports.Show();
        }
    }
}
