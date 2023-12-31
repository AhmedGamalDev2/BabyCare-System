using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.sun.tools.@internal.xjc.reader.gbind;
using DarAlArqamForm.Data;
using DarAlArqamForm.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DarAlArqamForm
{
    public partial class reciept : Form
    {
        ApplicationDbContext context = new ApplicationDbContext();
        Student student;
        public reciept(Student student)
        {
            InitializeComponent();
            this.student = student;

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


       
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lab_name_Click(object sender, EventArgs e)
        {

        }

        private void reciept_Load(object sender, EventArgs e)
        {
            
            txt_name.Text = student.Name;
            txt_country.Text = context.Countries.FirstOrDefault(t => t.CountryId == student.CountryId).Name;
            txt_month.Text = DateTime.Now.Month.ToString();
            txt_day.Text = DateTime.Now.Day.ToString();
            txt_year.Text = DateTime.Now.Year.ToString();
            txt_p2.Text ="0";
            if (DateTime.Now.Month >= 9)
            {

                txt_year1.Text = DateTime.Now.Year.ToString();
                txt_year2.Text = (DateTime.Now.Year + 1).ToString();


            }
            else
            {
                txt_year1.Text = (DateTime.Now.Year - 1).ToString();
                txt_year2.Text = DateTime.Now.Year.ToString();
            }

            //return back
            GeneralSetting amount = context.GeneralSettings.FirstOrDefault();
         
            txt_remainpound.Text =((int)(amount.PaymentValue - student.studentpay)).ToString();

        }

        private void txt_remainpound_Leave(object sender, EventArgs e)
        {

        }

        private void txt_pound_Leave(object sender, EventArgs e)
        {
            GeneralSetting amount = context.GeneralSettings.FirstOrDefault();
            int pay=0;
            if(int.TryParse(txt_pound.Text,out pay))
            {
                
                if (int.Parse(txt_p1.Text)>0) { pay++;}
                txt_p2.Text = "0";
                txt_remainpound.Text = ((int)amount.PaymentValue- (int)(pay + student.studentpay)).ToString();
            }
            else
            {
                txt_pound.Text = "0";
                if (int.Parse(txt_p1.Text) > 0) { pay++; }
                txt_p2.Text = "0";
                txt_remainpound.Text = ((int)amount.PaymentValue- (int)(pay + student.studentpay)).ToString();
            }


        }

        Bitmap MemoryImage;
        private void btn_print_Click(object sender, EventArgs e)
        {
              


            #region validation and save

            decimal money = 0;
            bool can = decimal.TryParse(txt_pound.Text, out money);
            decimal remainmoney = decimal.Parse(txt_remainpound.Text);
            if (money > 0 && can)
            {
                if (remainmoney >= 0)
                {
                    StudentPayment studentpayment = new StudentPayment();
                    student.studentpay += money;
                    context.Students.FirstOrDefault(w => w.StudentId == student.StudentId).studentpay += money;
                    studentpayment.StudentId = student.StudentId;
                    studentpayment.paymentYear = DateTime.Now;
                    studentpayment.AddPaidValue = money;
                    var fee = context.Payments.FirstOrDefault();
                    fee.Fees += money;
                    context.SaveChanges();
                    ////////
                    #region Print

                    txt_pound.BorderStyle = BorderStyle.None;
                    txt_p1.BorderStyle = BorderStyle.None;
                    txt_pound.BackColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                    txt_p1.BackColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                    print_panal();
                    txt_pound.BorderStyle = BorderStyle.FixedSingle;
                    txt_p1.BorderStyle = BorderStyle.FixedSingle;
                    txt_pound.BackColor = Color.White;
                    txt_p1.BackColor = Color.White;

                    #endregion


                    this.Close();

                }
                else
                {
                    MessageBox.Show("المبلغ المدفوع اكبر من القيمه المطلوبه");
                }

            }
            else
            {

                MessageBox.Show("ادخل قيمه المبلغ صحيحا");
            }

            #endregion



            


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            decimal money=0;
            bool can = decimal.TryParse(txt_pound.Text,out money);
            decimal remainmoney = decimal.Parse(txt_remainpound.Text);
            if (money > 0 &&can)
            {
                if (remainmoney >= 0)
                {
                    StudentPayment studentpayment = new StudentPayment();
                    student.studentpay += money;
                    context.Students.FirstOrDefault(w => w.StudentId == student.StudentId).studentpay += money;
                    studentpayment.StudentId = student.StudentId;
                    studentpayment.paymentYear =DateTime.Now;
                    studentpayment.AddPaidValue =money;
                    var fee = context.Payments.FirstOrDefault();
                    fee.Fees += money;
                    context.SaveChanges();
                    this.Close();
                   
                }
                else
                {
                    MessageBox.Show("المبلغ المدفوع اكبر من القيمه المطلوبه");
                }

            }
            else
            {

                MessageBox.Show("ادخل قيمه المبلغ صحيحا");
            }




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        public void print_panal()
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        panel1.AutoSize = true;
                        panel1.Refresh();

                        int width = panel1.Width;
                        int height = panel1.Height;

                        MemoryImage = new Bitmap(width, height);
                        System.Drawing.Rectangle rect = new System.Drawing.Rectangle(0, 0, width, height);
                        panel1.DrawToBitmap(MemoryImage, new System.Drawing.Rectangle(0, 0, width, height));
                        iTextSharp.text.Image image1 = iTextSharp.text.Image.GetInstance((System.Drawing.Image)MemoryImage, System.Drawing.Imaging.ImageFormat.Png);
                        image1.Alignment = iTextSharp.text.Image.ALIGN_CENTER;

                        image1.WidthPercentage = PageSize.A4.Width;
                        image1.ScaleAbsoluteHeight(PageSize.A4.Height-600);
                        MemoryImage.Save("ttt.png");

                        //Save pdf file
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(image1);
                        doc.Add(new Paragraph("\n"));
                        doc.Add(image1);
                        panel1.AutoSize = false;
                        panel1.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }


        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txt_pound_TextChanged(object sender, EventArgs e)
        {

        }

        public void addpaid(decimal d) {

        
            txt_pound.BorderStyle = BorderStyle.None;
            txt_p1.BorderStyle = BorderStyle.None;
            txt_pound.ReadOnly = true;
            txt_p1.ReadOnly = true;
           
            txt_pound.BackColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            txt_p1.BackColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
           
            GeneralSetting amount = context.GeneralSettings.FirstOrDefault();
            txt_pound.Text = ((int)d).ToString();
            txt_remainpound.Text = ((int)amount.PaymentValue - (int)d).ToString();

            


           txt_pound.Leave -= txt_pound_Leave;


        }


    }
}
