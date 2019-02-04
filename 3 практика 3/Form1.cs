using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_практика_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void облакаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("C:\\Users\\studkab43\\Desktop\\Новая папка (2)\\облака.jpg");
        }

        private void лесToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("C:\\Users\\studkab43\\Desktop\\Новая папка (2)\\лес.jpg");
        }

        private void полеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("C:\\Users\\studkab43\\Desktop\\Новая папка (2)\\поле.jpg");
        }

        private void снегToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("C:\\Users\\studkab43\\Desktop\\Новая папка (2)\\снег.jpg");
        }

        private void птицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("C:\\Users\\studkab43\\Desktop\\Новая папка (2)\\птица.jpg");
        }

        private void дождьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("C:\\Users\\studkab43\\Desktop\\Новая папка (2)\\дождь.jpg");
        }

        private void машинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("C:\\Users\\studkab43\\Desktop\\Новая папка (2)\\машина.jpg");
        }

        private void рычковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("C:\\Users\\studkab43\\Desktop\\Новая папка (2)\\рычков.jpg");
        }

        private void облакаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("C:\\Users\\studkab43\\Desktop\\Новая папка (2)\\облака.jpg");
        }

        private void лесToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("C:\\Users\\studkab43\\Desktop\\Новая папка (2)\\лес.jpg");
        }
    }
}
