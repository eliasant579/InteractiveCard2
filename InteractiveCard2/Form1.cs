using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
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

            //new graphics, font, pen and brushes
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.White, 1);
            Font drawFont = new Font("Arial", 14);
            SolidBrush drawBrushWhite = new SolidBrush(Color.White);
            SolidBrush drawBrushRed = new SolidBrush(Color.Red);

            //audio
            SoundPlayer playerJungle = new SoundPlayer(Properties.Resources.Jungle);
            SoundPlayer playerLion = new SoundPlayer(Properties.Resources.Lion_Roar);
            playerLion.Play();


            //click view
            g.Clear(Color.Black);
            g.DrawString("LION", drawFont, drawBrushWhite, 400, 50);

            playerJungle.Play();                            //Jungle sound playing

            //draw stars
            Thread.Sleep(1000);
            g.FillEllipse(drawBrushWhite, 180, 303, 3, 3);   //1
            Thread.Sleep(400);
            g.FillEllipse(drawBrushWhite, 302, 288, 5, 5);   //2
            Thread.Sleep(400);
            g.FillEllipse(drawBrushWhite, 525, 287, 7, 7);   //3 Regulus  
            Thread.Sleep(400);
            g.FillEllipse(drawBrushWhite, 514, 227, 3, 3);   //4
            Thread.Sleep(400);
            g.FillEllipse(drawBrushWhite, 294, 224, 5, 5);   //5
            Thread.Sleep(400);
            g.FillEllipse(drawBrushWhite, 469, 204, 3, 3);   //6
            Thread.Sleep(400);
            g.FillEllipse(drawBrushWhite, 467, 159, 3, 3);   //7
            Thread.Sleep(400);
            g.FillEllipse(drawBrushWhite, 517, 125, 3, 3);   //8
            Thread.Sleep(400);
            g.FillEllipse(drawBrushWhite, 543, 151, 3, 3);   //9
            Thread.Sleep(400);

            //draw lines
            g.DrawLine(drawPen, 182, 304, 302, 289);    //1 to 2
            Thread.Sleep(400);
            g.DrawLine(drawPen, 182, 303, 294, 227);    //2 to 5
            g.DrawLine(drawPen, 543, 151, 519, 127);    //9 to 8
            Thread.Sleep(400);
            g.DrawLine(drawPen, 516, 127, 468, 160);    //8 to 7
            g.DrawLine(drawPen, 527, 287, 516, 229);    //3 to 4
            Thread.Sleep(400);
            g.DrawLine(drawPen, 306, 289, 525, 289);    //2 to 3
            Thread.Sleep(400);
            g.DrawLine(drawPen, 470, 203, 469, 160);    //6 to 7
            Thread.Sleep(300);
            g.DrawLine(drawPen, 472, 205, 514, 227);    //6 to 4
            Thread.Sleep(300);
            g.DrawLine(drawPen, 468, 206, 297, 226);    //6 to 5

            Thread.Sleep(600);

            //redraw stars in red, bigger
            g.FillEllipse(drawBrushRed, 179, 303, 5, 5);   //1
            g.FillEllipse(drawBrushRed, 301, 288, 7, 7);   //2
            g.FillEllipse(drawBrushRed, 524, 287, 9, 9);   //3 Regulus  
            g.FillEllipse(drawBrushRed, 513, 227, 5, 5);   //4
            g.FillEllipse(drawBrushRed, 293, 224, 7, 7);   //5
            g.FillEllipse(drawBrushRed, 468, 204, 5, 5);   //6
            g.FillEllipse(drawBrushRed, 466, 159, 5, 5);   //7
            g.FillEllipse(drawBrushRed, 516, 125, 5, 5);   //8
            g.FillEllipse(drawBrushRed, 542, 151, 5, 5);   //9
            Thread.Sleep(500);

            playerLion.Play();

            Thread.Sleep(500);
            g.DrawString("Leo is one of the constellations of the zodiac.\n" +
                "Its name is Latin for lion, the one killed \n" +
                "by the mythical Greek hero Heracles.", drawFont, drawBrushRed, 30, 70);

        }
    }
}
