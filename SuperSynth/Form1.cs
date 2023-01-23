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
        System.Windows.Media.MediaPlayer as2Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer as3Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer cs1Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer cs2Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer ds1Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer ds2Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer fs1Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer fs2Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer gs1Sound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer gs2Sound = new System.Windows.Media.MediaPlayer();


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
            as2Sound.Open(new Uri(Application.StartupPath + "/Resources/as4.wav"));
            as3Sound.Open(new Uri(Application.StartupPath + "/Resources/as5.wav"));
            cs1Sound.Open(new Uri(Application.StartupPath + "/Resources/cs3.wav"));
            cs2Sound.Open(new Uri(Application.StartupPath + "/Resources/cs4.wav"));
            ds1Sound.Open(new Uri(Application.StartupPath + "/Resources/ds3.wav"));
            ds2Sound.Open(new Uri(Application.StartupPath + "/Resources/ds4.wav"));
            fs1Sound.Open(new Uri(Application.StartupPath + "/Resources/fs3.wav"));
            fs2Sound.Open(new Uri(Application.StartupPath + "/Resources/fs4.wav"));
            gs1Sound.Open(new Uri(Application.StartupPath + "/Resources/gs3.wav"));
            gs2Sound.Open(new Uri(Application.StartupPath + "/Resources/gs4.wav"));
        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

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

        private void c1SKey_Click(object sender, EventArgs e)
        {
            cs1Sound.Stop();
            cs1Sound.Play();
        }

        private void d1SKey_Click(object sender, EventArgs e)
        {
            ds1Sound.Stop();
            ds1Sound.Play();
        }

        private void f1SKey_Click(object sender, EventArgs e)
        {
            fs1Sound.Stop();
            fs1Sound.Play();
        }

        private void g1SKey_Click(object sender, EventArgs e)
        {
            gs1Sound.Stop();
            gs1Sound.Play();
        }

        private void a2SKey_Click(object sender, EventArgs e)
        {
            as2Sound.Stop();
            as2Sound.Play();
        }

        private void c2SKey_Click(object sender, EventArgs e)
        {
            cs2Sound.Stop();
            cs2Sound.Play();
        }

        private void d2SKey_Click(object sender, EventArgs e)
        {
            ds2Sound.Stop();
            ds2Sound.Play();
        }

        private void f2SKey_Click(object sender, EventArgs e)
        {
            fs2Sound.Stop();
            fs2Sound.Play();
        }

        private void g2SKey_Click(object sender, EventArgs e)
        {
            gs2Sound.Stop();
            gs2Sound.Play();
        }

        private void a3SKey_Click(object sender, EventArgs e)
        {
            as3Sound.Stop();
            as3Sound.Play();
        }
    }
}
    

