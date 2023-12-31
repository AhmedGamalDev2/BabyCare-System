
namespace DarAlArqamForm
{
    partial class AddDonation
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_value = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_time = new System.Windows.Forms.DateTimePicker();
            this.txt_value = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txt_value)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AddBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(160, 229);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(199, 33);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "اضافه";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.ForeColor = System.Drawing.Color.Red;
            this.lbl_name.Location = new System.Drawing.Point(333, 21);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(96, 18);
            this.lbl_name.TabIndex = 10;
            this.lbl_name.Text = "الاسم غير صحيح";
            this.lbl_name.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(6, 21);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(72, 19);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "اسم المتبرع";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(105, 21);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(199, 26);
            this.txt_name.TabIndex = 8;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.ForeColor = System.Drawing.Color.Red;
            this.lbl_value.Location = new System.Drawing.Point(333, 61);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(98, 18);
            this.lbl_value.TabIndex = 20;
            this.lbl_value.Text = "ادخل مبلغ صحيحا";
            this.lbl_value.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "قيمة التبرع";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.ForeColor = System.Drawing.Color.Red;
            this.lbl_description.Location = new System.Drawing.Point(333, 143);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(110, 18);
            this.lbl_description.TabIndex = 26;
            this.lbl_description.Text = "الوصف غير صحيح";
            this.lbl_description.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "وصف التبرع";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(105, 143);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(199, 26);
            this.txt_description.TabIndex = 24;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.ForeColor = System.Drawing.Color.Red;
            this.lbl_date.Location = new System.Drawing.Point(333, 104);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(136, 18);
            this.lbl_date.TabIndex = 23;
            this.lbl_date.Text = "برجاء ادخال تاريخ صالح";
            this.lbl_date.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "تاريخ التبرع";
            // 
            // date_time
            // 
            this.date_time.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_time.Location = new System.Drawing.Point(105, 104);
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(199, 26);
            this.date_time.TabIndex = 27;
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(105, 57);
            this.txt_value.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(199, 26);
            this.txt_value.TabIndex = 28;
            // 
            // AddDonation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(529, 320);
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.date_time);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txt_name);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddDonation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة تبرع";
            this.Load += new System.EventHandler(this.AddDonation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_time;
        private System.Windows.Forms.NumericUpDown txt_value;
    }
}