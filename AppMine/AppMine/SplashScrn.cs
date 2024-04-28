using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AppMine
{
    public partial class SplashScrn : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
       (
int nLeftRect,
int nTopRect,
int nRightRect,
int nBottomRect,
int nWidthEllipse,
int nHeightEllipse
       );
        public SplashScrn()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void SplashScrn_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //progressBar1.Value = 1;
            if (progressBar1.Value < 50)
            {
                progressBar1.Value += 2;
            }
            if ((progressBar1.Value >= 50)){
                progressBar1.Value += 5;
            }
            if ((progressBar1.Value == 100))
            {
                timer1.Enabled = false;
                //this.Close();
                index frl = new index();
                frl.Show(); this.Visible = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
         if (this.Opacity < 1.0)
         {
             this.Opacity += 0.1;
         }
         else
         {
             timer2.Enabled=false;
         }
        }
    }
  }
