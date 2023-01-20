using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;
using System.IO;

namespace SuperSynth
{
    public partial class Form1 : Form
    {
        string power = "off";
        string drum = "off";

        System.Windows.Media.MediaPlayer c1Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer d1Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer e1Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer f1Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer g1Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer a2Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer b2Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer c2Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer d2Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer e2Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer f2Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer g2Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer a3Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer b3Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer as4Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer as5Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer cs3Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer cs4Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer ds3Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer ds4Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer fs3Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer fs4Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer gs3Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer gs4Sound = new System.Windows.Media.MediaPlayer();


        public Form1()
        {
            InitializeComponent();

            c1Sound.Open(new Uri(Application.StartupPath + "/Resources/c3.wav"));
            d1Sound.Open(new Uri(Application.StartupPath + "/Resources/d3.wav"));
            e1Sound.Open(new Uri(Application.StartupPath + "/Resources/e3.wav"));
            f1Sound.Open(new Uri(Application.StartupPath + "/Resources/f3.wav"));
            g1Sound.Open(new Uri(Application.StartupPath + "/Resources/g3.wav"));
            a2Sound.Open(new Uri(Application.StartupPath + "/Resources/a4.wav"));
            b2Sound.Open(new Uri(Application.StartupPath + "/Resources/b4.wav"));
            c2Sound.Open(new Uri(Application.StartupPath + "/Resources/c4.wav"));
            d2Sound.Open(new Uri(Application.StartupPath + "/Resources/d4.wav"));
            e2Sound.Open(new Uri(Application.StartupPath + "/Resources/e4.wav"));
            f2Sound.Open(new Uri(Application.StartupPath + "/Resources/f4.wav"));
            g2Sound.Open(new Uri(Application.StartupPath + "/Resources/g4.wav"));
            a3Sound.Open(new Uri(Application.StartupPath + "/Resources/a5.wav"));
            b3Sound.Open(new Uri(Application.StartupPath + "/Resources/b5.wav"));
        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    //c1
                    c1Sound.Stop();
                    c1Sound.Play();
                    break;
                case Keys.S:
                    //d1
                    d1Sound.Stop();
                    d1Sound.Play();
                    break;
                case Keys.D:
                    //e1
                    e1Sound.Stop();
                    e1Sound.Play();
                    break;
                case Keys.F:
                    //f1
                    f1Sound.Stop();
                    f1Sound.Play();
                    break;
                case Keys.G:
                    //g1
                    g1Sound.Stop();
                    g1Sound.Play();
                    break;
                case Keys.H:
                    //a2
                    a2Sound.Stop();
                    a2Sound.Play();
                    break;
                case Keys.J:
                    //b2
                    b2Sound.Stop();
                    b2Sound.Play();
                    break;
                case Keys.K:
                    //c2
                    c2Sound.Stop();
                    c2Sound.Play();
                    break;
                case Keys.L:
                    //d2
                    d2Sound.Stop();
                    d2Sound.Play();
                    break;
                case Keys.Z:
                    //e2
                    e2Sound.Stop();
                    e2Sound.Play();
                    break;
                case Keys.X:
                    //f2
                    f2Sound.Stop();
                    f2Sound.Play();
                    break;
                case Keys.C:
                    //g2
                    g2Sound.Stop();
                    g2Sound.Play();
                    break;
                case Keys.V:
                    //a3
                    a3Sound.Stop();
                    a3Sound.Play();
                    break;
                case Keys.B:
                    //b3
                    b3Sound.Stop();
                    b3Sound.Play();
                    break;
            }
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
          if (power == "off")
          {
              power = "on";
              powerLoop.Enabled = true;
              powerInd.BackColor = System.Drawing.Color.Red;
          }
          else if (power == "on")
          {
              power = "off";
              powerLoop.Enabled = false;
              powerInd.BackColor= System.Drawing.Color.Brown;
          }
        }

        private void powerLoop_Tick(object sender, EventArgs e)
        {

        }

        private void drumLoop_Tick(object sender, EventArgs e)
        {

        }

        private void drumButton_Click(object sender, EventArgs e)
        {
            if (power == "on" && drum == "off")
            {
                drum = "on";
                drumLoop.Enabled = true;
                drumInd.BackColor = System.Drawing.Color.Red;
            }
            else if (power == "on" && drum == "on")
            {
                drum = "off";
                drumLoop.Enabled = false;
                drumInd.BackColor= System.Drawing.Color.Brown;
            }
        }

        private void c1Key_Click(object sender, EventArgs e)
        {
            c1Sound.Stop();
            c1Sound.Play();
        }

        private void d1Key_Click(object sender, EventArgs e)
        {
            d1Sound.Stop();
            d1Sound.Play();
        }

        private void e1Key_Click(object sender, EventArgs e)
        {
            e1Sound.Stop();
            e1Sound.Play();
        }

        private void f1Key_Click(object sender, EventArgs e)
        {
            f1Sound.Stop();
            f1Sound.Play();
        }

        private void g1Key_Click(object sender, EventArgs e)
        {
            g1Sound.Stop();
            g1Sound.Play();
        }

        private void a2Key_Click(object sender, EventArgs e)
        {
            a2Sound.Stop();
            a2Sound.Play();
        }

        private void b2Key_Click(object sender, EventArgs e)
        {
            b2Sound.Stop();
            b2Sound.Play();
        }

        private void c2Key_Click(object sender, EventArgs e)
        {
            c2Sound.Stop();
            c2Sound.Play();
        }

        private void d2Key_Click(object sender, EventArgs e)
        {
            d2Sound.Stop();
            d2Sound.Play();
        }

        private void e2Key_Click(object sender, EventArgs e)
        {
            e2Sound.Stop();
            e2Sound.Play();
        }

        private void f2Key_Click(object sender, EventArgs e)
        {
            f2Sound.Stop();
            f2Sound.Play();
        }

        private void g2Key_Click(object sender, EventArgs e)
        {
            g2Sound.Stop();
            g2Sound.Play();
        }

        private void a3Key_Click(object sender, EventArgs e)
        {
            a3Sound.Stop();
            a3Sound.Play();
        }

        private void b3Key_Click(object sender, EventArgs e)
        {
            b3Sound.Stop();
            b3Sound.Play();
        }
    }
}
    

