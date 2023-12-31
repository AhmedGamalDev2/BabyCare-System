using DarAlArqamForm;
using DarAlArqamForm.Data;
using DarAlArqamForm.Forms;
using DarAlArqamForm.Models;
using sun.net.www.content.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarAlarqamProject
{
    public partial class UserLogin : Form
    {

        public UserLogin()
        {
            
            InitializeComponent();

        }

        ApplicationDbContext context = new ApplicationDbContext();
        private void btnLogin_Click(object sender, EventArgs e)
        {

            var username = txtboxUser.Text;
            var password = txtboxPassword.Text;

          var user =  context.Users.SingleOrDefault(s => s.UserName == username && s.Password == password);
          var user1 =  context.Users.SingleOrDefault(s => s.UserName == username);
      
            var costs =  context.Payments.SingleOrDefault();
            if (costs==null)
            {
                Payment payment = new Payment() {Cost=0,Donation=0,EmployeeSalary=0, Fees=0,TeacherSalary=0 };

                context.Payments.Add(payment);
                context.SaveChanges();
            }

            if (user != null)
            {


                textUsername_error.Visible = false;
                Password_error.Visible = false;

                if (context.GeneralSettings.FirstOrDefault() == null)
                {

                    GeneralSettings generalSettings = new GeneralSettings();
                    this.Hide();
                    var dialog = generalSettings.ShowDialog();
                    if (dialog == DialogResult.Cancel)
                    { this.Close(); }

                }
                else
                {
                    DarAlArqam darAlArqam = new DarAlArqam();
                    this.Hide();
                    var dialog = darAlArqam.ShowDialog();
                    if (dialog == DialogResult.Cancel)
                    { this.Close(); }


                }




            }
            else
            {
                if (user1 != null)
                {
                    Password_error.Visible = true;
                    textUsername_error.Visible = false;
                }
                else
                {
                    textUsername_error.Visible = true;
                    Password_error.Visible = true;
                }
            }
            //context.Students.Select(s => s);

            // context.Users.Add(new User { UserName = username, Password = password });

            //context.DarNames.Add(new DarName { Name = "aaaaa" });
         



        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //var found = context.Users.FirstOrDefault();
            //context.Users.Remove(found);
            //context.SaveChanges();
            var found1 = context.Users.FirstOrDefault();
            if (found1!=null)
            {
                linklRegister.Visible = false;
                linklRegister.Enabled= false;
            }
            else
            {
                
                linklRegister.Visible = true;
                linklRegister.Enabled = true;
            }

        }

        private void linklRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
         var dialog=   register.ShowDialog();
            if (dialog==DialogResult.Cancel)
            {
                
           
            if (context.Users.FirstOrDefault()!=null) {
            linklRegister.Visible=false;
            linklRegister.Enabled=false;
            }
            }
        }

        private void linkforget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Updateuser updateuser = new Updateuser();
            updateuser.ShowDialog();

        }
    }

}
