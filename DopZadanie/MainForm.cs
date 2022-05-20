using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DopZadanie
{
    public partial class MainForm : Form
    {  
        public MainForm()
        {
         
            InitializeComponent();
        }

        private void StudentsTree(string filename, int i)
        {
            StreamReader sr = File.OpenText(filename);

            while (true)
            {
                string s = sr.ReadLine();
                if (s == null)
                    break;
                else
                {
                    string student = s.Split(',').First();
                    studentstree.Nodes[i].Nodes.Add(student);
                }


            }
            sr.Close();
        }
        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsTree("students(09-121).txt", 0);
            StudentsTree("students(09-122).txt",1);
        }

        int n = 0;
        private void пикчаToolStripMenuItem_Click(object sender, EventArgs e)
        {
                List<Image> images = new List<Image>();
                images.Add(Image.FromFile("ещесобака.jpg"));
                images.Add(Image.FromFile("кот(я).jpg"));
                images.Add(Image.FromFile("попугтатар.jpg"));
                images.Add(Image.FromFile("сосиска.jpg"));
                images.Add(Image.FromFile("собака.jpg"));
            if (n < 4)
            {
                n++;
                picturebox.Image = images[n];
            }
            else
            {
                n = 0;
                picturebox.Image = images[n];
            }
        }

        private void студентытеперьВТаблицеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table table = new table();
            table.ShowDialog();
        }
    }
}
