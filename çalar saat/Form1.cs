using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace çalar_saat
{
    public partial class Form1 : Form
    {
        //private System.Media.SoundPlayer mediasoundplayer= new System.Media.SoundPlayer();
        public bool a = true;
        public Form1()
        {
            InitializeComponent();
        }

        DateTime td=new DateTime();

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        public void saat()
        {
            //while (a)
            //{
            //    if ((td = DateTime.Now).ToString() == textBox1.Text + ":" + textBox2.Text + ":" + textBox3.Text + ": " + textBox4.Text + ":" + textBox5.Text + ":" + textBox6.Text)
            //    {
            //        //mediasoundplayer.Stream = Properties.Resources.Çiçek_Abbas;
            //        //mediasoundplayer.PlayLooping();
            //        string datapath = @"D:\eski\mp3\Orhan Gencebay - Leyla İle Mecnun\02.Orhan Gencebay - Kolay degil.mp3";
            //        axWindowsMediaPlayer1.settings.autoStart = true;
            //        //mediasoundplayer.SoundLocation = datapath;
            //        //mediasoundplayer.PlayLooping();
            //        axWindowsMediaPlayer1.URL = datapath;
            //        axWindowsMediaPlayer1.settings.playCount = Int32.Parse(textBox7.Text);

            //        a = false;
            //    }
            //}
        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    saat();
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((td = DateTime.Now).ToString() == "9/15/2007 1:58:28 AM")
                //textBox1.Text + "/" + textBox2.Text + "/" + textBox3.Text + " " + textBox4.Text + ":" + textBox5.Text + ":" + textBox6.Text)
            {
                //mediasoundplayer.Stream = Properties.Resources.Çiçek_Abbas;
                //mediasoundplayer.PlayLooping();
                string datapath = @"D:\mp3\Secret Love - nikos hatzopoulos.mp3";
                
                //mediasoundplayer.SoundLocation = datapath;
                //mediasoundplayer.PlayLooping();
                axWindowsMediaPlayer1.URL = datapath;
                axWindowsMediaPlayer1.settings.autoStart = true;
                axWindowsMediaPlayer1.settings.playCount = 2;
                timer1.Enabled = false;
                a = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            textBox1.Text = (td = DateTime.Now).ToString();
        }
    }
}