
namespace DarAlArqamForm.Forms
{
    partial class Payments
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewPayment = new System.Windows.Forms.DataGridView();
            this.Fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.TxtBoxStore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "تفاصيل الماليات";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewPayment
            // 
            this.dataGridViewPayment.AllowUserToAddRows = false;
            this.dataGridViewPayment.AllowUserToDeleteRows = false;
            this.dataGridViewPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fees,
            this.TeacherSalary,
            this.EmployeeSalary,
            this.Cost,
            this.Donation});
            this.dataGridViewPayment.Location = new System.Drawing.Point(-1, 160);
            this.dataGridViewPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewPayment.Name = "dataGridViewPayment";
            this.dataGridViewPayment.ReadOnly = true;
            this.dataGridViewPayment.RowHeadersWidth = 51;
            this.dataGridViewPayment.RowTemplate.Height = 24;
            this.dataGridViewPayment.Size = new System.Drawing.Size(876, 210);
            this.dataGridViewPayment.TabIndex = 1;
            // 
            // Fees
            // 
            this.Fees.FillWeight = 435.8289F;
            this.Fees.HeaderText = "اشتراكات الطلاب";
            this.Fees.MinimumWidth = 6;
            this.Fees.Name = "Fees";
            this.Fees.ReadOnly = true;
            this.Fees.Width = 180;
            // 
            // TeacherSalary
            // 
            this.TeacherSalary.FillWeight = 16.04278F;
            this.TeacherSalary.HeaderText = "مرتبات المعلمين";
            this.TeacherSalary.MinimumWidth = 6;
            this.TeacherSalary.Name = "TeacherSalary";
            this.TeacherSalary.ReadOnly = true;
            this.TeacherSalary.Width = 180;
            // 
            // EmployeeSalary
            // 
            this.EmployeeSalary.FillWeight = 16.04278F;
            this.EmployeeSalary.HeaderText = "مرتبات العمال";
            this.EmployeeSalary.MinimumWidth = 6;
            this.EmployeeSalary.Name = "EmployeeSalary";
            this.EmployeeSalary.ReadOnly = true;
            this.EmployeeSalary.Width = 160;
            // 
            // Cost
            // 
            this.Cost.FillWeight = 16.04278F;
            this.Cost.HeaderText = "المصاريف";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 150;
            // 
            // Donation
            // 
            this.Donation.FillWeight = 16.04278F;
            this.Donation.HeaderText = "التبرعات";
            this.Donation.MinimumWidth = 6;
            this.Donation.Name = "Donation";
            this.Donation.ReadOnly = true;
            this.Donation.Width = 150;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(33, 85);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(153, 59);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "تحديث البيانات";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // TxtBoxStore
            // 
            this.TxtBoxStore.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxStore.Location = new System.Drawing.Point(665, 101);
            this.TxtBoxStore.Name = "TxtBoxStore";
            this.TxtBoxStore.ReadOnly = true;
            this.TxtBoxStore.Size = new System.Drawing.Size(168, 32);
            this.TxtBoxStore.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(660, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "القيمة الكلية";
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 370);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBoxStore);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridViewPayment);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Payments";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفاصيل الماليات";
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewPayment;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fees;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donation;
        private System.Windows.Forms.TextBox TxtBoxStore;
        private System.Windows.Forms.Label label2;
    }
}