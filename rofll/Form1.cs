using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rofll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 20;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://i.ytimg.com/vi/SuqLRgpdvME/maxresdefault.jpg");
            this.Visible = false;
            this.ShowInTaskbar = false;

            Thread.Sleep(1000);
        }
        static int speedAll = 130;
        int speedX = speedAll;
        int speedY = speedAll;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p1 = new Point(MousePosition.X + speedX, MousePosition.Y + speedY);
            Cursor.Position = p1;
            if (MousePosition.X >= 1919)
            {
                speedX = -speedAll;

            }
            if (MousePosition.X <= 0)
            {
                speedX = +speedAll;
            }
            if (MousePosition.Y >= 1079)
            {
                speedY = -speedAll;
            }
            if (MousePosition.Y <= 0)
            {
                speedY = +speedAll;
            }
        }
    }
}
