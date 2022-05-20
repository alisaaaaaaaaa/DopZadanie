
namespace DopZadanie
{
    partial class table
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
            this.studenttable = new System.Windows.Forms.DataGridView();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studenttable)).BeginInit();
            this.SuspendLayout();
            // 
            // studenttable
            // 
            this.studenttable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studenttable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SName,
            this.Sername,
            this.Bday});
            this.studenttable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studenttable.Location = new System.Drawing.Point(0, 0);
            this.studenttable.Name = "studenttable";
            this.studenttable.Size = new System.Drawing.Size(800, 450);
            this.studenttable.TabIndex = 0;
            // 
            // SName
            // 
            this.SName.HeaderText = "Фамилия";
            this.SName.Name = "SName";
            this.SName.Width = 200;
            // 
            // Sername
            // 
            this.Sername.HeaderText = "Имя";
            this.Sername.Name = "Sername";
            this.Sername.Width = 200;
            // 
            // Bday
            // 
            this.Bday.HeaderText = "Дата рождения";
            this.Bday.Name = "Bday";
            // 
            // table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studenttable);
            this.Name = "table";
            this.Text = "Таблица студентов";
            ((System.ComponentModel.ISupportInitialize)(this.studenttable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studenttable;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sername;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bday;
    }
}