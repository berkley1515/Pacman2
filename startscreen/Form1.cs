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
            SoundPlayer pickleRick = new SoundPlayer(Properties.Resources.Im_Pickle_Rick_);
            //countdown sound
            SoundPlayer beep = new SoundPlayer(Properties.Resources.beep_02);

            //graphics settings
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
            Font drawFont = new Font("Impact", 41, FontStyle.Bold);
            SolidBrush drawBrushFont = new SolidBrush(Color.Red);
            


            startbutton.Visible = false;
            beep.Play();
            counter.Visible = false;
            this.BackColor = Color.Black;
            counter.Text = "Go!";
            Refresh();
            Thread.Sleep(1000);

            Pen linePen = new Pen(Color.Blue, 10);
            formGraphics.Clear(Color.Black);
            formGraphics.DrawLine(linePen, 0, 5, 277, 5);
            formGraphics.DrawLine(linePen, 0, 75, 225, 75);
            formGraphics.DrawLine(linePen, 272, 5, 272, 250);
            formGraphics.DrawLine(linePen, 222, 75, 222, 250);
            //test
           
        }
    }
}
