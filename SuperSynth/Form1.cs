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
        
            private void Form1_KeyDown(object sender, KeyEventArgs e)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        //c1
                        break;
                    case Keys.S:
                        //d1
                        break;
                    case Keys.D:
                        //e1
                        break;
                    case Keys.F:
                        //f1
                        break;
                    case Keys.G:
                        //g1
                        break;
                    case Keys.H:
                        //a2
                        break;
                    case Keys.J:
                        //b2
                        break;
                    case Keys.K:
                        //c2
                        break;
                    case Keys.L:
                        //d2
                        break;
                    case Keys.Z:
                        //e2
                        break;
                    case Keys.X:
                        //f2
                        break;
                    case Keys.C:
                        //g2
                        break;
                    case Keys.V:
                        //a3
                        break;
                    case Keys.B:
                        //b3
                        break;
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
