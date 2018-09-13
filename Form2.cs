using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace seminar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label3.Visible = false;

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            Bounds = Screen.PrimaryScreen.Bounds;
        }

        Random r = new Random();
        int missed = 0;
        int shots = 0;
        int points = 0;

        void shot_sound()
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"H:\New folder\Sound.wav");
            sound.Play();
        }

        void reset()
        {
            missed = 0;
            shots = 0;
            points = 0;
            label1.Text = "Score: " + points;
            label2.Text = "Missed: " + missed;
            timer1.Start();
            label3.Visible = false;
        }

        void shot()
        {
            shots++;
            points=3*shots;
            label1.Text = "Score: " + points;
            shot_sound();
        }

        void missed_shot()
        {
            missed++;
            points--;
            label2.Text = "Missed: " + missed;
            label1.Text = "Score: " + points;
            shot_sound();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int fox_x, fox_y;
            fox_x = r.Next(50, 1050);
            fox_y = r.Next(380, 700);
            pictureBox1.Location = new Point(fox_x, fox_y);
            if(missed>=10)
            {
                timer1.Stop();
                label3.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(missed<10)
                shot();
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            if (missed < 10)
                missed_shot();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
