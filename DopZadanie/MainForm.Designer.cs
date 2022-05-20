
namespace DopZadanie
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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("09-121");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("09-122");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пикчаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентытеперьВТаблицеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lowerSC = new System.Windows.Forms.SplitContainer();
            this.upperSC = new System.Windows.Forms.SplitContainer();
            this.studentstree = new System.Windows.Forms.TreeView();
            this.logs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowerSC)).BeginInit();
            this.lowerSC.Panel1.SuspendLayout();
            this.lowerSC.Panel2.SuspendLayout();
            this.lowerSC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperSC)).BeginInit();
            this.upperSC.Panel1.SuspendLayout();
            this.upperSC.Panel2.SuspendLayout();
            this.upperSC.SuspendLayout();
            this.logs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентыToolStripMenuItem,
            this.пикчаToolStripMenuItem,
            this.студентытеперьВТаблицеToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.студентыToolStripMenuItem.Text = "Студенты";
            this.студентыToolStripMenuItem.Click += new System.EventHandler(this.студентыToolStripMenuItem_Click);
            // 
            // пикчаToolStripMenuItem
            // 
            this.пикчаToolStripMenuItem.Name = "пикчаToolStripMenuItem";
            this.пикчаToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.пикчаToolStripMenuItem.Text = "Пикча";
            this.пикчаToolStripMenuItem.Click += new System.EventHandler(this.пикчаToolStripMenuItem_Click);
            // 
            // студентытеперьВТаблицеToolStripMenuItem
            // 
            this.студентытеперьВТаблицеToolStripMenuItem.Name = "студентытеперьВТаблицеToolStripMenuItem";
            this.студентытеперьВТаблицеToolStripMenuItem.Size = new System.Drawing.Size(173, 20);
            this.студентытеперьВТаблицеToolStripMenuItem.Text = "Студенты(теперь в таблице)";
            this.студентытеперьВТаблицеToolStripMenuItem.Click += new System.EventHandler(this.студентытеперьВТаблицеToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lowerSC
            // 
            this.lowerSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowerSC.Location = new System.Drawing.Point(0, 24);
            this.lowerSC.Name = "lowerSC";
            this.lowerSC.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // lowerSC.Panel1
            // 
            this.lowerSC.Panel1.Controls.Add(this.upperSC);
            // 
            // lowerSC.Panel2
            // 
            this.lowerSC.Panel2.Controls.Add(this.logs);
            this.lowerSC.Size = new System.Drawing.Size(800, 426);
            this.lowerSC.SplitterDistance = 249;
            this.lowerSC.TabIndex = 2;
            // 
            // upperSC
            // 
            this.upperSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperSC.Location = new System.Drawing.Point(0, 0);
            this.upperSC.Name = "upperSC";
            // 
            // upperSC.Panel1
            // 
            this.upperSC.Panel1.Controls.Add(this.studentstree);
            // 
            // upperSC.Panel2
            // 
            this.upperSC.Panel2.Controls.Add(this.picturebox);
            this.upperSC.Size = new System.Drawing.Size(800, 249);
            this.upperSC.SplitterDistance = 373;
            this.upperSC.TabIndex = 0;
            // 
            // studentstree
            // 
            this.studentstree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentstree.Location = new System.Drawing.Point(0, 0);
            this.studentstree.Name = "studentstree";
            treeNode5.Name = "09-121";
            treeNode5.Text = "09-121";
            treeNode6.Name = "09-122";
            treeNode6.Text = "09-122";
            this.studentstree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            this.studentstree.Size = new System.Drawing.Size(373, 249);
            this.studentstree.TabIndex = 0;
            // 
            // logs
            // 
            this.logs.Controls.Add(this.tabPage1);
            this.logs.Controls.Add(this.tabPage2);
            this.logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logs.Location = new System.Drawing.Point(0, 0);
            this.logs.Name = "logs";
            this.logs.SelectedIndex = 0;
            this.logs.Size = new System.Drawing.Size(800, 173);
            this.logs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 147);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 147);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "попугтатар.jpg");
            this.imageList.Images.SetKeyName(1, "собака.jpg");
            this.imageList.Images.SetKeyName(2, "сосиска.jpg");
            this.imageList.Images.SetKeyName(3, "кот(я).jpg");
            this.imageList.Images.SetKeyName(4, "ещесобака.jpg");
            // 
            // picturebox
            // 
            this.picturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturebox.Image = global::DopZadanie.Properties.Resources.собака;
            this.picturebox.Location = new System.Drawing.Point(0, 0);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(423, 249);
            this.picturebox.TabIndex = 0;
            this.picturebox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lowerSC);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "Приложуха";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.lowerSC.Panel1.ResumeLayout(false);
            this.lowerSC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lowerSC)).EndInit();
            this.lowerSC.ResumeLayout(false);
            this.upperSC.Panel1.ResumeLayout(false);
            this.upperSC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upperSC)).EndInit();
            this.upperSC.ResumeLayout(false);
            this.logs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пикчаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентытеперьВТаблицеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.SplitContainer lowerSC;
        private System.Windows.Forms.SplitContainer upperSC;
        private System.Windows.Forms.TreeView studentstree;
        private System.Windows.Forms.TabControl logs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.ImageList imageList;
    }
}

