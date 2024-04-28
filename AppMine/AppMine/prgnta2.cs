using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;

namespace AppMine
{
    public partial class prgnta2 : Form     
    {
        SoundPlayer Timing = new SoundPlayer(@"Sounds\Timing.wav");
        SoundPlayer Errado = new SoundPlayer(@"Sounds\wrong.wav");
        SoundPlayer Correto = new SoundPlayer(@"Sounds\right.wav");
        SoundPlayer Click = new SoundPlayer(@"Sounds\click.wav");
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
   (
int nLeftRect,
int nRightRect,
int nTopRect,
int nBottomRect,
int nWidthEllipse,
int nHeightEllipse
   );
        public static prgnta2 P2;
        public prgnta2()
        {
            InitializeComponent();
            if (this.WindowState == FormWindowState.Normal)
            {
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            }
            else
            {
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false; btnMin.Location = btnMax.Location;
            btnMin.Visible = true;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMin.Visible = false; //btnMax.Location = btnMin.Location;
            btnMax.Visible = true;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0,Width,Height,25,25));
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rtrn2_Click(object sender, EventArgs e)
        {
            index AA = new index();
            //prgnta1 A = new prgnta1();
            (index.AA.WindowState) = (this.WindowState);
            if (this.WindowState == FormWindowState.Normal)
            {
                index.AA.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            }
            if (this.WindowState == FormWindowState.Maximized)
            {
                index.AA.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));
            }
            AA.Show(); this.Close();
        }

        private void prgnta2_Load(object sender, EventArgs e)
        {
            
            this.WindowState = (prgnta1.P1.WindowState);
            if (this.WindowState == FormWindowState.Normal)
            {
                btnMax.Visible = true; btnMin.Location = btnMax.Location;
                btnMin.Visible = false;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            }
            else
            {
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));
            }
            if (this.WindowState == FormWindowState.Maximized)
            {
                btnMax.Visible = false; btnMin.Location = btnMax.Location;
                btnMin.Visible = true;
            }
        }

        private void btnElon_Click(object sender, EventArgs e)
        {
            Click.Play();
            Errado.Play();
            btnAlbertEinstein.BackColor = Color.LimeGreen;
            btnIsaacAsimov.BackColor = Color.Red;
            btnBillGates.BackColor = Color.Red;
        }

        private void btnAlbertEinstein_Click(object sender, EventArgs e)
        {
            Click.Play();
            Correto.Play();
            btnAlbertEinstein.BackColor = Color.LimeGreen;
            btnIsaacAsimov.BackColor = Color.Red;
            btnBillGates.BackColor = Color.Red;
        }

        private void btnBillGates_Click(object sender, EventArgs e)
        {
            Click.Play();
            Errado.Play();
            btnAlbertEinstein.BackColor = Color.LimeGreen;
            btnIsaacAsimov.BackColor = Color.Red;
            btnBillGates.BackColor = Color.Red;
        }
    }
}
