namespace DarAlArqamForm.Forms
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label_erroremail = new System.Windows.Forms.Label();
            this.label_errorpassword = new System.Windows.Forms.Label();
            this.label_errorname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(21, 134);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "كلمة المرور";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(21, 78);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(80, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "اسم المستخدم";
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(152, 78);
            this.txt_User.Margin = new System.Windows.Forms.Padding(2);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(146, 20);
            this.txt_User.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(152, 134);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(146, 20);
            this.txt_Password.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "البريد الالكتروني";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(152, 198);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(146, 20);
            this.txt_Email.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(165, 261);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 36);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "تسجيل";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label_erroremail
            // 
            this.label_erroremail.AutoSize = true;
            this.label_erroremail.ForeColor = System.Drawing.Color.Red;
            this.label_erroremail.Location = new System.Drawing.Point(322, 205);
            this.label_erroremail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_erroremail.Name = "label_erroremail";
            this.label_erroremail.Size = new System.Drawing.Size(72, 13);
            this.label_erroremail.TabIndex = 10;
            this.label_erroremail.Text = "خطأ في البريد";
            this.label_erroremail.Visible = false;
            // 
            // label_errorpassword
            // 
            this.label_errorpassword.AutoSize = true;
            this.label_errorpassword.ForeColor = System.Drawing.Color.Red;
            this.label_errorpassword.Location = new System.Drawing.Point(322, 134);
            this.label_errorpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_errorpassword.Name = "label_errorpassword";
            this.label_errorpassword.Size = new System.Drawing.Size(98, 13);
            this.label_errorpassword.TabIndex = 13;
            this.label_errorpassword.Text = "خطأ في كلمة المرور";
            this.label_errorpassword.Visible = false;
            // 
            // label_errorname
            // 
            this.label_errorname.AutoSize = true;
            this.label_errorname.ForeColor = System.Drawing.Color.Red;
            this.label_errorname.Location = new System.Drawing.Point(322, 78);
            this.label_errorname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_errorname.Name = "label_errorname";
            this.label_errorname.Size = new System.Drawing.Size(109, 13);
            this.label_errorname.TabIndex = 12;
            this.label_errorname.Text = "خطأ في اسم المستخدم";
            this.label_errorname.Visible = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 380);
            this.Controls.Add(this.label_errorpassword);
            this.Controls.Add(this.label_errorname);
            this.Controls.Add(this.label_erroremail);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Name = "Register";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "انشاء مستخدم جديد";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label_erroremail;
        private System.Windows.Forms.Label label_errorpassword;
        private System.Windows.Forms.Label label_errorname;
    }
}