
namespace DarAlArqamForm.Forms
{
    partial class UpdateStudentMaterial
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.inputGrade = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.inputMaterial = new System.Windows.Forms.TextBox();
            this.inputStudent = new System.Windows.Forms.TextBox();
            this.inputDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(369, 377);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 63);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "إغلاق";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // inputGrade
            // 
            this.inputGrade.DecimalPlaces = 2;
            this.inputGrade.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.inputGrade.Location = new System.Drawing.Point(177, 240);
            this.inputGrade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputGrade.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.inputGrade.Name = "inputGrade";
            this.inputGrade.Size = new System.Drawing.Size(311, 22);
            this.inputGrade.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 318);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "ملاحظات";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "التاريخ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "الدرجة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "المادة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "الطالب";
            // 
            // inputDescription
            // 
            this.inputDescription.Location = new System.Drawing.Point(177, 305);
            this.inputDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputDescription.Multiline = true;
            this.inputDescription.Name = "inputDescription";
            this.inputDescription.Size = new System.Drawing.Size(311, 38);
            this.inputDescription.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(177, 377);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 63);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // inputMaterial
            // 
            this.inputMaterial.Location = new System.Drawing.Point(177, 110);
            this.inputMaterial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputMaterial.Name = "inputMaterial";
            this.inputMaterial.ReadOnly = true;
            this.inputMaterial.Size = new System.Drawing.Size(311, 22);
            this.inputMaterial.TabIndex = 24;
            // 
            // inputStudent
            // 
            this.inputStudent.Location = new System.Drawing.Point(177, 41);
            this.inputStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputStudent.Name = "inputStudent";
            this.inputStudent.ReadOnly = true;
            this.inputStudent.Size = new System.Drawing.Size(311, 22);
            this.inputStudent.TabIndex = 25;
            // 
            // inputDate
            // 
            this.inputDate.Location = new System.Drawing.Point(177, 175);
            this.inputDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputDate.Name = "inputDate";
            this.inputDate.ReadOnly = true;
            this.inputDate.Size = new System.Drawing.Size(311, 22);
            this.inputDate.TabIndex = 26;
            // 
            // UpdateStudentMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 489);
            this.Controls.Add(this.inputDate);
            this.Controls.Add(this.inputStudent);
            this.Controls.Add(this.inputMaterial);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.inputGrade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputDescription);
            this.Controls.Add(this.btnSave);
            this.Name = "UpdateStudentMaterial";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "UpdateStudentMaterial";
            this.Load += new System.EventHandler(this.UpdateStudentMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown inputGrade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox inputMaterial;
        private System.Windows.Forms.TextBox inputStudent;
        private System.Windows.Forms.TextBox inputDate;
    }
}