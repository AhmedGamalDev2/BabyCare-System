using DarAlArqamForm.Data;
using System;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace DarAlArqamForm.Forms
{
    public partial class StudentGradeReports : Form
    {
        ApplicationDbContext _context = new ApplicationDbContext();

        public StudentGradeReports()
        {
            InitializeComponent();
        }

        private void StudentGradeReports_Load(object sender, EventArgs e)
        {


            // Clear existing columns
            dataGridViewStudentMaterial.Columns.Clear();

            // Add columns
            dataGridViewStudentMaterial.Columns.Add("Students", "أسماء الطلاب");
            dataGridViewStudentMaterial.Columns.Add("Quran", "قرآن كريم");
            dataGridViewStudentMaterial.Columns.Add("Islamic", "آداب إسلامية");
            dataGridViewStudentMaterial.Columns.Add("Nour", "نور البيان");
            dataGridViewStudentMaterial.Columns.Add("Math", "حساب");


            var studentsDb = _context.Students.Include("StudentMaterials").ToList();

            foreach (var student in studentsDb)
            {
                if (student.StudentMaterials != null && student.StudentMaterials.Any())
                {
                    // Create a new row
                    var newRow = new DataGridViewRow();

                    // Add a cell for student name
                    var studentNameCell = new DataGridViewTextBoxCell { Value = student.Name };
                    newRow.Cells.Add(studentNameCell);

                    // Add cells for material grades
                    foreach (var material in student.StudentMaterials)
                    {
                        var cell = new DataGridViewTextBoxCell { Value = material.ExamGrade };
                        newRow.Cells.Add(cell);
                    }

                    // Add the new row to the DataGridView
                    dataGridViewStudentMaterial.Rows.Add(newRow);
                }
            }
        }



        private void btnPrint_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files (.pdf)|.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Create a new PDF document
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                // Set the run direction to right-to-left
                writer.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                // Adding Arabic font
                string fontPath = $@"{Application.StartupPath}\Resources\myfont.ttf";
                BaseFont arabicBaseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font arabicFont = new iTextSharp.text.Font(arabicBaseFont, 12);

                // Header for PDF
                Paragraph headerParagraph = new Paragraph(" ", arabicFont);
                headerParagraph.Alignment = Element.ALIGN_CENTER;
                headerParagraph.Font = new iTextSharp.text.Font(arabicBaseFont, 26, 1);
                document.Add(headerParagraph);

                document.Add(new Paragraph("\n"));

                // Create a PDF table
                PdfPTable table = new PdfPTable(dataGridViewStudentMaterial.Columns.Count);

                table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                table.WidthPercentage = 100;

                float[] columnWidths = { 25f, 20f, 40f, 25f, 20f };
                table.SetWidths(columnWidths);

                // Add column headers to the table
                foreach (DataGridViewColumn column in dataGridViewStudentMaterial.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, arabicFont));
                    cell.MinimumHeight = 20f;
                    table.AddCell(cell);
                }

                // Add rows to the table
                foreach (DataGridViewRow row in dataGridViewStudentMaterial.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        PdfPCell pdfCell = new PdfPCell();
                        if (cell.Value != null)
                        {
                            pdfCell.AddElement(new Paragraph(cell.Value.ToString(), arabicFont));
                        }
                        pdfCell.MinimumHeight = 20f;
                        table.AddCell(pdfCell);
                    }
                }

                // Add the table to the document
                document.Add(table);

                // Close the document
                document.Close();

                MessageBox.Show("تم الحفظ الملف بنجاح ");
            }
        }

    }
   

}
