using DarAlArqamForm.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using System.IO;
using DarAlArqamForm.Data;
using iTextSharp.text.pdf;


namespace DarAlArqamForm.Forms
{
    public partial class Reports : Form
    {
        ApplicationDbContext _context = new ApplicationDbContext();
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            //var value = _context.Costs.Select(s=>s);

            ////dictionary (month) value+
            //Dictionary<int, decimal> d = new Dictionary<int, decimal>();
            

            //foreach(var item in value)
            //{
            //   if(d.ContainsKey(item.Date.Month))
            //    {
            //        d[item.Date.Month] += item.Value;
            //    }
            //    else
            //    {
            //        //d.Add()
            //    }
            //}
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var inputDate = dateTimePickerReport.Value;
            var valueDb = _context.Costs.Select(s => s).Where(c=>c.Date.Year==inputDate.Year && c.Date.Month == inputDate.Month).ToList();

           
            if (valueDb != null)
            {
                dataGridViewReport.Rows.Clear();
                foreach (var item in valueDb)
                {
                    dataGridViewReport.Rows.Add(item.Value, item.Description, item.Date);
                }
                textBoxAllMoney.Text = valueDb.Select(c => c.Value).Sum().ToString();
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files (.pdf)|.pdf";
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
                Paragraph paragrap = new Paragraph("كشف  بالمصاريف عن شهر ::" + dateTimePickerReport.Value.Year + "/" + dateTimePickerReport.Value.Month, arabicFont);
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
                PdfPTable table = new PdfPTable(dataGridViewReport.Columns.Count);
                table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                table.WidthPercentage = 80;
                float[] wid = { 25f, 50f, 20f }; // also change


                table.SetWidths(wid);


                // Add column headers to the table
                for (int i = 0; i < dataGridViewReport.Columns.Count; i++)
                {
                    //      fill table with data 
                    Paragraph paragraph = new Paragraph(dataGridViewReport.Columns[i].HeaderText, arabicFont);
                    paragraph.Alignment = Element.ALIGN_CENTER;


                    PdfPCell cel = new PdfPCell();
                    cel.AddElement(paragraph);
                    cel.MinimumHeight = 20f;


                    table.AddCell(cel);

                }

                // Add rows to the table
                for (int i = 0; i < dataGridViewReport.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewReport.Columns.Count; j++)
                    {
                        if (dataGridViewReport[j, i].Value != null)
                        {
                            // fill table with data
                            Paragraph paragraph = new Paragraph(dataGridViewReport[j, i].Value.ToString(), arabicFont);
                            paragraph.Alignment = Element.ALIGN_LEFT;
                            PdfPCell cel = new PdfPCell();
                            cel.AddElement(paragraph);
                            cel.MinimumHeight = 20f;

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

                MessageBox.Show(" تم حفظ الملف بنجاح");

            }
        }
    }
}
