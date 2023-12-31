namespace DarAlArqamForm
{
    partial class studentdata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentdata));
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stcountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stbirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stgender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stbranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stteacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stlevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_searcherror = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_pay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.LightSteelBlue;
            resources.ApplyResources(this.btn_search, "btn_search");
            this.btn_search.Name = "btn_search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            resources.ApplyResources(this.txt_search, "txt_search");
            this.txt_search.Name = "txt_search";
            this.txt_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4")});
            this.comboBox1.Name = "comboBox1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stname,
            this.stcountry,
            this.stbirthdate,
            this.stphone,
            this.stgender,
            this.stclass,
            this.stbranch,
            this.stteacher,
            this.stlevel,
            this.input_money});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stname
            // 
            resources.ApplyResources(this.stname, "stname");
            this.stname.Name = "stname";
            this.stname.ReadOnly = true;
            // 
            // stcountry
            // 
            resources.ApplyResources(this.stcountry, "stcountry");
            this.stcountry.Name = "stcountry";
            this.stcountry.ReadOnly = true;
            // 
            // stbirthdate
            // 
            resources.ApplyResources(this.stbirthdate, "stbirthdate");
            this.stbirthdate.Name = "stbirthdate";
            this.stbirthdate.ReadOnly = true;
            // 
            // stphone
            // 
            resources.ApplyResources(this.stphone, "stphone");
            this.stphone.Name = "stphone";
            this.stphone.ReadOnly = true;
            // 
            // stgender
            // 
            resources.ApplyResources(this.stgender, "stgender");
            this.stgender.Name = "stgender";
            this.stgender.ReadOnly = true;
            // 
            // stclass
            // 
            resources.ApplyResources(this.stclass, "stclass");
            this.stclass.Name = "stclass";
            this.stclass.ReadOnly = true;
            // 
            // stbranch
            // 
            resources.ApplyResources(this.stbranch, "stbranch");
            this.stbranch.Name = "stbranch";
            this.stbranch.ReadOnly = true;
            // 
            // stteacher
            // 
            resources.ApplyResources(this.stteacher, "stteacher");
            this.stteacher.Name = "stteacher";
            this.stteacher.ReadOnly = true;
            // 
            // stlevel
            // 
            resources.ApplyResources(this.stlevel, "stlevel");
            this.stlevel.Name = "stlevel";
            this.stlevel.ReadOnly = true;
            // 
            // input_money
            // 
            resources.ApplyResources(this.input_money, "input_money");
            this.input_money.Name = "input_money";
            this.input_money.ReadOnly = true;
            // 
            // label_searcherror
            // 
            resources.ApplyResources(this.label_searcherror, "label_searcherror");
            this.label_searcherror.ForeColor = System.Drawing.Color.Red;
            this.label_searcherror.Name = "label_searcherror";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_delete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btn_delete, "btn_delete");
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.LightSteelBlue;
            resources.ApplyResources(this.btn_update, "btn_update");
            this.btn_update.Name = "btn_update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.LightSteelBlue;
            resources.ApplyResources(this.btn_print, "btn_print");
            this.btn_print.Name = "btn_print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_pay
            // 
            this.btn_pay.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_pay.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btn_pay, "btn_pay");
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.UseVisualStyleBackColor = false;
            this.btn_pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // studentdata
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label_searcherror);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_search);
            this.Name = "studentdata";
            this.Load += new System.EventHandler(this.student_data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_searcherror;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.DataGridViewTextBoxColumn stname;
        private System.Windows.Forms.DataGridViewTextBoxColumn stcountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn stbirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn stphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn stgender;
        private System.Windows.Forms.DataGridViewTextBoxColumn stclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn stbranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn stteacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn stlevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_money;
        private System.Windows.Forms.Button btn_pay;
    }
}