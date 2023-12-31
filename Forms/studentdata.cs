using DarAlArqamForm.Data;
using DarAlArqamForm.Forms;
using DarAlArqamForm.Models;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.html.simpleparser;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;
using java.awt;
using static javax.swing.text.StyleConstants;

namespace DarAlArqamForm
{
    public partial class studentdata : Form
    {
       //object of database
        ApplicationDbContext context = new ApplicationDbContext();
        
        public studentdata()
        {
            InitializeComponent();

        }
        
       

        private void student_data_Load(object sender, EventArgs e)
        {
            //first one in combobox
            comboBox1.SelectedIndex = 0;
            dataGridView1.RowCount = 1;
            var stu = context.Students.Select(r => r).OfType<Student>();

            foreach (var item in stu)
            {

                string countryname = context.Countries.Where(c => c.CountryId == item.CountryId).FirstOrDefault().Name;
                string branchyname = context.Branches.Where(c => c.BranchId == item.BranchId).FirstOrDefault().Name;
                string classname = context.ClassRooms.Where(c => c.ClassRoomId == item.ClassRoomId).FirstOrDefault().Name;
                string levelname = context.levels.Where(c => c.LevelId == item.LevelId).FirstOrDefault().Name;
                string teachername = context.Teachers.Where(c => c.TeacherId == item.TeacherId).FirstOrDefault().Name;

                dataGridView1.Rows.Add(item.Name, countryname, item.BirthDate.ToString("yyyy-MM-dd"), item.Phone, item.Gender, classname, branchyname, teachername, levelname, item.studentpay);
            }

        }













        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

       
        //delete student from database and datagridview
        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    
               
                //take student name and phone to search with them
                string name = dataGridView1.SelectedRows[i].Cells[0].Value.ToString();
                string phone = dataGridView1.SelectedRows[i].Cells[3].Value.ToString();
                Student upstu = context.Students.Where(a => a.Name == name && a.Phone == phone).FirstOrDefault();
                //delete student from database 
                context.Students.Remove(upstu);
                context.SaveChanges();
                //delete student from datagridview
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
              
                MessageBox.Show($" تم حذف الطالب {name} ");
                }
            }
            else
            {
                MessageBox.Show($"من فضلك اختر صف واحد علي الاقل");

            }





        }

        //Edit student data
        private void btn_update_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                //take student name and phone to search with them
                string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string phone = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                int ind = dataGridView1.SelectedRows[0].Index;
                var upstu = context.Students.Where(a=>a.Name==name&&a.Phone==phone).FirstOrDefault();
                //open form for editing and stop until close
                updatestudent stu = new updatestudent(upstu);
                var dialogResult = stu.ShowDialog();

                if (dialogResult == DialogResult.Cancel)
                {
                    //update date in datagridview in selected column
                    upstu = context.Students.Where(a => a.StudentId == upstu.StudentId).FirstOrDefault();              
                    dataGridView1.Rows[ind].Cells[0].Value = upstu.Name;
                    dataGridView1.Rows[ind].Cells[1].Value = context.Countries.Where(d => d.CountryId == upstu.CountryId).FirstOrDefault().Name;
                    dataGridView1.Rows[ind].Cells[2].Value = upstu.BirthDate;
                    dataGridView1.Rows[ind].Cells[3].Value = upstu.Phone;
                    dataGridView1.Rows[ind].Cells[4].Value = upstu.Gender;
                    dataGridView1.Rows[ind].Cells[5].Value = context.ClassRooms.Where(d => d.ClassRoomId == upstu.ClassRoomId).FirstOrDefault().Name;
                    dataGridView1.Rows[ind].Cells[6].Value = context.Branches.Where(d => d.BranchId == upstu.BranchId).FirstOrDefault().Name;
                    dataGridView1.Rows[ind].Cells[7].Value = context.Teachers.Where(d => d.TeacherId == upstu.TeacherId).FirstOrDefault().Name;
                    dataGridView1.Rows[ind].Cells[8].Value = context.levels.Where(d => d.LevelId == upstu.LevelId).FirstOrDefault().Name;



                }


            }
            else
            {
                MessageBox.Show($"من فضلك اختر صف واحد فقط");

            }
        }

        //show all student
        private void btn_show_Click(object sender, EventArgs e)
        {
            
        }
        




/// print student data
 private void btn_print_Click(object sender, EventArgs e)
        {

            #region print with printer
            //PrintDialog printDialog = new PrintDialog();
            //if (printDialog.ShowDialog() == DialogResult.OK)
            //{
            //    PrintDocument printDocument = new PrintDocument();
            //    printDocument.PrintPage += PrintDocument_PrintPage;


            //    printDocument.Print();
            //}
            #endregion


            #region pdf save

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //place for saving
                string filePath = saveFileDialog.FileName;

                // Create a new PDF document
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                //make writing fom right to left
                writer.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                //adding arabic font
                string fontPath = $@"{System.Windows.Forms.Application.StartupPath}\Resources\myfont.ttf";
                BaseFont arabicBaseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font arabicFont = new iTextSharp.text.Font(arabicBaseFont, 12);




                //header for pdf
                Paragraph paragrap = new Paragraph("كشف  باسماء الطلاب", arabicFont);
                paragrap.Alignment = Element.ALIGN_CENTER;

                paragrap.Font = new iTextSharp.text.Font(arabicBaseFont, 26, 1);

   

                PdfPTable tabl = new PdfPTable(1);
                PdfPCell textcell = new PdfPCell();

                // Set the run direction to right-to-left
                textcell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                // Add the text to the cell
                textcell.AddElement(paragrap);

                // Add the cell to the table and the table to the document
                textcell.BorderColor = new iTextSharp.text.BaseColor(255, 255, 255);
                textcell.MinimumHeight = 20f;

                tabl.AddCell(textcell);
                tabl.WidthPercentage = 100;
                tabl.HorizontalAlignment = Element.ALIGN_TOP;
                document.Add(tabl);
                document.Add(new Paragraph("\n"));

                // Create a PDF table
                PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
                table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                table.WidthPercentage = 100;
                float[] wid= { 25f,20f , 40f, 25f, 20f, 20f, 40f, 35f, 30f, 45f };


                table.SetWidths(wid);


                // Add column headers to the table
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    //      fill table with data 
                    Paragraph paragraph = new Paragraph(dataGridView1.Columns[i].HeaderText, arabicFont);
                    paragraph.Alignment = Element.ALIGN_CENTER;
                    
                    PdfPCell cel = new PdfPCell();
                    cel.AddElement(paragraph);
                    cel.MinimumHeight = 60f;
                

                    table.AddCell(cel);

                }

                // Add rows to the table
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1[j, i].Value != null)
                        {
                            // fill table with data
                            Paragraph paragraph = new Paragraph(dataGridView1[j, i].Value.ToString(), arabicFont);
                            paragraph.Alignment = Element.ALIGN_LEFT;
                            PdfPCell cel = new PdfPCell();
                            cel.AddElement(paragraph);
                            cel.MinimumHeight = 60f;

                            table.AddCell(cel);

                        }
                        else
                        {
                            table.AddCell("");
                        }
                    }
                }

                // Add the table to the document
                document.Add(table);

                // Close the document
                document.Close();

                MessageBox.Show("تم الحفظ الملف بنجاح ");
            }
            #endregion




        }

        /// 
        /// function for printing 

       //private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
       // {
       //     //object of datagridview
       //     DataGridView dataGridView = dataGridView1; 
       //     // get  height and count for rows of datagridview 
       //     int rowHeight = dataGridView.RowTemplate.Height;
       //     int rowCount = dataGridView.Rows.Count;
       //     int columnCount = dataGridView.Columns.Count;

       //     int x = e.MarginBounds.Left;
       //     int y = e.MarginBounds.Top;

       //     // Draw column headers
       //     for (int columnIndex = 0; columnIndex < columnCount; columnIndex++)
       //     {
       //         //// fill table with data
       //         DataGridViewColumn column = dataGridView.Columns[columnIndex];
       //         e.Graphics.DrawString(column.HeaderText, dataGridView.Font, Brushes.Black, x, y);
       //         x += column.Width;
       //     }

       //     y += rowHeight;

       //     // Draw rows
       //     for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
       //     {
       //         ////fill table with data
       //         DataGridViewRow row = dataGridView.Rows[rowIndex];
       //         x = e.MarginBounds.Left;

       //         for (int columnIndex = 0; columnIndex < columnCount; columnIndex++)
       //         {
       //             DataGridViewCell cell = row.Cells[columnIndex];
       //             e.Graphics.DrawString(cell.Value?.ToString(), dataGridView.Font, Brushes.Black, x, y);
       //             x += dataGridView.Columns[columnIndex].Width;
       //         }

       //         y += rowHeight;
       //     }
       // }
      
     
        //// search for student
        
        private void btn_search_Click(object sender, EventArgs e)
        {
            //clear datagrideview for new search
            dataGridView1.RowCount = 1;

            label_searcherror.Visible = false;
            //search by student name

            // Define a regular expression pattern for Arabic text
            string arabicPattern = @"^[\p{IsArabic}\s]{1,}$";

            // Create a Regex object with the compiled pattern
            Regex regex = new Regex(arabicPattern, RegexOptions.Compiled);

            if (!regex.IsMatch(txt_search.Text)&& txt_search.Text !="")
            {
                label_searcherror.Text = "من فضلك ادخل حروف عربيه فقط";
                label_searcherror.Visible = true;
            }
          else  if (comboBox1.SelectedIndex == 0 && txt_search.Text != "")
            {



                var stu = context.Students.Where(r => r.Name.StartsWith(txt_search.Text)).OfType<Student>();

                foreach (var item in stu)
                {
                    //get names for Countries,Branches,ClassRooms,levels and Teachers for students
                    string countryname = context.Countries.Where(c => c.CountryId == item.CountryId).FirstOrDefault().Name;
                    string branchyname = context.Branches.Where(c => c.BranchId == item.BranchId).FirstOrDefault().Name;
                    string classname = context.ClassRooms.Where(c => c.ClassRoomId == item.ClassRoomId).FirstOrDefault().Name;
                    string levelname = context.levels.Where(c => c.LevelId == item.LevelId).FirstOrDefault().Name;
                    string teachername = context.Teachers.Where(c => c.TeacherId == item.TeacherId).FirstOrDefault().Name;

                    dataGridView1.Rows.Add(item.Name, countryname, item.BirthDate.ToString("yyyy-MM-dd"), item.Phone, item.Gender, classname, branchyname, teachername, levelname,item.studentpay);
                }


            }
            //search by branch name
            else if (comboBox1.SelectedIndex == 1 && txt_search.Text != "")
            {
                var bid = context.Branches.Where(c => c.Name.StartsWith(txt_search.Text)).Select(c => c.BranchId);

                foreach (var item1 in bid)
                {


                    string bname = context.Branches.Where(c => c.BranchId == item1).FirstOrDefault().Name;
                    var stu = context.Students.Where(r => r.BranchId == item1).OfType<Student>();

                    foreach (var item in stu)
                    {
                        //get names for Countries,Branches,ClassRooms,levels and Teachers for students
                        string countryname = context.Countries.Where(c => c.CountryId == item.CountryId).FirstOrDefault().Name;
                        string classname = context.ClassRooms.Where(c => c.ClassRoomId == item.ClassRoomId).FirstOrDefault().Name;
                        string levelname = context.levels.Where(c => c.LevelId == item.LevelId).FirstOrDefault().Name;
                        string teachername = context.Teachers.Where(c => c.TeacherId == item.TeacherId).FirstOrDefault().Name;

                        dataGridView1.Rows.Add(item.Name, countryname, item.BirthDate.ToString("yyyy-MM-dd"), item.Phone, item.Gender, classname, bname, teachername, levelname, item.studentpay);
                    }

                }
            }
            //search by levels name
            else if (comboBox1.SelectedIndex == 2 && txt_search.Text != "")
            {
                var Lid = context.levels.Where(c => c.Name.StartsWith(txt_search.Text)).Select(v => v.LevelId);
                foreach (var item1 in Lid)
                {


                    string Lname = context.levels.Where(c => c.Name.StartsWith(txt_search.Text)).FirstOrDefault().Name;
                    var stu = context.Students.Where(r => r.LevelId == item1).OfType<Student>();

                    foreach (var item in stu)
                    {
                        //get names for Countries,Branches,ClassRooms,levels and Teachers for students
                        string countryname = context.Countries.Where(c => c.CountryId == item.CountryId).FirstOrDefault().Name;
                        string classname = context.ClassRooms.Where(c => c.ClassRoomId == item.ClassRoomId).FirstOrDefault().Name;
                        string branchyname = context.Branches.Where(c => c.BranchId == item.BranchId).FirstOrDefault().Name;
                        string teachername = context.Teachers.Where(c => c.TeacherId == item.TeacherId).FirstOrDefault().Name;

                        dataGridView1.Rows.Add(item.Name, countryname, item.BirthDate.ToString("yyyy-MM-dd"), item.Phone, item.Gender, classname, Lname, teachername, txt_search.Text, item.studentpay);
                    }
                }
            }
            //search by ClassRoom name
            else if (comboBox1.SelectedIndex == 3 && txt_search.Text != "")
            {
                var Cid = context.ClassRooms.Where(c => c.Name.StartsWith(txt_search.Text)).Select(b => b.ClassRoomId);

                foreach (var item1 in Cid)
                {

                    string Cname = context.ClassRooms.Where(c => c.ClassRoomId == item1).FirstOrDefault().Name;


                    var stu = context.Students.Where(r => r.ClassRoomId == item1).OfType<Student>();

                    foreach (var item in stu)
                    {
                        //get names for Countries,Branches,ClassRooms,levels and Teachers for students
                        string countryname = context.Countries.Where(c => c.CountryId == item.CountryId).FirstOrDefault().Name;
                        string branchyname = context.Branches.Where(c => c.BranchId == item.BranchId).FirstOrDefault().Name;
                        string levelname = context.levels.Where(c => c.LevelId == item.LevelId).FirstOrDefault().Name;
                        string teachername = context.Teachers.Where(c => c.TeacherId == item.TeacherId).FirstOrDefault().Name;

                        dataGridView1.Rows.Add(item.Name, countryname, item.BirthDate.ToString("yyyy-MM-dd"), item.Phone, item.Gender, Cname, branchyname, teachername, levelname, item.studentpay);
                    }
                }
            }
            //search by Country name
            else if (comboBox1.SelectedIndex == 4 && txt_search.Text != "")
            {
                var Cid = context.Countries.Where(c => c.Name.StartsWith(txt_search.Text)).Select(b => b.CountryId);

                foreach (var item1 in Cid)
                {
                    string Cname = context.Countries.Where(c => c.CountryId == item1).FirstOrDefault().Name;
                    var stu = context.Students.Where(r => r.CountryId == item1).OfType<Student>();

                    foreach (var item in stu)
                    {
                        //get names for Countries,Branches,ClassRooms,levels and Teachers for students
                        string Classname = context.ClassRooms.Where(c => c.ClassRoomId == item.ClassRoomId).FirstOrDefault().Name;
                        string branchyname = context.Branches.Where(c => c.BranchId == item.BranchId).FirstOrDefault().Name;
                        string levelname = context.levels.Where(c => c.LevelId == item.LevelId).FirstOrDefault().Name;
                        string teachername = context.Teachers.Where(c => c.TeacherId == item.TeacherId).FirstOrDefault().Name;

                        dataGridView1.Rows.Add(item.Name, Cname, item.BirthDate.ToString("yyyy-MM-dd"), item.Phone, item.Gender, Classname, branchyname, teachername, levelname, item.studentpay);
                    }
                }
            }
            else
            {
                dataGridView1.RowCount = 1;
                var stu = context.Students.Select(r => r).OfType<Student>();

                foreach (var item in stu)
                {

                    string countryname = context.Countries.Where(c => c.CountryId == item.CountryId).FirstOrDefault().Name;
                    string branchyname = context.Branches.Where(c => c.BranchId == item.BranchId).FirstOrDefault().Name;
                    string classname = context.ClassRooms.Where(c => c.ClassRoomId == item.ClassRoomId).FirstOrDefault().Name;
                    string levelname = context.levels.Where(c => c.LevelId == item.LevelId).FirstOrDefault().Name;
                    string teachername = context.Teachers.Where(c => c.TeacherId == item.TeacherId).FirstOrDefault().Name;

                    dataGridView1.Rows.Add(item.Name, countryname, item.BirthDate.ToString("yyyy-MM-dd"), item.Phone, item.Gender, classname, branchyname, teachername, levelname, item.studentpay);
                }
            }

        }

       private void pay_Click(object sender, EventArgs e)
       {

             if (dataGridView1.SelectedRows.Count == 1)
            {
                //take student name and phone to search with them
                string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string phone = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                int ind = dataGridView1.SelectedRows[0].Index;
                var upstu = context.Students.Where(a=>a.Name==name&&a.Phone==phone).FirstOrDefault();
                //open form for editing and stop until close
                reciept stu = new reciept(upstu);
                var dialogResult = stu.ShowDialog();

                if (dialogResult == DialogResult.Cancel)
                {
                    //update date in datagridview in selected column
                                
                    dataGridView1.Rows[ind].Cells[9].Value = upstu.studentpay;

                    

                }


            }
            else
            {
                MessageBox.Show("من فضلك اختر طالب");
            }

        }
       
    }
    
}
