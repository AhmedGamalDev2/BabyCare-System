using DarAlArqamForm.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarAlArqamForm.Forms
{
    public partial class Updateuser : Form
    {
        ApplicationDbContext context= new ApplicationDbContext();
        public Updateuser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int count=0;

            string check = context.Users.FirstOrDefault().Role;
            if (txt_Email.Text==check)
            {
                count++;
                label_erroremail.Visible = false;


            }
            else
            {
                label_erroremail.Visible = true;
            }

            if (txt_firstPassword.Text.Length >= 5 && txt_firstPassword.Text.Length <= 12)
            {
                count++;
                label_errorpass1.Visible = false;


            }
            else
            {
                label_errorpass1.Visible = true;
            }

            if (txt_secPassword.Text.Length == txt_firstPassword.Text.Length)
            {
                count++;
                label_errorpass2.Visible = false;


            }
            else
            {
                
                label_errorpass2.Visible = true;
            }


            if (count==3)
            {
              var user=  context.Users.FirstOrDefault();
                user.Password = txt_firstPassword.Text;
                context.SaveChanges();
                this.Close();
            }








        }

        private void Updateuser_Load(object sender, EventArgs e)
        {

        }
    }
}
