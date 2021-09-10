using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawer
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen = new Pen(Color.Red)
        {
            Width = 5
        };
        bool draw = false;

        int x, y;

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
            y = -1;
            x = -1;
        }

        void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            y = e.Y;
            x = e.X;
        }

        void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }
    }
}
