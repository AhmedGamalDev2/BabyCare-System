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

namespace DarAlArqamForm.Forms
{
    public partial class DonationReport : Form
    {
        ApplicationDbContext _context = new ApplicationDbContext();
        public DonationReport()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           var inputDate = dateTimePickerReport.Value;
           var valueDb = _context.Donations.Select(s=>s).Where(c => c.Date.Year == inputDate.Year && c.Date.Month == inputDate.Month).ToList();
         

            if (valueDb != null)
            {
                dataGridViewReport.Rows.Clear();
                foreach (var item in valueDb)
                {
                    dataGridViewReport.Rows.Add(item.Value, item.Description, item.Date);
                }
                //var ValueBool = decimal.TryParse(valueDb.Select(c => c.Value).Sum() , out decimal outvalue);
                //textBoxAllMoney.Text = ;
                textBoxAllMoney.Text = valueDb.Select(c => c.Value).Sum().ToString();
            }
            else
            {
                MessageBox.Show("error ");
            }
        }
    }
}
