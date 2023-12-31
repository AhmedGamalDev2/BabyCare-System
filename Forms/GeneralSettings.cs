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
    public partial class GeneralSettings : Form
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public GeneralSettings()
        {
            InitializeComponent();
        }

        private void GeneralSettings_Load(object sender, EventArgs e)
        {
            if (context.GeneralSettings.FirstOrDefault() != null)

            {
                this.button1.Enabled = false;
                this.button1.Visible = false;

            }
            var generalsettengs = context.GeneralSettings.Select(g => g);
            if (generalsettengs != null)
            {
                foreach (var item in generalsettengs)
                {
                    dataGridView1.Rows.Add(item.GeneralSettingId, item.AcceptanceDate, item.StudyEnd, item.YearAge, item.MonthAge, item.PaymentValue);
                }
            }

            //var GeneralData = context.GeneralSettings.ToList();
            //var GeneralList = GeneralData.Select(G => new GeneralSetting
            //{
            //    GeneralSettingId = G.GeneralSettingId,
            //    AcceptanceDate = G.AcceptanceDate,
            //    StudyEnd = G.StudyEnd,
            //    YearAge = G.YearAge,
            //    MonthAge = G.MonthAge,
            //    PaymentValue = G.PaymentValue
            //}).ToList();

            //// Set the DataPropertyName for each column after setting the DataSource
            //dataGridView1.Columns[0].DataPropertyName = "GeneralSettingId";
            //dataGridView1.Columns[1].DataPropertyName = "AcceptanceDate";
            //dataGridView1.Columns[2].DataPropertyName = "StudyEnd";
            //dataGridView1.Columns[3].DataPropertyName = "YearAge";
            //dataGridView1.Columns[4].DataPropertyName = "MonthAge";
            //dataGridView1.Columns[5].DataPropertyName = "PaymentValue";

            //dataGridView1.DataSource = GeneralList;
            //dataGridView1.Columns[4].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGeneralSettings addGeneralSettings = new AddGeneralSettings();
           var dig= addGeneralSettings.ShowDialog();
            if (dig == DialogResult.Cancel)
            {

                DarAlArqam darAlArqam = new DarAlArqam();
                this.Hide();
                var dialog = darAlArqam.ShowDialog();
                if (dialog == DialogResult.Cancel)
                { this.Close(); }
            }
            this.button1.Enabled = false;
            this.button1.Visible=false;
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            { int index = dataGridView1.Rows[0].Index;
                var value = dataGridView1.SelectedRows[0].Cells[0].Value;

                if (value != null && int.TryParse(value.ToString(), out int generalone))
                {
                    var generaltwo = context.GeneralSettings.FirstOrDefault(g => g.GeneralSettingId == generalone);

                    if (generaltwo != null)
                    {
                        EditGeneralSettings editform = new EditGeneralSettings(generaltwo);

                        var Dialog = editform.ShowDialog();
                    if (Dialog == DialogResult.Cancel)
                        {
                            dataGridView1.Rows[index].Cells[1].Value = generaltwo.AcceptanceDate;
                            dataGridView1.Rows[index].Cells[2].Value = generaltwo.StudyEnd;
                            dataGridView1.Rows[index].Cells[3].Value = generaltwo.YearAge;
                            dataGridView1.Rows[index].Cells[4].Value = generaltwo.MonthAge;
                            dataGridView1.Rows[index].Cells[5].Value = generaltwo.PaymentValue;
                           

                        }
                    }
                    else
                    {
                        MessageBox.Show("البيانات غير موجودة في قاعدة البيانات");
                    }
                }
                else
                {
                    MessageBox.Show("قيمة غير صالحة في الخلية المحددة.");
                }
            }
            else
            {
                MessageBox.Show("اختيار خاطئ");
            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var generalsettengs = context.GeneralSettings.Select(g => g);
            if (generalsettengs != null)
            {
                foreach (var item in generalsettengs)
                {
                    dataGridView1.Rows.Add(item.GeneralSettingId, item.AcceptanceDate, item.StudyEnd, item.YearAge, item.MonthAge, item.PaymentValue);
                }
            }
        }
    }
    //var generalid = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
    //var studystart = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
    //var studyend = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
    //var yearage = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
    //var monthmage = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
    //var paymentvalue = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
    //int index = dataGridView1.SelectedRows[0].Index;
    //var editing = context.GeneralSettings.Where(g => g.AcceptanceDate == studystart && g.StudyEnd == studyend).FirstOrDefault();
    //EditGeneralSettings editGeneralSettings = new EditGeneralSettings(editing);
    //var dialogResult = editGeneralSettings.ShowDialog();

    //dataGridView1.Rows[index].Cells[0].Value = editing.GeneralSettingId;
    //dataGridView1.Rows[index].Cells[1].Value = editing.AcceptanceDate;
    //dataGridView1.Rows[index].Cells[2].Value = editing.StudyEnd;
    //dataGridView1.Rows[index].Cells[3].Value = editing.YearAge;
    //dataGridView1.Rows[index].Cells[3].Value = editing.MonthAge;
    //dataGridView1.Rows[index].Cells[3].Value = editing.PaymentValue;











    //EditEmpolyee editEmpolyee = new EditEmpolyee();
    //editEmpolyee.Show();    
}

       
 

      
    


