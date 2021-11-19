using System;
using System.Drawing;
using System.Threading;
using System.Windows;
using System.Windows.Forms;

namespace Flows
{
    public partial class Form1 : Form
    {
        int x1, x2, x3, x4, x5, x6, x7, y1, y2, y3, y4, y5, y6, y7;
        Thread f1, f2, f3, f4, f5, f6, f7;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MaximumSize = new Size(1280, 1024);
            MinimumSize = new Size(1280, 1024);
            BackColor = Color.Black;
            DoubleBuffered = true;
            g = CreateGraphics();
            f1 = new Thread(new ThreadStart(Run1));
            f1.Start();
            f2 = new Thread(new ThreadStart(Run2));
            f2.Start();
            f3 = new Thread(new ThreadStart(Run3));
            f3.Start();
            f4 = new Thread(new ThreadStart(Run4));
            f4.Start();
            f5 = new Thread(new ThreadStart(Run5));
            f5.Start();
            f6 = new Thread(new ThreadStart(Run6));
            f6.Start();
            f7 = new Thread(new ThreadStart(Run7));
            f7.Start();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.FillEllipse(Brushes.Yellow, Width / 2, Height / 2, Width * 6 / 100, Height * 7 / 100);
            g.FillEllipse(Brushes.Red, x1, y1, Width * 20 / 1000, Height * 25 / 1000);
            g.FillEllipse(Brushes.Orange, x2, y2, Width * 30 / 1000, Height * 35 / 1000);
            g.FillEllipse(Brushes.Blue, x3, y3, Width * 35 / 1000, Height * 40 / 1000);
            g.FillEllipse(Brushes.DarkOrange, x4, y4, Width * 30 / 1000, Height * 35 / 1000);
            g.FillEllipse(Brushes.Gold, x5, y5, Width * 50 / 1000, Height * 55 / 1000);
            g.FillEllipse(Brushes.Orange, x6, y6, Width * 30 / 1000, Height * 35 / 1000);
            g.FillEllipse(Brushes.Cyan, x7, y7, Width * 30 / 1000, Height * 35 / 1000);
        }
        public void Run1()
        {
            double f = 1.0;
            x1 = Width / 3;
            y1 = Height / 3;
            while (true)
            {
                x1 = (int)(Width / 2 + 100 * Math.Sin(ToRadians(f)));
                y1 = (int)(Height / 2 + 100 * Math.Cos(ToRadians(f)));
                f++;
                Invalidate();
                Thread.Sleep(25);
            }
        }
        public void Run2()
        {
            double f = 1.5;
            x2 = Width / 4;
            y2 = Height / 4;
            while (true)
            {
                x2 = (int)(Width / 2 + 150 * Math.Sin(ToRadians(f)));
                y2 = (int)(Height / 2 + 150 * Math.Cos(ToRadians(f)));
                f += 1.1;
                Invalidate();
                Thread.Sleep(25);
            }
        }
        public void Run3()
        {
            double f = 3.0;
            x3 = Width / 3;
            y3 = Height / 3;
            while (true)
            {
                x3 = (int)(Width / 2 + 200 * Math.Sin(ToRadians(f)));
                y3 = (int)(Height / 2 + 200 * Math.Cos(ToRadians(f)));
                f += 0.2;
                Invalidate();
                Thread.Sleep(25);
            }
        }
        public void Run4()
        {
            double f = 1.0;
            x4 = Width / 3;
            y4 = Height / 3;
            while (true)
            {
                x4 = (int)(Width / 2 + 250 * Math.Sin(ToRadians(f)));
                y4 = (int)(Height / 2 + 250 * Math.Cos(ToRadians(f)));
                f += 0.4;
                Invalidate();
                Thread.Sleep(25);
            }
        }
        public void Run5()
        {
            double f = 2.0;
            x5 = Width / 3;
            y5 = Height / 3;
            while (true)
            {
                x5 = (int)(Width / 2 + 300 * Math.Sin(ToRadians(f)));
                y5 = (int)(Height / 2 + 300 * Math.Cos(ToRadians(f)));
                f += 0.5;
                Invalidate();
                Thread.Sleep(25);
            }
        }
        public void Run6()
        {
            double f = 2.5;
            x6 = Width / 3;
            y6 = Height / 3;
            while (true)
            {
                x6 = (int)(Width / 2 + 350 * Math.Sin(ToRadians(f)));
                y6 = (int)(Height / 2 + 350 * Math.Cos(ToRadians(f)));
                f += 0.6;
                Invalidate();
                Thread.Sleep(25);
            }
        }
        public void Run7()
        {
            double f = 3.5;
            x7 = Width / 3;
            y7 = Height / 3;
            while (true)
            {
                x7 = (int)(Width / 2 + 400 * Math.Sin(ToRadians(f)));
                y7 = (int)(Height / 2 + 400 * Math.Cos(ToRadians(f)));
                f += 0.7;
                Invalidate();
                Thread.Sleep(25);
            }
        }
        static double ToRadians(double degs)
        {
            return degs / 180.0 * Math.PI;
        }
    }
}