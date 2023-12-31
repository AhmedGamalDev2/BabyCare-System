namespace DarAlarqamProject
{
    partial class UserLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.txtboxUser = new System.Windows.Forms.TextBox();
            this.linklRegister = new System.Windows.Forms.LinkLabel();
            this.lblUser = new System.Windows.Forms.Label();
            this.textUsername_error = new System.Windows.Forms.Label();
            this.Password_error = new System.Windows.Forms.Label();
            this.linkforget = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(29, 103);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "كلمة المرور";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(189, 169);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(164, 44);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "دخول";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(189, 103);
            this.txtboxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(176, 22);
            this.txtboxPassword.TabIndex = 2;
            // 
            // txtboxUser
            // 
            this.txtboxUser.Location = new System.Drawing.Point(189, 34);
            this.txtboxUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxUser.Name = "txtboxUser";
            this.txtboxUser.Size = new System.Drawing.Size(176, 22);
            this.txtboxUser.TabIndex = 1;
            // 
            // linklRegister
            // 
            this.linklRegister.AutoSize = true;
            this.linklRegister.Location = new System.Drawing.Point(344, 252);
            this.linklRegister.Name = "linklRegister";
            this.linklRegister.Size = new System.Drawing.Size(69, 17);
            this.linklRegister.TabIndex = 5;
            this.linklRegister.TabStop = true;
            this.linklRegister.Text = "انشاء مستخدم";
            this.linklRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklRegister_LinkClicked);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(29, 34);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(80, 17);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "اسم المستخدم";
            // 
            // textUsername_error
            // 
            this.textUsername_error.AutoSize = true;
            this.textUsername_error.ForeColor = System.Drawing.Color.Red;
            this.textUsername_error.Location = new System.Drawing.Point(411, 34);
            this.textUsername_error.Name = "textUsername_error";
            this.textUsername_error.Size = new System.Drawing.Size(107, 17);
            this.textUsername_error.TabIndex = 6;
            this.textUsername_error.Text = "خطأ في اسم المستخدم";
            this.textUsername_error.Visible = false;
            // 
            // Password_error
            // 
            this.Password_error.AutoSize = true;
            this.Password_error.ForeColor = System.Drawing.Color.Red;
            this.Password_error.Location = new System.Drawing.Point(411, 103);
            this.Password_error.Name = "Password_error";
            this.Password_error.Size = new System.Drawing.Size(101, 17);
            this.Password_error.TabIndex = 7;
            this.Password_error.Text = "خطأ في كلمة المرور";
            this.Password_error.Visible = false;
            // 
            // linkforget
            // 
            this.linkforget.AutoSize = true;
            this.linkforget.Location = new System.Drawing.Point(181, 252);
            this.linkforget.Name = "linkforget";
            this.linkforget.Size = new System.Drawing.Size(102, 17);
            this.linkforget.TabIndex = 4;
            this.linkforget.TabStop = true;
            this.linkforget.Text = "نسيت كلمة المرور ؟";
            this.linkforget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkforget_LinkClicked);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 308);
            this.Controls.Add(this.linkforget);
            this.Controls.Add(this.Password_error);
            this.Controls.Add(this.textUsername_error);
            this.Controls.Add(this.linklRegister);
            this.Controls.Add(this.txtboxUser);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.TextBox txtboxUser;
        private System.Windows.Forms.LinkLabel linklRegister;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label textUsername_error;
        private System.Windows.Forms.Label Password_error;
        private System.Windows.Forms.LinkLabel linkforget;
    }
}

