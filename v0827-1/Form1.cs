using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0827_1
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();
        int vx = rand.Next(-7, 8);
        int vy = rand.Next(-7, 8);
        int itime = 0;
        public Form1()
        {
            InitializeComponent();
            
            label1.Left = rand.Next(ClientSize.Width-label1.Width);
            label1.Top = rand.Next(ClientSize.Height-label1.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point mp = MousePosition;
            mp = PointToClient(mp);
            label1.Left += vx;
            label1.Top += vy;
            label2.Text = "" + mp.X + "," + mp.Y;
            itime += 1;
            label3.Text = "score:" + itime;
            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }
            if ((label1.Left <= mp.X) && (label1.Right > mp.X) && (label1.Top <= mp.Y) && (label1.Bottom > mp.Y))
            {
                timer1.Enabled=false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Left = 0;
            label3.Top = ClientSize.Height - label3.Height;
            label2.Left = 0;
            label2.Top = ClientSize.Height - label2.Height - label3.Height;
        }
    }
}
