using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyLaserTurret
{
	public partial class main : Form
	{
		public Stopwatch watch { get; set; }

        bool portsExist = false;
        bool speedIncrease = false;
        bool speedDecrease = true;
        int speed = 50;

		public main()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			watch = Stopwatch.StartNew();
            try
            {
                port.Open();
                portsExist = true;
                labelConnectionStatus.Text = "Connected";
            }
            catch (Exception f)
            {
                portsExist = false;
                labelConnectionStatus.Text = "Not Connected";
            }
        }

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			writeToPort(new Point(e.X, e.Y));
		}

		public void writeToPort(Point coordinates)
		{
            if (watch.ElapsedMilliseconds > 15)
            {
                if (portsExist)
                {
                    try
                    {
                        watch = Stopwatch.StartNew();
                        port.Write(String.Format("X{0}Y{1}", (180 - coordinates.X / (Size.Width / 180)), (coordinates.Y / (Size.Height / 180))));
                    }
                    catch (Exception f)
                    {
                        portsExist = false;
                        labelConnectionStatus.Text = "Not Connected";
                    }
                }
                else if (!portsExist)
                {
                    try
                    {
                        port.Open();
                        portsExist = true;
                        labelConnectionStatus.Text = "Connected";
                    }
                    catch (Exception f)
                    {
                        portsExist = false;
                        labelConnectionStatus.Text = "Not Connected";
                    }
                }
            }
		}

        private void hScrollBarSpeed_Scroll(object sender, ScrollEventArgs e)
        {
            speed = Convert.ToInt32(hScrollBarSpeed.Value);
        }

        private void main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Q)
            {
                speedDecrease = true;
            }
            if (e.KeyData == Keys.E)
            {
                speedIncrease = true;
            }

            label1.Text = "pressed";
            label1.Refresh();
        }

        private void main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Q)
            {
                speedDecrease = false;
            }
            if (e.KeyData == Keys.E)
            {
                speedIncrease = false;
            }

            label1.Text = "up";
            label1.Refresh();
        }

        private void timer50ms_Tick(object sender, EventArgs e)
        {
            if (speedIncrease && !speedDecrease)
            {
                if (hScrollBarSpeed.Value < 100)
                {
                    speed += 1;
                    hScrollBarSpeed.Value += 1;
                    hScrollBarSpeed.Refresh();
                }
            }
            if (speedDecrease && !speedIncrease)
            {
                if (hScrollBarSpeed.Value > 0)
                {
                    speed -= 1;
                    hScrollBarSpeed.Value -= 1;
                    hScrollBarSpeed.Refresh();
                }
            }
        }
    }
}
