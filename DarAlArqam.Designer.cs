
using System.Drawing;

namespace DarAlArqamForm
{
    partial class DarAlArqam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DarAlArqam));
            this.Title = new System.Windows.Forms.MenuStrip();
            this.الطلابToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافةطالبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفوتعديلالطالبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المدرسينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بياناتالمرسToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الموظفينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بياناتالمواظفينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الفصولToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.حذففصلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الفروعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذففرعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.القرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهقريهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفقريهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الموادToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.المستويToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضالمستوياتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الايراداتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.توريددعمخارجيToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اجماليالايراداتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المصروفاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دفعرواتبالمدرسينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دفعرواتبالعمالToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دفعفواتيرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جماليالمصروفاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الخزنهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.القواعدالقبولToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.LightSteelBlue;
            resources.ApplyResources(this.Title, "Title");
            this.Title.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Title.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الطلابToolStripMenuItem,
            this.المدرسينToolStripMenuItem,
            this.الموظفينToolStripMenuItem,
            this.الفصولToolStripMenuItem,
            this.الفروعToolStripMenuItem,
            this.القرToolStripMenuItem,
            this.المستويToolStripMenuItem,
            this.الموادToolStripMenuItem,
            this.الايراداتToolStripMenuItem,
            this.المصروفاتToolStripMenuItem,
            this.الخزنهToolStripMenuItem,
            this.القواعدالقبولToolStripMenuItem});
            this.Title.Name = "Title";
            this.Title.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Title_ItemClicked);
            // 
            // الطلابToolStripMenuItem
            // 
            this.الطلابToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافةطالبToolStripMenuItem,
            this.حذفوتعديلالطالبToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.الطلابToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.Students1;
            this.الطلابToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.الطلابToolStripMenuItem.Name = "الطلابToolStripMenuItem";
            resources.ApplyResources(this.الطلابToolStripMenuItem, "الطلابToolStripMenuItem");
            // 
            // اضافةطالبToolStripMenuItem
            // 
            this.اضافةطالبToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.addstudent;
            this.اضافةطالبToolStripMenuItem.Name = "اضافةطالبToolStripMenuItem";
            resources.ApplyResources(this.اضافةطالبToolStripMenuItem, "اضافةطالبToolStripMenuItem");
            this.اضافةطالبToolStripMenuItem.Click += new System.EventHandler(this.اضافةطالبToolStripMenuItem_Click);
            // 
            // حذفوتعديلالطالبToolStripMenuItem
            // 
            this.حذفوتعديلالطالبToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.student2;
            this.حذفوتعديلالطالبToolStripMenuItem.Name = "حذفوتعديلالطالبToolStripMenuItem";
            resources.ApplyResources(this.حذفوتعديلالطالبToolStripMenuItem, "حذفوتعديلالطالبToolStripMenuItem");
            this.حذفوتعديلالطالبToolStripMenuItem.Click += new System.EventHandler(this.حذفوتعديلالطالبToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            resources.ApplyResources(this.reportsToolStripMenuItem, "reportsToolStripMenuItem");
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // المدرسينToolStripMenuItem
            // 
            this.المدرسينToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بياناتالمرسToolStripMenuItem});
            this.المدرسينToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.teachers3;
            this.المدرسينToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.المدرسينToolStripMenuItem.Name = "المدرسينToolStripMenuItem";
            resources.ApplyResources(this.المدرسينToolStripMenuItem, "المدرسينToolStripMenuItem");
            // 
            // بياناتالمرسToolStripMenuItem
            // 
            this.بياناتالمرسToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.teacher;
            this.بياناتالمرسToolStripMenuItem.Name = "بياناتالمرسToolStripMenuItem";
            resources.ApplyResources(this.بياناتالمرسToolStripMenuItem, "بياناتالمرسToolStripMenuItem");
            this.بياناتالمرسToolStripMenuItem.Click += new System.EventHandler(this.بياناتالمرسToolStripMenuItem_Click);
            // 
            // الموظفينToolStripMenuItem
            // 
            this.الموظفينToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بياناتالمواظفينToolStripMenuItem});
            this.الموظفينToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.employee3;
            this.الموظفينToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.الموظفينToolStripMenuItem.Name = "الموظفينToolStripMenuItem";
            resources.ApplyResources(this.الموظفينToolStripMenuItem, "الموظفينToolStripMenuItem");
            // 
            // بياناتالمواظفينToolStripMenuItem
            // 
            this.بياناتالمواظفينToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.employee;
            this.بياناتالمواظفينToolStripMenuItem.Name = "بياناتالمواظفينToolStripMenuItem";
            resources.ApplyResources(this.بياناتالمواظفينToolStripMenuItem, "بياناتالمواظفينToolStripMenuItem");
            this.بياناتالمواظفينToolStripMenuItem.Click += new System.EventHandler(this.بياناتالمواظفينToolStripMenuItem_Click);
            // 
            // الفصولToolStripMenuItem
            // 
            this.الفصولToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافهToolStripMenuItem1,
            this.حذففصلToolStripMenuItem});
            this.الفصولToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.classroom;
            this.الفصولToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.الفصولToolStripMenuItem.Name = "الفصولToolStripMenuItem";
            resources.ApplyResources(this.الفصولToolStripMenuItem, "الفصولToolStripMenuItem");
            // 
            // اضافهToolStripMenuItem1
            // 
            this.اضافهToolStripMenuItem1.Image = global::DarAlArqamForm.Properties.Resources.add;
            this.اضافهToolStripMenuItem1.Name = "اضافهToolStripMenuItem1";
            resources.ApplyResources(this.اضافهToolStripMenuItem1, "اضافهToolStripMenuItem1");
            this.اضافهToolStripMenuItem1.Click += new System.EventHandler(this.اضافهToolStripMenuItem1_Click);
            // 
            // حذففصلToolStripMenuItem
            // 
            this.حذففصلToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.classroom;
            this.حذففصلToolStripMenuItem.Name = "حذففصلToolStripMenuItem";
            resources.ApplyResources(this.حذففصلToolStripMenuItem, "حذففصلToolStripMenuItem");
            this.حذففصلToolStripMenuItem.Click += new System.EventHandler(this.حذففصلToolStripMenuItem_Click);
            // 
            // الفروعToolStripMenuItem
            // 
            this.الفروعToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اToolStripMenuItem,
            this.حذففرعToolStripMenuItem});
            this.الفروعToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.branch;
            this.الفروعToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.الفروعToolStripMenuItem.Name = "الفروعToolStripMenuItem";
            resources.ApplyResources(this.الفروعToolStripMenuItem, "الفروعToolStripMenuItem");
            // 
            // اToolStripMenuItem
            // 
            this.اToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.add;
            this.اToolStripMenuItem.Name = "اToolStripMenuItem";
            resources.ApplyResources(this.اToolStripMenuItem, "اToolStripMenuItem");
            this.اToolStripMenuItem.Click += new System.EventHandler(this.اToolStripMenuItem_Click);
            // 
            // حذففرعToolStripMenuItem
            // 
            this.حذففرعToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.branch;
            this.حذففرعToolStripMenuItem.Name = "حذففرعToolStripMenuItem";
            resources.ApplyResources(this.حذففرعToolStripMenuItem, "حذففرعToolStripMenuItem");
            this.حذففرعToolStripMenuItem.Click += new System.EventHandler(this.حذففرعToolStripMenuItem_Click);
            // 
            // القرToolStripMenuItem
            // 
            this.القرToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافهقريهToolStripMenuItem,
            this.حذفقريهToolStripMenuItem});
            this.القرToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.bulding;
            this.القرToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.القرToolStripMenuItem.Name = "القرToolStripMenuItem";
            resources.ApplyResources(this.القرToolStripMenuItem, "القرToolStripMenuItem");
            // 
            // اضافهقريهToolStripMenuItem
            // 
            this.اضافهقريهToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.add;
            this.اضافهقريهToolStripMenuItem.Name = "اضافهقريهToolStripMenuItem";
            resources.ApplyResources(this.اضافهقريهToolStripMenuItem, "اضافهقريهToolStripMenuItem");
            this.اضافهقريهToolStripMenuItem.Click += new System.EventHandler(this.اضافهقريهToolStripMenuItem_Click);
            // 
            // حذفقريهToolStripMenuItem
            // 
            this.حذفقريهToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.country;
            this.حذفقريهToolStripMenuItem.Name = "حذفقريهToolStripMenuItem";
            resources.ApplyResources(this.حذفقريهToolStripMenuItem, "حذفقريهToolStripMenuItem");
            this.حذفقريهToolStripMenuItem.Click += new System.EventHandler(this.حذفقريهToolStripMenuItem_Click);
            // 
            // الموادToolStripMenuItem
            // 
            this.الموادToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عرضToolStripMenuItem,
            this.toolStripMenuItem1,
            this.reportsToolStripMenuItem1});
            this.الموادToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.Material;
            this.الموادToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.الموادToolStripMenuItem.Name = "الموادToolStripMenuItem";
            resources.ApplyResources(this.الموادToolStripMenuItem, "الموادToolStripMenuItem");
            this.الموادToolStripMenuItem.Click += new System.EventHandler(this.الموادToolStripMenuItem_Click);
            // 
            // عرضToolStripMenuItem
            // 
            this.عرضToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.Material;
            this.عرضToolStripMenuItem.Name = "عرضToolStripMenuItem";
            resources.ApplyResources(this.عرضToolStripMenuItem, "عرضToolStripMenuItem");
            this.عرضToolStripMenuItem.Click += new System.EventHandler(this.عرضToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // reportsToolStripMenuItem1
            // 
            this.reportsToolStripMenuItem1.Name = "reportsToolStripMenuItem1";
            resources.ApplyResources(this.reportsToolStripMenuItem1, "reportsToolStripMenuItem1");
            this.reportsToolStripMenuItem1.Click += new System.EventHandler(this.reportsToolStripMenuItem1_Click);
            // 
            // المستويToolStripMenuItem
            // 
            this.المستويToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عرضالمستوياتToolStripMenuItem});
            this.المستويToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.Level;
            this.المستويToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.المستويToolStripMenuItem.Name = "المستويToolStripMenuItem";
            resources.ApplyResources(this.المستويToolStripMenuItem, "المستويToolStripMenuItem");
            // 
            // عرضالمستوياتToolStripMenuItem
            // 
            this.عرضالمستوياتToolStripMenuItem.Name = "عرضالمستوياتToolStripMenuItem";
            resources.ApplyResources(this.عرضالمستوياتToolStripMenuItem, "عرضالمستوياتToolStripMenuItem");
            this.عرضالمستوياتToolStripMenuItem.Click += new System.EventHandler(this.عرضالمستوياتToolStripMenuItem_Click);
            // 
            // الايراداتToolStripMenuItem
            // 
            this.الايراداتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.توريددعمخارجيToolStripMenuItem,
            this.اجماليالايراداتToolStripMenuItem});
            this.الايراداتToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.costin;
            this.الايراداتToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.الايراداتToolStripMenuItem.Name = "الايراداتToolStripMenuItem";
            resources.ApplyResources(this.الايراداتToolStripMenuItem, "الايراداتToolStripMenuItem");
            // 
            // توريددعمخارجيToolStripMenuItem
            // 
            this.توريددعمخارجيToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.getmony;
            this.توريددعمخارجيToolStripMenuItem.Name = "توريددعمخارجيToolStripMenuItem";
            resources.ApplyResources(this.توريددعمخارجيToolStripMenuItem, "توريددعمخارجيToolStripMenuItem");
            this.توريددعمخارجيToolStripMenuItem.Click += new System.EventHandler(this.توريددعمخارجيToolStripMenuItem_Click);
            // 
            // اجماليالايراداتToolStripMenuItem
            // 
            this.اجماليالايراداتToolStripMenuItem.Name = "اجماليالايراداتToolStripMenuItem";
            resources.ApplyResources(this.اجماليالايراداتToolStripMenuItem, "اجماليالايراداتToolStripMenuItem");
            this.اجماليالايراداتToolStripMenuItem.Click += new System.EventHandler(this.اجماليالايراداتToolStripMenuItem_Click);
            // 
            // المصروفاتToolStripMenuItem
            // 
            this.المصروفاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.دفعرواتبالمدرسينToolStripMenuItem,
            this.دفعرواتبالعمالToolStripMenuItem,
            this.دفعفواتيرToolStripMenuItem,
            this.جماليالمصروفاتToolStripMenuItem});
            this.المصروفاتToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.costout;
            this.المصروفاتToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.المصروفاتToolStripMenuItem.Name = "المصروفاتToolStripMenuItem";
            resources.ApplyResources(this.المصروفاتToolStripMenuItem, "المصروفاتToolStripMenuItem");
            this.المصروفاتToolStripMenuItem.Click += new System.EventHandler(this.المصروفاتToolStripMenuItem_Click);
            // 
            // دفعرواتبالمدرسينToolStripMenuItem
            // 
            this.دفعرواتبالمدرسينToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.pay;
            this.دفعرواتبالمدرسينToolStripMenuItem.Name = "دفعرواتبالمدرسينToolStripMenuItem";
            resources.ApplyResources(this.دفعرواتبالمدرسينToolStripMenuItem, "دفعرواتبالمدرسينToolStripMenuItem");
            this.دفعرواتبالمدرسينToolStripMenuItem.Click += new System.EventHandler(this.دفعرواتبالمدرسينToolStripMenuItem_Click);
            // 
            // دفعرواتبالعمالToolStripMenuItem
            // 
            this.دفعرواتبالعمالToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.pay;
            this.دفعرواتبالعمالToolStripMenuItem.Name = "دفعرواتبالعمالToolStripMenuItem";
            resources.ApplyResources(this.دفعرواتبالعمالToolStripMenuItem, "دفعرواتبالعمالToolStripMenuItem");
            this.دفعرواتبالعمالToolStripMenuItem.Click += new System.EventHandler(this.دفعرواتبالعمالToolStripMenuItem_Click);
            // 
            // دفعفواتيرToolStripMenuItem
            // 
            this.دفعفواتيرToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.pay;
            this.دفعفواتيرToolStripMenuItem.Name = "دفعفواتيرToolStripMenuItem";
            resources.ApplyResources(this.دفعفواتيرToolStripMenuItem, "دفعفواتيرToolStripMenuItem");
            this.دفعفواتيرToolStripMenuItem.Click += new System.EventHandler(this.دفعفواتيرToolStripMenuItem_Click);
            // 
            // جماليالمصروفاتToolStripMenuItem
            // 
            this.جماليالمصروفاتToolStripMenuItem.Name = "جماليالمصروفاتToolStripMenuItem";
            resources.ApplyResources(this.جماليالمصروفاتToolStripMenuItem, "جماليالمصروفاتToolStripMenuItem");
            this.جماليالمصروفاتToolStripMenuItem.Click += new System.EventHandler(this.جماليالمصروفاتToolStripMenuItem_Click);
            // 
            // الخزنهToolStripMenuItem
            // 
            this.الخزنهToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.money_bag;
            this.الخزنهToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.الخزنهToolStripMenuItem.Name = "الخزنهToolStripMenuItem";
            resources.ApplyResources(this.الخزنهToolStripMenuItem, "الخزنهToolStripMenuItem");
            this.الخزنهToolStripMenuItem.Click += new System.EventHandler(this.الخزنهToolStripMenuItem_Click);
            // 
            // القواعدالقبولToolStripMenuItem
            // 
            resources.ApplyResources(this.القواعدالقبولToolStripMenuItem, "القواعدالقبولToolStripMenuItem");
            this.القواعدالقبولToolStripMenuItem.Image = global::DarAlArqamForm.Properties.Resources.roles1;
            this.القواعدالقبولToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.القواعدالقبولToolStripMenuItem.Name = "القواعدالقبولToolStripMenuItem";
            this.القواعدالقبولToolStripMenuItem.Click += new System.EventHandler(this.القواعدالقبولToolStripMenuItem_Click);
            // 
            // DarAlArqam
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DarAlArqamForm.Properties.Resources.backphoto;
            this.Controls.Add(this.Title);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.Title;
            this.Name = "DarAlArqam";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DarAlArqam_Load);
            this.BackgroundImageLayoutChanged += new System.EventHandler(this.DarAlArqam_BackgroundImageLayoutChanged);
            this.Title.ResumeLayout(false);
            this.Title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Title;
        private System.Windows.Forms.ToolStripMenuItem الفصولToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافهToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem حذففصلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الفروعToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذففرعToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem القرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافهقريهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفقريهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الخزنهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الايراداتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المصروفاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem توريددعمخارجيToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اجماليالايراداتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دفعرواتبالعمالToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دفعفواتيرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem جماليالمصروفاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الموظفينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بياناتالمواظفينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المدرسينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بياناتالمرسToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الموادToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دفعرواتبالمدرسينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المستويToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem القواعدالقبولToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الطلابToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافةطالبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفوتعديلالطالبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem عرضالمستوياتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem1;
    }
}