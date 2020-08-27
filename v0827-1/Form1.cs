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
        int vx1 = rand.Next(-7, 8);
        int vy1 = rand.Next(-7, 8);
        int vx2 = rand.Next(-7, 8);
        int vy2 = rand.Next(-7, 8);
        int itime = 0;
        public Form1()
        {
            InitializeComponent();
            
            label1.Left = rand.Next(ClientSize.Width-label1.Width);
            label1.Top = rand.Next(ClientSize.Height-label1.Height);
            label4.Left = rand.Next(ClientSize.Width - label1.Width);
            label4.Top = rand.Next(ClientSize.Height - label1.Height);
            label5.Left = rand.Next(ClientSize.Width - label1.Width);
            label5.Top = rand.Next(ClientSize.Height - label1.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point mp = MousePosition;
            mp = PointToClient(mp);
            label1.Left += vx;
            label1.Top += vy;
            label4.Left += vx1;
            label4.Top += vy1;
            label5.Left += vx2;
            label5.Top += vy2;
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

            if (label4.Left < 0)
            {
                vx1 = Math.Abs(vx1);
            }
            if (label4.Top < 0)
            {
                vy1 = Math.Abs(vy1);
            }
            if (label4.Right > ClientSize.Width)
            {
                vx1 = -Math.Abs(vx1);
            }
            if (label4.Bottom > ClientSize.Height)
            {
                vy1 = -Math.Abs(vy1);
            }

            if (label5.Left < 0)
            {
                vx2 = Math.Abs(vx2);
            }
            if (label5.Top < 0)
            {
                vy2 = Math.Abs(vy2);
            }
            if (label5.Right > ClientSize.Width)
            {
                vx2 = -Math.Abs(vx2);
            }
            if (label5.Bottom > ClientSize.Height)
            {
                vy2 = -Math.Abs(vy2);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
