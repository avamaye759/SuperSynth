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
        public Form1()
        {
            InitializeComponent();
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
          if (power == "off")
          {
              power = "on";
              powerLoop.Enabled = true;
              powerInd.BackColor = Color.Red;
          }
          else if (power == "on")
          {
              power = "off";
              powerLoop.Enabled = false;
              powerInd.BackColor= Color.Brown;
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
                drumInd.BackColor = Color.Red;
            }
            else if (power == "on" && drum == "on")
            {
                drum = "off";
                drumLoop.Enabled = false;
                drumInd.BackColor= Color.Brown;
            }
        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    //c1
                    var c1Sound = new System.Windows.Media.MediaPlayer();
                    c1Sound.Open(new Uri(Application.StartupPath + "/Resources/c3.mp3"));
                    c1Sound.Play();
                    break;
                case Keys.S:
                    //d1
                    var d1Sound = new System.Windows.Media.MediaPlayer();
                    d1Sound.Open(new Uri(Application.StartupPath + "/Resources/d3.mp3"));
                    d1Sound.Play();
                    break;
                case Keys.D:
                    //e1
                    var e1Sound = new System.Windows.Media.MediaPlayer();
                    e1Sound.Open(new Uri(Application.StartupPath + "/Resources/e3.mp3"));
                    e1Sound.Play();
                    break;
                case Keys.F:
                    //f1
                    var f1Sound = new System.Windows.Media.MediaPlayer();
                    f1Sound.Open(new Uri(Application.StartupPath + "/Resources/f3.mp3"));
                    f1Sound.Play();
                    break;
                case Keys.G:
                    //g1
                    var g1Sound = new System.Windows.Media.MediaPlayer();
                    g1Sound.Open(new Uri(Application.StartupPath + "/Resources/g3.mp3"));
                    g1Sound.Play();
                    break;
                case Keys.H:
                    //a2
                    var a2Sound = new System.Windows.Media.MediaPlayer();
                    a2Sound.Open(new Uri(Application.StartupPath + "/Resources/a4.mp3"));
                    a2Sound.Play();
                    break;
                case Keys.J:
                    //b2
                    var b2Sound = new System.Windows.Media.MediaPlayer();
                    b2Sound.Open(new Uri(Application.StartupPath + "/Resources/b4.mp3"));
                    b2Sound.Play();
                    break;
                case Keys.K:
                    //c2
                    var c2Sound = new System.Windows.Media.MediaPlayer();
                    c2Sound.Open(new Uri(Application.StartupPath + "/Resources/c4.mp3"));
                    c2Sound.Play();
                    break;
                case Keys.L:
                    //d2
                    var d2Sound = new System.Windows.Media.MediaPlayer();
                    d2Sound.Open(new Uri(Application.StartupPath + "/Resources/d4.mp3"));
                    d2Sound.Play();
                    break;
                case Keys.Z:
                    //e2
                    var e2Sound = new System.Windows.Media.MediaPlayer();
                    e2Sound.Open(new Uri(Application.StartupPath + "/Resources/e4.mp3"));
                    e2Sound.Play();
                    break;
                case Keys.X:
                    //f2
                    var f2Sound = new System.Windows.Media.MediaPlayer();
                    f2Sound.Open(new Uri(Application.StartupPath + "/Resources/f4.mp3"));
                    f2Sound.Play();
                    break;
                case Keys.C:
                    //g2
                    var g2Sound = new System.Windows.Media.MediaPlayer();
                    g2Sound.Open(new Uri(Application.StartupPath + "/Resources/g4.mp3"));
                    g2Sound.Play();
                    break;
                case Keys.V:
                    //a3
                    var a3Sound = new System.Windows.Media.MediaPlayer();
                    a3Sound.Open(new Uri(Application.StartupPath + "/Resources/a5.mp3"));
                    a3Sound.Play();
                    break;
                case Keys.B:
                    //b3
                    var b3Sound = new System.Windows.Media.MediaPlayer();
                    b3Sound.Open(new Uri(Application.StartupPath + "/Resources/b5.mp3"));
                    b3Sound.Play();
                    break;
            }
        }
    }
}
    

