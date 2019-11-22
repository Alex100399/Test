namespace WindowsFormsЭл.Журнал
{
    partial class TeacherUpdate
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСтудентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преподавателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПреподавателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитПреподавателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПреподавателейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентыToolStripMenuItem,
            this.преподавателиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 97;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСтудентаToolStripMenuItem,
            this.изменитьСтудентаToolStripMenuItem,
            this.списокСтудентовToolStripMenuItem});
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.студентыToolStripMenuItem.Text = "Студенты";
            // 
            // добавитьСтудентаToolStripMenuItem
            // 
            this.добавитьСтудентаToolStripMenuItem.Name = "добавитьСтудентаToolStripMenuItem";
            this.добавитьСтудентаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьСтудентаToolStripMenuItem.Text = "Добавить студента";
            this.добавитьСтудентаToolStripMenuItem.Click += new System.EventHandler(this.добавитьСтудентаToolStripMenuItem_Click);
            // 
            // изменитьСтудентаToolStripMenuItem
            // 
            this.изменитьСтудентаToolStripMenuItem.Name = "изменитьСтудентаToolStripMenuItem";
            this.изменитьСтудентаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.изменитьСтудентаToolStripMenuItem.Text = "Изменить студента";
            this.изменитьСтудентаToolStripMenuItem.Click += new System.EventHandler(this.изменитьСтудентаToolStripMenuItem_Click);
            // 
            // списокСтудентовToolStripMenuItem
            // 
            this.списокСтудентовToolStripMenuItem.Name = "списокСтудентовToolStripMenuItem";
            this.списокСтудентовToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.списокСтудентовToolStripMenuItem.Text = "Список студентов";
            // 
            // преподавателиToolStripMenuItem
            // 
            this.преподавателиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПреподавателяToolStripMenuItem,
            this.изменитПреподавателяToolStripMenuItem,
            this.списокПреподавателейToolStripMenuItem});
            this.преподавателиToolStripMenuItem.Name = "преподавателиToolStripMenuItem";
            this.преподавателиToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.преподавателиToolStripMenuItem.Text = "Преподаватели";
            // 
            // добавитьПреподавателяToolStripMenuItem
            // 
            this.добавитьПреподавателяToolStripMenuItem.Name = "добавитьПреподавателяToolStripMenuItem";
            this.добавитьПреподавателяToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.добавитьПреподавателяToolStripMenuItem.Text = "Добавить преподавателя";
            this.добавитьПреподавателяToolStripMenuItem.Click += new System.EventHandler(this.добавитьПреподавателяToolStripMenuItem_Click);
            // 
            // изменитПреподавателяToolStripMenuItem
            // 
            this.изменитПреподавателяToolStripMenuItem.Name = "изменитПреподавателяToolStripMenuItem";
            this.изменитПреподавателяToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.изменитПреподавателяToolStripMenuItem.Text = "Изменит преподавателя";
            this.изменитПреподавателяToolStripMenuItem.Click += new System.EventHandler(this.изменитПреподавателяToolStripMenuItem_Click);
            // 
            // списокПреподавателейToolStripMenuItem
            // 
            this.списокПреподавателейToolStripMenuItem.Name = "списокПреподавателейToolStripMenuItem";
            this.списокПреподавателейToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.списокПреподавателейToolStripMenuItem.Text = "Список преподавателей";
            // 
            // TeacherUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TeacherUpdate";
            this.Text = "TeacherUpdate";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтудентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьСтудентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСтудентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem преподавателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПреподавателяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитПреподавателяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПреподавателейToolStripMenuItem;
    }
}