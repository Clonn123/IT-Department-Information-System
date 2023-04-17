namespace TreeWithSQL
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeView = new System.Windows.Forms.TreeView();
            this.contextMenuStripTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.вывестиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьДеревоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьДеревоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьФакультетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripNodeJob = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripNodeDevice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКартриджToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьКартриджиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripNodeEmployee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStripTreeView.SuspendLayout();
            this.contextMenuStripNodeJob.SuspendLayout();
            this.contextMenuStripNodeDevice.SuspendLayout();
            this.contextMenuStripNodeEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.ContextMenuStrip = this.contextMenuStripTreeView;
            this.treeView.Location = new System.Drawing.Point(16, 47);
            this.treeView.Margin = new System.Windows.Forms.Padding(4);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(653, 608);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // contextMenuStripTreeView
            // 
            this.contextMenuStripTreeView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вывестиToolStripMenuItem,
            this.обновитьДеревоToolStripMenuItem,
            this.удалитьДеревоToolStripMenuItem,
            this.добавитьФакультетToolStripMenuItem});
            this.contextMenuStripTreeView.Name = "contextMenuStrip1";
            this.contextMenuStripTreeView.Size = new System.Drawing.Size(225, 100);
            // 
            // вывестиToolStripMenuItem
            // 
            this.вывестиToolStripMenuItem.Name = "вывестиToolStripMenuItem";
            this.вывестиToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.вывестиToolStripMenuItem.Text = "Вывести дерево";
            this.вывестиToolStripMenuItem.Click += new System.EventHandler(this.вывестиToolStripMenuItem_Click);
            // 
            // обновитьДеревоToolStripMenuItem
            // 
            this.обновитьДеревоToolStripMenuItem.Name = "обновитьДеревоToolStripMenuItem";
            this.обновитьДеревоToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.обновитьДеревоToolStripMenuItem.Text = "Обновить дерево";
            this.обновитьДеревоToolStripMenuItem.Click += new System.EventHandler(this.обновитьДеревоToolStripMenuItem_Click);
            // 
            // удалитьДеревоToolStripMenuItem
            // 
            this.удалитьДеревоToolStripMenuItem.Name = "удалитьДеревоToolStripMenuItem";
            this.удалитьДеревоToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.удалитьДеревоToolStripMenuItem.Text = "Удалить дерево";
            this.удалитьДеревоToolStripMenuItem.Click += new System.EventHandler(this.удалитьДеревоToolStripMenuItem_Click);
            // 
            // добавитьФакультетToolStripMenuItem
            // 
            this.добавитьФакультетToolStripMenuItem.Name = "добавитьФакультетToolStripMenuItem";
            this.добавитьФакультетToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.добавитьФакультетToolStripMenuItem.Text = "Добавить должность";
            this.добавитьФакультетToolStripMenuItem.Click += new System.EventHandler(this.добавитьФакультетToolStripMenuItem_Click);
            // 
            // contextMenuStripNodeJob
            // 
            this.contextMenuStripNodeJob.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripNodeJob.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.добавитьToolStripMenuItem});
            this.contextMenuStripNodeJob.Name = "contextMenuStrip2";
            this.contextMenuStripNodeJob.Size = new System.Drawing.Size(148, 76);
            this.contextMenuStripNodeJob.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripNodeFaculty_Opening);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // contextMenuStripNodeDevice
            // 
            this.contextMenuStripNodeDevice.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripNodeDevice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem1,
            this.изменитьToolStripMenuItem1,
            this.добавитьКартриджToolStripMenuItem,
            this.просмотретьКартриджиToolStripMenuItem});
            this.contextMenuStripNodeDevice.Name = "contextMenuStrip3";
            this.contextMenuStripNodeDevice.Size = new System.Drawing.Size(252, 100);
            this.contextMenuStripNodeDevice.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripNodeGroup_Opening);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(251, 24);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // изменитьToolStripMenuItem1
            // 
            this.изменитьToolStripMenuItem1.Name = "изменитьToolStripMenuItem1";
            this.изменитьToolStripMenuItem1.Size = new System.Drawing.Size(251, 24);
            this.изменитьToolStripMenuItem1.Text = "Изменить";
            this.изменитьToolStripMenuItem1.Click += new System.EventHandler(this.изменитьToolStripMenuItem1_Click);
            // 
            // добавитьКартриджToolStripMenuItem
            // 
            this.добавитьКартриджToolStripMenuItem.Name = "добавитьКартриджToolStripMenuItem";
            this.добавитьКартриджToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.добавитьКартриджToolStripMenuItem.Text = "Добавить картридж";
            this.добавитьКартриджToolStripMenuItem.Click += new System.EventHandler(this.добавитьКартриджToolStripMenuItem_Click);
            // 
            // просмотретьКартриджиToolStripMenuItem
            // 
            this.просмотретьКартриджиToolStripMenuItem.Name = "просмотретьКартриджиToolStripMenuItem";
            this.просмотретьКартриджиToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.просмотретьКартриджиToolStripMenuItem.Text = "Просмотреть картриджи";
            this.просмотретьКартриджиToolStripMenuItem.Click += new System.EventHandler(this.просмотретьКартриджиToolStripMenuItem_Click);
            // 
            // contextMenuStripNodeEmployee
            // 
            this.contextMenuStripNodeEmployee.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripNodeEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem2,
            this.изменитьToolStripMenuItem2,
            this.добавитьToolStripMenuItem1});
            this.contextMenuStripNodeEmployee.Name = "contextMenuStripNodeCourse";
            this.contextMenuStripNodeEmployee.Size = new System.Drawing.Size(148, 76);
            this.contextMenuStripNodeEmployee.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripNodeCourse_Opening);
            // 
            // удалитьToolStripMenuItem2
            // 
            this.удалитьToolStripMenuItem2.Name = "удалитьToolStripMenuItem2";
            this.удалитьToolStripMenuItem2.Size = new System.Drawing.Size(147, 24);
            this.удалитьToolStripMenuItem2.Text = "Удалить";
            this.удалитьToolStripMenuItem2.Click += new System.EventHandler(this.удалитьToolStripMenuItem2_Click);
            // 
            // изменитьToolStripMenuItem2
            // 
            this.изменитьToolStripMenuItem2.Name = "изменитьToolStripMenuItem2";
            this.изменитьToolStripMenuItem2.Size = new System.Drawing.Size(147, 24);
            this.изменитьToolStripMenuItem2.Text = "Изменить";
            this.изменитьToolStripMenuItem2.Click += new System.EventHandler(this.изменитьToolStripMenuItem2_Click);
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(147, 24);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Для начала работы, нажмите правой клавишей по окну ниже и выберите соответствующи" +
    "й пункт";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 667);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStripTreeView.ResumeLayout(false);
            this.contextMenuStripNodeJob.ResumeLayout(false);
            this.contextMenuStripNodeDevice.ResumeLayout(false);
            this.contextMenuStripNodeEmployee.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTreeView;
        private System.Windows.Forms.ToolStripMenuItem вывестиToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNodeJob;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNodeDevice;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem обновитьДеревоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьДеревоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьФакультетToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNodeEmployee;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьКартриджToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьКартриджиToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

