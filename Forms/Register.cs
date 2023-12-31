using DarAlArqamForm.Data;
using DarAlArqamForm.Models;
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
    public partial class Register : Form
    {
        ApplicationDbContext context= new ApplicationDbContext();
        public Register()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            int count = 0;


            // Define a regular expression pattern for Arabic text
            string arabicPattern = @"^[a-zA-Z0-9_-]{3,20}$$";

            // Create a Regex object with the compiled pattern
            Regex regex = new Regex(arabicPattern, RegexOptions.Compiled);
            string s = "";
            if (txt_User.Text.Length >= 2)
            {
                s = txt_User.Text.Substring(0, 2);
            }
            if (regex.IsMatch(txt_User.Text) && txt_User.Text.Trim().Length >= 2 && s.Trim().Length == 2)
            {
                count++;
                label_errorname.Visible = false;


            }
            else
            {
                label_errorname.Visible = true;
            }

            if (txt_Password.Text.Length>=5&& txt_Password.Text.Length <=12)
            {
                count++;
                label_errorpassword.Visible = false;


            }
            else
            {
                label_errorpassword.Visible = true;
            }


            Regex rege = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");


            if (rege.IsMatch(txt_Email.Text))
            {
                count++;
                label_erroremail.Visible = false;


            }
            else
            {
                label_erroremail.Visible = true;
            }


            if (count==3)
            {
                User user = new User() { 
                
                UserName = txt_User.Text,
                Password = txt_Password.Text,
                Role= txt_Email.Text
                };
                context.Users.Add(user); 
                context.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("من فضلك ادخل البيانات كامله");
            }




        }
    }
}
