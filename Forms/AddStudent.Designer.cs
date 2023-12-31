namespace DarAlArqamForm
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.radioButton_M = new System.Windows.Forms.RadioButton();
            this.radioButton_F = new System.Windows.Forms.RadioButton();
            this.date_birth = new System.Windows.Forms.DateTimePicker();
            this.comboBox_level = new System.Windows.Forms.ComboBox();
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.comboBox_branch = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_country = new System.Windows.Forms.ComboBox();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_PhoneError = new System.Windows.Forms.Label();
            this.label_NameError = new System.Windows.Forms.Label();
            this.label_birth = new System.Windows.Forms.Label();
            this.input_money = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.input_money)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LightSteelBlue;
            resources.ApplyResources(this.btn_add, "btn_add");
            this.btn_add.Name = "btn_add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_Name
            // 
            resources.ApplyResources(this.txt_Name, "txt_Name");
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // txt_phone
            // 
            resources.ApplyResources(this.txt_phone, "txt_phone");
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.TextChanged += new System.EventHandler(this.txt_phone_TextChanged);
            // 
            // radioButton_M
            // 
            resources.ApplyResources(this.radioButton_M, "radioButton_M");
            this.radioButton_M.Name = "radioButton_M";
            this.radioButton_M.TabStop = true;
            this.radioButton_M.UseVisualStyleBackColor = true;
            this.radioButton_M.CheckedChanged += new System.EventHandler(this.radioButton_M_CheckedChanged);
            // 
            // radioButton_F
            // 
            resources.ApplyResources(this.radioButton_F, "radioButton_F");
            this.radioButton_F.Name = "radioButton_F";
            this.radioButton_F.TabStop = true;
            this.radioButton_F.UseVisualStyleBackColor = true;
            this.radioButton_F.CheckedChanged += new System.EventHandler(this.radioButton_F_CheckedChanged);
            // 
            // date_birth
            // 
            resources.ApplyResources(this.date_birth, "date_birth");
            this.date_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_birth.Name = "date_birth";
            this.date_birth.ValueChanged += new System.EventHandler(this.date_birth_ValueChanged);
            // 
            // comboBox_level
            // 
            this.comboBox_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox_level, "comboBox_level");
            this.comboBox_level.FormattingEnabled = true;
            this.comboBox_level.Name = "comboBox_level";
            this.comboBox_level.SelectedIndexChanged += new System.EventHandler(this.comboBox_level_SelectedIndexChanged);
            // 
            // comboBox_class
            // 
            this.comboBox_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox_class, "comboBox_class");
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.SelectedIndexChanged += new System.EventHandler(this.comboBox_class_SelectedIndexChanged);
            // 
            // comboBox_branch
            // 
            this.comboBox_branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox_branch, "comboBox_branch");
            this.comboBox_branch.FormattingEnabled = true;
            this.comboBox_branch.Name = "comboBox_branch";
            this.comboBox_branch.SelectedIndexChanged += new System.EventHandler(this.comboBox_branch_SelectedIndexChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboBox_country
            // 
            this.comboBox_country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox_country, "comboBox_country");
            this.comboBox_country.FormattingEnabled = true;
            this.comboBox_country.Name = "comboBox_country";
            this.comboBox_country.SelectedIndexChanged += new System.EventHandler(this.comboBox_country_SelectedIndexChanged);
            // 
            // label_gender
            // 
            resources.ApplyResources(this.label_gender, "label_gender");
            this.label_gender.ForeColor = System.Drawing.Color.Red;
            this.label_gender.Name = "label_gender";
            this.label_gender.Click += new System.EventHandler(this.label_gender_Click);
            // 
            // label_PhoneError
            // 
            resources.ApplyResources(this.label_PhoneError, "label_PhoneError");
            this.label_PhoneError.ForeColor = System.Drawing.Color.Red;
            this.label_PhoneError.Name = "label_PhoneError";
            this.label_PhoneError.Click += new System.EventHandler(this.label_PhoneError_Click);
            // 
            // label_NameError
            // 
            resources.ApplyResources(this.label_NameError, "label_NameError");
            this.label_NameError.ForeColor = System.Drawing.Color.Red;
            this.label_NameError.Name = "label_NameError";
            this.label_NameError.Click += new System.EventHandler(this.label_NameError_Click);
            // 
            // label_birth
            // 
            resources.ApplyResources(this.label_birth, "label_birth");
            this.label_birth.ForeColor = System.Drawing.Color.Red;
            this.label_birth.Name = "label_birth";
            this.label_birth.Click += new System.EventHandler(this.label_birth_Click);
            // 
            // input_money
            // 
            resources.ApplyResources(this.input_money, "input_money");
            this.input_money.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.input_money.Name = "input_money";
            this.input_money.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // AddStudent
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.input_money);
            this.Controls.Add(this.label_birth);
            this.Controls.Add(this.label_NameError);
            this.Controls.Add(this.label_PhoneError);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.comboBox_country);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox_branch);
            this.Controls.Add(this.comboBox_class);
            this.Controls.Add(this.comboBox_level);
            this.Controls.Add(this.date_birth);
            this.Controls.Add(this.radioButton_F);
            this.Controls.Add(this.radioButton_M);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Name = "AddStudent";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.input_money)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.RadioButton radioButton_M;
        private System.Windows.Forms.RadioButton radioButton_F;
        private System.Windows.Forms.DateTimePicker date_birth;
        private System.Windows.Forms.ComboBox comboBox_level;
        private System.Windows.Forms.ComboBox comboBox_class;
        private System.Windows.Forms.ComboBox comboBox_branch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_country;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Label label_PhoneError;
        private System.Windows.Forms.Label label_NameError;
        private System.Windows.Forms.Label label_birth;
        private System.Windows.Forms.NumericUpDown input_money;
        private System.Windows.Forms.Label label9;
    }
}