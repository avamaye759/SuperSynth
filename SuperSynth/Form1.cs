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

        class Program
        {
            
            static int noteDuration = 1000;
            static string notes;
            static string durations;
            static List<int> final_freqs;
            static List<int> final_durations;

            private void Form1_KeyDown(object sender, KeyEventArgs e)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        final_freqs.Add(262); //c1
                        break;
                    case Keys.Down:
                        final_freqs.Add(294); //d1
                        break;
                    case Keys.W:
                        wDown = true;
                        break;
                    case Keys.S:
                        sDown = true;
                        break;
                }
            }

            static void ParseStaff()
            {
                
                foreach (char note in notes)
                {
                    switch (note)
                    {
                        case 'c':
                            final_freqs.Add(262);
                            break;
                        case 'd':
                            final_freqs.Add(294);
                            break;
                        case 'e':
                            final_freqs.Add(330);
                            break;
                        case 'f':
                            final_freqs.Add(349);
                            break;
                        case 'g':
                            final_freqs.Add(392);
                            break;
                        case 'a':
                            final_freqs.Add(440);
                            break;
                        case 'b':
                            final_freqs.Add(493);
                            break;
                        default:
                            break;
                    }
                }
            }

            static void Play()
            {
                for (int i = 0; i < final_freqs.Count; i++)
                {
                    Console.Beep(final_freqs[i], final_durations[i]);
                }
            }

            static void Main(string[] args)
            {
                ParseStaff();
                Play();
            }
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
    }
}
