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
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();

            player.URL = "Animal_Crossing.mp3";

            this.FormBorderStyle = FormBorderStyle.None; //remove any border
            this.TopMost = true;                        //Bring the form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds;  //Make it fullscreen
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form3 form = new Form3(); 
            form.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form2 form = new Form2(); 
            form.ShowDialog();
            this.Show();
        }
    }
}
