
namespace DarAlArqamForm
{
    partial class DonnationUpdateData
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
            this.date_time = new System.Windows.Forms.DateTimePicker();
            this.lbl_description = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_value = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_value = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txt_value)).BeginInit();
            this.SuspendLayout();
            // 
            // date_time
            // 
            this.date_time.Location = new System.Drawing.Point(121, 117);
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(200, 27);
            this.date_time.TabIndex = 40;
            this.date_time.ValueChanged += new System.EventHandler(this.date_time_ValueChanged);
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.ForeColor = System.Drawing.Color.Red;
            this.lbl_description.Location = new System.Drawing.Point(349, 159);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(124, 19);
            this.lbl_description.TabIndex = 39;
            this.lbl_description.Text = "الوصف غير صحيح";
            this.lbl_description.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "وصف التبرع";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(121, 159);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(200, 27);
            this.txt_description.TabIndex = 37;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.ForeColor = System.Drawing.Color.Red;
            this.lbl_date.Location = new System.Drawing.Point(349, 117);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(157, 19);
            this.lbl_date.TabIndex = 36;
            this.lbl_date.Text = "برجاء ادخال تاريخ صالح";
            this.lbl_date.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "تاريخ التبرع";
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.ForeColor = System.Drawing.Color.Red;
            this.lbl_value.Location = new System.Drawing.Point(349, 73);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(127, 19);
            this.lbl_value.TabIndex = 34;
            this.lbl_value.Text = "ادخل مبلغ صحيحا";
            this.lbl_value.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "قيمة التبرع";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(134, 219);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(254, 35);
            this.SaveBtn.TabIndex = 31;
            this.SaveBtn.Text = "حفظ";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.ForeColor = System.Drawing.Color.Red;
            this.lbl_name.Location = new System.Drawing.Point(349, 31);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(122, 19);
            this.lbl_name.TabIndex = 30;
            this.lbl_name.Text = "الاسم غير صحيح";
            this.lbl_name.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(22, 31);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(93, 19);
            this.lbl1.TabIndex = 29;
            this.lbl1.Text = "اسم المتبرع";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(121, 28);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(200, 27);
            this.txt_name.TabIndex = 28;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(121, 71);
            this.txt_value.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(200, 27);
            this.txt_value.TabIndex = 41;
            // 
            // DonnationUpdateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 348);
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.date_time);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txt_name);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DonnationUpdateData";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحديث البيانات";
            this.Load += new System.EventHandler(this.DonnationUpdateData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date_time;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.NumericUpDown txt_value;
    }
}