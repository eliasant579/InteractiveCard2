using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

/// <summary>
/// Elia Santagiuliana 21-09-18
/// 
/// I'm still working on this
/// </summary>
namespace InteractiveCard2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            g.DrawString("LION", drawFont, drawBrush, 400, 50);

            Thread.Sleep(300);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            Refresh();

            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.White, 1);
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            g.Clear(Color.Black);
            g.DrawString("LION", drawFont, drawBrush, 400, 50);

            Thread.Sleep(200);
            g.FillEllipse(drawBrush, 180, 303, 3, 3);   //1
            Thread.Sleep(200);
            g.FillEllipse(drawBrush, 302, 288, 3, 3);   //2
            Thread.Sleep(200);
            g.FillEllipse(drawBrush, 525, 287, 7, 7);   //3 Regulus  
            Thread.Sleep(200);
            g.FillEllipse(drawBrush, 514, 227, 3, 3);   //4
            Thread.Sleep(200);
            g.FillEllipse(drawBrush, 294, 224, 5, 5);   //5
            Thread.Sleep(200);
            g.FillEllipse(drawBrush, 469, 204, 3, 3);   //6
            Thread.Sleep(200);
            g.FillEllipse(drawBrush, 467, 159, 3, 3);   //7
            Thread.Sleep(200);
            g.FillEllipse(drawBrush, 517, 125, 3, 3);   //8
            Thread.Sleep(200);
            g.FillEllipse(drawBrush, 544, 151, 3, 3);   //9
            Thread.Sleep(200);

            g.DrawLine(drawPen, 183, 302, 302, 286);
            g.DrawLine(drawPen, 0, 0, 100, 100);
            g.DrawLine(drawPen, 0, 0, 100, 100);
            g.DrawLine(drawPen, 0, 0, 100, 100);
            g.DrawLine(drawPen, 0, 0, 100, 100);
            g.DrawLine(drawPen, 0, 0, 100, 100);
            g.DrawLine(drawPen, 0, 0, 100, 100);
            g.DrawLine(drawPen, 0, 0, 100, 100);
            g.DrawLine(drawPen, 0, 0, 100, 100);

        }
    }
}
