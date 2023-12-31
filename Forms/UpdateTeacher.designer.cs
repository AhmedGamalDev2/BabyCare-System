namespace DarAlArqamForm.Forms
{
    partial class UpdateTeacher
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblBranch = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.comboBoxTEeacher = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.lblErrorPhone = new System.Windows.Forms.Label();
            this.lblErrorSalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(141, 411);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 59);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(87, 318);
            this.lblBranch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(43, 20);
            this.lblBranch.TabIndex = 17;
            this.lblBranch.Text = "الفرع";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(177, 225);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(324, 26);
            this.txtSalary.TabIndex = 16;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(89, 230);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(50, 20);
            this.lblSalary.TabIndex = 15;
            this.lblSalary.Text = "المرتب";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(177, 145);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(324, 26);
            this.txtPhone.TabIndex = 14;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(89, 153);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(51, 20);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "الموبيل";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(179, 65);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(322, 26);
            this.txtName.TabIndex = 12;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(89, 54);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 20);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "الاسم";
            // 
            // comboBoxTEeacher
            // 
            this.comboBoxTEeacher.FormattingEnabled = true;
            this.comboBoxTEeacher.Location = new System.Drawing.Point(175, 318);
            this.comboBoxTEeacher.Name = "comboBoxTEeacher";
            this.comboBoxTEeacher.Size = new System.Drawing.Size(326, 28);
            this.comboBoxTEeacher.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(336, 411);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 59);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "إغلاق";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(547, 70);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(67, 20);
            this.lblErrorName.TabIndex = 22;
            this.lblErrorName.Text = "هناك خطأ";
            this.lblErrorName.Visible = false;
            // 
            // lblErrorPhone
            // 
            this.lblErrorPhone.AutoSize = true;
            this.lblErrorPhone.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPhone.Location = new System.Drawing.Point(547, 153);
            this.lblErrorPhone.Name = "lblErrorPhone";
            this.lblErrorPhone.Size = new System.Drawing.Size(67, 20);
            this.lblErrorPhone.TabIndex = 23;
            this.lblErrorPhone.Text = "هناك خطأ";
            this.lblErrorPhone.Visible = false;
            // 
            // lblErrorSalary
            // 
            this.lblErrorSalary.AutoSize = true;
            this.lblErrorSalary.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSalary.Location = new System.Drawing.Point(547, 237);
            this.lblErrorSalary.Name = "lblErrorSalary";
            this.lblErrorSalary.Size = new System.Drawing.Size(67, 20);
            this.lblErrorSalary.TabIndex = 24;
            this.lblErrorSalary.Text = "هناك خطأ";
            this.lblErrorSalary.Visible = false;
            this.lblErrorSalary.Click += new System.EventHandler(this.lblErrorSalary_Click);
            // 
            // UpdateTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 498);
            this.Controls.Add(this.lblErrorSalary);
            this.Controls.Add(this.lblErrorPhone);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.comboBoxTEeacher);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateTeacher";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بيانات معلم";
            this.Load += new System.EventHandler(this.RemoveTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox comboBoxTEeacher;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.Label lblErrorPhone;
        private System.Windows.Forms.Label lblErrorSalary;
    }
}