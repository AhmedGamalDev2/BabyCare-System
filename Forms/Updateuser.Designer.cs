namespace DarAlArqamForm.Forms
{
    partial class Updateuser
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
            this.label_erroremail = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_errorpass2 = new System.Windows.Forms.Label();
            this.txt_secPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label_errorpass1 = new System.Windows.Forms.Label();
            this.txt_firstPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_erroremail
            // 
            this.label_erroremail.AutoSize = true;
            this.label_erroremail.ForeColor = System.Drawing.Color.Red;
            this.label_erroremail.Location = new System.Drawing.Point(329, 94);
            this.label_erroremail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_erroremail.Name = "label_erroremail";
            this.label_erroremail.Size = new System.Drawing.Size(72, 13);
            this.label_erroremail.TabIndex = 13;
            this.label_erroremail.Text = "خطأ في البريد";
            this.label_erroremail.Visible = false;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(147, 87);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(158, 20);
            this.txt_Email.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "البريد الالكتروني";
            // 
            // label_errorpass2
            // 
            this.label_errorpass2.AutoSize = true;
            this.label_errorpass2.ForeColor = System.Drawing.Color.Red;
            this.label_errorpass2.Location = new System.Drawing.Point(329, 193);
            this.label_errorpass2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_errorpass2.Name = "label_errorpass2";
            this.label_errorpass2.Size = new System.Drawing.Size(98, 13);
            this.label_errorpass2.TabIndex = 16;
            this.label_errorpass2.Text = "خطأ في كلمة المرور";
            this.label_errorpass2.Visible = false;
            // 
            // txt_secPassword
            // 
            this.txt_secPassword.Location = new System.Drawing.Point(147, 193);
            this.txt_secPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txt_secPassword.Name = "txt_secPassword";
            this.txt_secPassword.Size = new System.Drawing.Size(158, 20);
            this.txt_secPassword.TabIndex = 15;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(28, 193);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(101, 13);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "تاكيد كلمة المرور";
            // 
            // label_errorpass1
            // 
            this.label_errorpass1.AutoSize = true;
            this.label_errorpass1.ForeColor = System.Drawing.Color.Red;
            this.label_errorpass1.Location = new System.Drawing.Point(329, 137);
            this.label_errorpass1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_errorpass1.Name = "label_errorpass1";
            this.label_errorpass1.Size = new System.Drawing.Size(98, 13);
            this.label_errorpass1.TabIndex = 19;
            this.label_errorpass1.Text = "خطأ في كلمة المرور";
            this.label_errorpass1.Visible = false;
            // 
            // txt_firstPassword
            // 
            this.txt_firstPassword.Location = new System.Drawing.Point(147, 137);
            this.txt_firstPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txt_firstPassword.Name = "txt_firstPassword";
            this.txt_firstPassword.Size = new System.Drawing.Size(158, 20);
            this.txt_firstPassword.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "كلمة المرور";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(179, 266);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(103, 35);
            this.btn_save.TabIndex = 20;
            this.btn_save.Text = "تاكيد";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // Updateuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 434);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label_errorpass1);
            this.Controls.Add(this.txt_firstPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_errorpass2);
            this.Controls.Add(this.txt_secPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label_erroremail);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label1);
            this.Name = "Updateuser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تحديث كلمه المرور";
            this.Load += new System.EventHandler(this.Updateuser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_erroremail;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_errorpass2;
        private System.Windows.Forms.TextBox txt_secPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label_errorpass1;
        private System.Windows.Forms.TextBox txt_firstPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save;
    }
}