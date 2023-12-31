
namespace DarAlArqamForm.Forms
{
    partial class StudentGradeReports
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
            this.dataGridViewStudentMaterial = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudentMaterial
            // 
            this.dataGridViewStudentMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentMaterial.Location = new System.Drawing.Point(-2, 91);
            this.dataGridViewStudentMaterial.Name = "dataGridViewStudentMaterial";
            this.dataGridViewStudentMaterial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewStudentMaterial.RowHeadersWidth = 51;
            this.dataGridViewStudentMaterial.RowTemplate.Height = 24;
            this.dataGridViewStudentMaterial.Size = new System.Drawing.Size(760, 253);
            this.dataGridViewStudentMaterial.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(601, 28);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(114, 44);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // StudentGradeReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 342);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridViewStudentMaterial);
            this.Name = "StudentGradeReports";
            this.Text = "StudentGradeReports";
            this.Load += new System.EventHandler(this.StudentGradeReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentMaterial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewStudentMaterial;
        private System.Windows.Forms.Button btnPrint;
    }
}