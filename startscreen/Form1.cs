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
            // SoundPlayer pickleRick = new SoundPlayer(Properties.Resources.Im_Pickle_Rick_);
            //countdown sound
            SoundPlayer beep = new SoundPlayer(Properties.Resources.beep_02);

            //graphics settings
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
            Font drawFont = new Font("Impact", 41, FontStyle.Bold);
            SolidBrush drawBrushFont = new SolidBrush(Color.Red);
            Pen PacmanAPen = new Pen(Color.Yellow); //pacman draw (yellow)
            SolidBrush PacmanABrush = new SolidBrush(Color.Yellow);
            Pen PacmanBPen = new Pen(Color.Black); //pacman erase (black)
            SolidBrush PacmanBBrush = new SolidBrush(Color.Black);

            //loading screen
            startbutton.Visible = false;
            beep.Play();
            counter.Visible = false;
            this.BackColor = Color.Black;
            counter.Text = "Go!";
            Refresh();
            Thread.Sleep(1000);

            //blue lines
            Pen linePen = new Pen(Color.Blue, 10);
            formGraphics.Clear(Color.Black);
            formGraphics.DrawLine(linePen, 0, 5, 300, 5);
            formGraphics.DrawLine(linePen, 0, 75, 225, 75);
            formGraphics.DrawLine(linePen, 300, 5, 300, 250);
            formGraphics.DrawLine(linePen, 222, 75, 222, 250);

            //pacman
            formGraphics.DrawPie(PacmanAPen, 20, 20, 50, 50, 30, 300);
            formGraphics.FillPie(PacmanABrush, 20, 20, 50, 50, 30, 300);
            Thread.Sleep(400);
            formGraphics.DrawPie(PacmanBPen, 20, 20, 50, 50, 30, 300);
            formGraphics.FillPie(PacmanBBrush, 20, 20, 50, 50, 30 , 300);

            formGraphics.DrawEllipse(PacmanAPen, 80, 20, 50, 50);
            formGraphics.FillEllipse(PacmanABrush, 80, 20, 50, 50);
            Thread.Sleep(400);
            formGraphics.DrawEllipse(PacmanBPen, 80, 20, 50, 50);
            formGraphics.FillEllipse(PacmanBBrush, 80, 20, 50, 50);

            formGraphics.DrawPie(PacmanAPen, 80, 20, 50, 50, 30, 300);
            formGraphics.FillPie(PacmanABrush, 80, 20, 50, 50, 30, 300);
            Thread.Sleep(400);
            formGraphics.DrawPie(PacmanBPen, 80, 20, 50, 50, 30, 300);
            formGraphics.FillPie(PacmanBBrush, 80, 20, 50, 50, 30, 300);

            formGraphics.DrawEllipse(PacmanAPen, 140, 20, 50, 50);
            formGraphics.FillEllipse(PacmanABrush, 140, 20, 50, 50);
            Thread.Sleep(400);
            formGraphics.DrawEllipse(PacmanBPen, 140, 20, 50, 50);
            formGraphics.FillEllipse(PacmanBBrush, 140, 20, 50, 50);

            formGraphics.DrawPie(PacmanAPen, 140, 20, 50, 50, 30, 300);
            formGraphics.FillPie(PacmanABrush, 140, 20, 50, 50, 30, 300);
            Thread.Sleep(400);
            formGraphics.DrawPie(PacmanBPen, 140, 20, 50, 50, 30, 300);
            formGraphics.FillPie(PacmanBBrush, 140, 20, 50, 50, 30, 300);




        }
    }
}
