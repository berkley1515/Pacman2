using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;




namespace startscreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            //sounds
            SoundPlayer pacmanchomp = new SoundPlayer(Properties.Resources.pacman_chomp);
            SoundPlayer start = new SoundPlayer(Properties.Resources.pacman_beginning);

            //graphics settings
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
            Font drawFont = new Font("Impact", 30, FontStyle.Bold);
            SolidBrush drawBrushFont = new SolidBrush(Color.Red);
            Pen PacmanAPen = new Pen(Color.Yellow); //pacman draw (yellow)
            SolidBrush PacmanABrush = new SolidBrush(Color.Yellow);
            Pen PacmanBPen = new Pen(Color.Black); //pacman erase (black)
            SolidBrush PacmanBBrush = new SolidBrush(Color.Black);

            //sounds
            start.PlaySync();
            pacmanchomp.PlayLooping();

            //blue lines (map)
            Pen linePen = new Pen(Color.Blue, 10);
            formGraphics.Clear(Color.Black);
            formGraphics.DrawLine(linePen, 0, 5, 300, 5);
            formGraphics.DrawLine(linePen, 0, 75, 225, 75);
            formGraphics.DrawLine(linePen, 300, 5, 300, 250);
            formGraphics.DrawLine(linePen, 222, 75, 222, 250);

            //pacman graphics
            formGraphics.DrawPie(PacmanAPen, 10, 20, 50, 50, 30, 300);
            formGraphics.FillPie(PacmanABrush, 10, 20, 50, 50, 30, 300);
            Thread.Sleep(160);
            formGraphics.DrawPie(PacmanBPen, 10, 20, 50, 50, 30, 300);
            formGraphics.FillPie(PacmanBBrush, 10, 20, 50, 50, 30 , 300);

            formGraphics.DrawEllipse(PacmanAPen, 70, 20, 50, 50);
            formGraphics.FillEllipse(PacmanABrush, 70, 20, 50, 50);
            Thread.Sleep(160);
            formGraphics.DrawEllipse(PacmanBPen, 70, 20, 50, 50);
            formGraphics.FillEllipse(PacmanBBrush, 70, 20, 50, 50);

            formGraphics.DrawPie(PacmanAPen, 70, 20, 50, 50, 30, 300);
            formGraphics.FillPie(PacmanABrush, 70, 20, 50, 50, 30, 300);
            Thread.Sleep(160);
            formGraphics.DrawPie(PacmanBPen, 70, 20, 50, 50, 30, 300);
            formGraphics.FillPie(PacmanBBrush, 70, 20, 50, 50, 30, 300);

            formGraphics.DrawEllipse(PacmanAPen, 130, 20, 50, 50);
            formGraphics.FillEllipse(PacmanABrush, 130, 20, 50, 50);
            Thread.Sleep(160);
            formGraphics.DrawEllipse(PacmanBPen, 130, 20, 50, 50);
            formGraphics.FillEllipse(PacmanBBrush, 130, 20, 50, 50);

            formGraphics.DrawPie(PacmanAPen, 130, 20, 50, 50, 30, 300);
            formGraphics.FillPie(PacmanABrush, 130, 20, 50, 50, 30, 300);
            Thread.Sleep(160);
            formGraphics.DrawPie(PacmanBPen, 130, 20, 50, 50, 30, 300);
            formGraphics.FillPie(PacmanBBrush, 130, 20, 50, 50, 30, 300);

            formGraphics.DrawEllipse(PacmanAPen, 190, 20, 50, 50);
            formGraphics.FillEllipse(PacmanABrush, 190, 20, 50, 50);
            Thread.Sleep(160);
            formGraphics.DrawEllipse(PacmanBPen, 190, 20, 50, 50);
            formGraphics.FillEllipse(PacmanBBrush, 190, 20, 50, 50);

            formGraphics.DrawPie(PacmanAPen, 190, 20, 50, 50, 30, 300);
            formGraphics.FillPie(PacmanABrush, 190, 20, 50, 50, 30, 300);
            Thread.Sleep(160);
            formGraphics.DrawPie(PacmanBPen, 190, 20, 50, 50, 30, 300);
            formGraphics.FillPie(PacmanBBrush, 190, 20, 50, 50, 30, 300);

            formGraphics.DrawEllipse(PacmanAPen, 240, 20, 50, 50);
            formGraphics.FillEllipse(PacmanABrush, 240, 20, 50, 50);
            Thread.Sleep(160);
            formGraphics.DrawEllipse(PacmanBPen, 240, 20, 50, 50);
            formGraphics.FillEllipse(PacmanBBrush, 240, 20, 50, 50);

            formGraphics.DrawPie(PacmanAPen, 240, 20, 50, 50, 30, 300);
            formGraphics.FillPie(PacmanABrush, 240, 20, 50, 50, 30, 300);
            Thread.Sleep(160);
            formGraphics.DrawPie(PacmanBPen, 240, 20, 50, 50, 30, 300);
            formGraphics.FillPie(PacmanBBrush, 240, 20, 50, 50, 30, 300);

            formGraphics.DrawEllipse(PacmanAPen, 240, 80, 50, 50);
            formGraphics.FillEllipse(PacmanABrush, 240, 80, 50, 50);
            Thread.Sleep(160);
            formGraphics.DrawEllipse(PacmanBPen, 240, 80, 50, 50);
            formGraphics.FillEllipse(PacmanBBrush, 240, 80, 50, 50);

            formGraphics.DrawPie(PacmanAPen, 240, 80, 50, 50, 120, 300);
            formGraphics.FillPie(PacmanABrush, 240, 80, 50, 50, 120, 300);
            Thread.Sleep(160);
            formGraphics.DrawPie(PacmanBPen, 240, 80, 50, 50, 120, 300);
            formGraphics.FillPie(PacmanBBrush, 240, 80, 50, 50, 120, 300);

            formGraphics.DrawEllipse(PacmanAPen, 240, 140, 50, 50);
            formGraphics.FillEllipse(PacmanABrush, 240, 140, 50, 50);
            Thread.Sleep(160);
            formGraphics.DrawEllipse(PacmanBPen, 240, 140, 50, 50);
            formGraphics.FillEllipse(PacmanBBrush, 240, 140, 50, 50);

            formGraphics.DrawPie(PacmanAPen, 240, 140, 50, 50, 120, 300);
            formGraphics.FillPie(PacmanABrush, 240, 140, 50, 50, 120, 300);
            Thread.Sleep(160);
            formGraphics.DrawPie(PacmanBPen, 240, 140, 50, 50, 120, 300);
            formGraphics.FillPie(PacmanBBrush, 240, 140, 50, 50, 120, 300);

            formGraphics.DrawEllipse(PacmanAPen, 240, 200, 50, 50);
            formGraphics.FillEllipse(PacmanABrush, 240, 200, 50, 50);
            Thread.Sleep(160);
            formGraphics.DrawEllipse(PacmanBPen, 240, 200, 50, 50);
            formGraphics.FillEllipse(PacmanBBrush, 240, 200, 50, 50);

            formGraphics.DrawPie(PacmanAPen, 240, 200, 50, 50, 120, 300);
            formGraphics.FillPie(PacmanABrush, 240, 200, 50, 50, 120, 300);
            Thread.Sleep(160);
            formGraphics.DrawPie(PacmanBPen, 240, 200, 50, 50, 120, 300);
            formGraphics.FillPie(PacmanBBrush, 240, 200, 50, 50, 120, 300);

            Thread.Sleep(200);
            pacmanchomp.Stop();
            formGraphics.DrawString("Congratulations!", drawFont, drawBrushFont, 360, 20);
            Thread.Sleep(1500);

        }
    }
}
