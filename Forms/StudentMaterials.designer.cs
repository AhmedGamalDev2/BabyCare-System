
namespace DarAlArqamForm.Forms
{
    partial class StudentMaterialsForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewStudentMaterial = new System.Windows.Forms.DataGridView();
            this.StudentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(31, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 49);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewStudentMaterial
            // 
            this.dataGridViewStudentMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentColumn,
            this.MaterialColumn,
            this.GradeColumn,
            this.DateColumn,
            this.NotesColumn});
            this.dataGridViewStudentMaterial.Location = new System.Drawing.Point(1, 111);
            this.dataGridViewStudentMaterial.Name = "dataGridViewStudentMaterial";
            this.dataGridViewStudentMaterial.RowHeadersWidth = 51;
            this.dataGridViewStudentMaterial.RowTemplate.Height = 24;
            this.dataGridViewStudentMaterial.Size = new System.Drawing.Size(899, 341);
            this.dataGridViewStudentMaterial.TabIndex = 1;
            // 
            // StudentColumn
            // 
            this.StudentColumn.Frozen = true;
            this.StudentColumn.HeaderText = "الطالب";
            this.StudentColumn.MinimumWidth = 6;
            this.StudentColumn.Name = "StudentColumn";
            this.StudentColumn.Width = 200;
            // 
            // MaterialColumn
            // 
            this.MaterialColumn.Frozen = true;
            this.MaterialColumn.HeaderText = "المادة";
            this.MaterialColumn.MinimumWidth = 6;
            this.MaterialColumn.Name = "MaterialColumn";
            this.MaterialColumn.Width = 125;
            // 
            // GradeColumn
            // 
            this.GradeColumn.Frozen = true;
            this.GradeColumn.HeaderText = "الدرجة";
            this.GradeColumn.MinimumWidth = 6;
            this.GradeColumn.Name = "GradeColumn";
            this.GradeColumn.Width = 80;
            // 
            // DateColumn
            // 
            this.DateColumn.Frozen = true;
            this.DateColumn.HeaderText = "التاريخ";
            this.DateColumn.MinimumWidth = 6;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.Width = 125;
            // 
            // NotesColumn
            // 
            this.NotesColumn.Frozen = true;
            this.NotesColumn.HeaderText = "ملاحظات";
            this.NotesColumn.MinimumWidth = 6;
            this.NotesColumn.Name = "NotesColumn";
            this.NotesColumn.Width = 200;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(458, 36);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 49);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "تحديث البيانات";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(322, 36);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 49);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(166, 36);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 49);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // StudentMaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridViewStudentMaterial);
            this.Controls.Add(this.btnAdd);
            this.Name = "StudentMaterialsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "المواد";
            this.Load += new System.EventHandler(this.StudentMaterialsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentMaterial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewStudentMaterial;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotesColumn;
    }
}