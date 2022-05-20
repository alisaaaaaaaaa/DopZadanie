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
    public partial class table : Form
    {
        public table()
        {
            InitializeComponent();
            StudentTable("students(09-121).txt");
            StudentTable("students(09-122).txt");
        }
        private void StudentTable(string filename)
        {
            StreamReader sr = File.OpenText(filename);

            while (true)
            {
                string s = sr.ReadLine();
                if (s == null)
                    break;
                else
                {
                    string name = s.Split(' ').First();
                    string sur = s.Split(',').First();
                    string surname = sur.Split(' ').Last();
                    string bday = s.Split(',').Last();
                    studenttable.Rows.Add(name, surname, bday);
                }


            }
            sr.Close();
        }
    }
}
