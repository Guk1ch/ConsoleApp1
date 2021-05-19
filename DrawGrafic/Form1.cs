using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawGrafic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var paper = panel2.CreateGraphics();
            var pen = new Pen(Color.ForestGreen, 10);
            paper.DrawEllipse(pen, 160, 160, 80, 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var paper = panel2.CreateGraphics();
            var pen = new Pen(Color.DarkCyan, 10);
            paper.DrawLine(pen, 60, 60, 80, 100);
            paper.DrawLine(pen, 80, 100, 20, 30);
            paper.DrawLine(pen, 20, 30, 60, 60);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var paper = panel2.CreateGraphics();
            var pen = new Pen(Color.Red, 10);
            paper.DrawLine(pen, 60, 60, 80, 100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var paper = panel2.CreateGraphics();
            var pen = new Pen(Color.Black, 10);
            paper.DrawRectangle(pen, 100, 100, 100, 100);

        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            var paper = panel2.CreateGraphics();
            var pen = new Pen(Color.Red, 10);
            paper.DrawRectangle(pen, e.X, e.Y, 100, 100);
        }
    }
}
