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

namespace Lab1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string answer = textBox1.Text;

            if (answer == "")
            {
                MessageBox.Show("Введіть відповідь!");
                return;
            }

            string path = "answers.txt";

            File.AppendAllText(path, answer + Environment.NewLine);

            MessageBox.Show("Відповідь збережено!");

            textBox1.Clear();
        }
    }
}
