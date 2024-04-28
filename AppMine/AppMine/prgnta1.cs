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
    
    public partial class prgnta1 : Form
    {
        SoundPlayer Timing = new SoundPlayer(@"Sounds\Timing.wav");
        SoundPlayer Errado = new SoundPlayer(@"Sounds\wrong.wav");
        SoundPlayer Correto = new SoundPlayer(@"Sounds\right.wav");
        SoundPlayer Click = new SoundPlayer(@"Sounds\click.wav");
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
        public static prgnta1 P1;
        public prgnta1()
        {
            InitializeComponent();
            P1 = this;
            //this.WindowState = FormWindowState.Normal;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            //if (this.WindowState == FormWindowState.Normal)
            //{
            //    Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            //}
            //else
            //{
            //    Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));
            //}
        }

        private void prgnta1_Load(object sender, EventArgs e)
        {
            this.WindowState = (index.AA.WindowState);
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
              //\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\/\
             //I PRETEND TO MAKE IT RECEIVE RESPONSE FROM TIMER1 TICKER, SO IT CAN HAVE ITS DATA FOR THIS CONDITION\\
            //\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//||\\
            if ((seconds <= 10) && (seconds > 0))
            {
                Timing.Play();
                /* if (seconds==0)
                 {
                     Timing.Stop();
                 }*/
            }
        }
        private void btnElon_Click(object sender, EventArgs e)
        {
            Click.Play();
            Errado.Play();
            timer1.Enabled = false;
            btnTesla.BackColor = Color.LimeGreen;
            btnDrac.BackColor = Color.Red;
            btnElon.BackColor = Color.Red;
            timer2.Enabled = true;
        }

        private void btnDrac_Click(object sender, EventArgs e)
        {
            Click.Play();
            Errado.Play();
            timer1.Enabled = false;
            btnTesla.BackColor = Color.LimeGreen;
            btnDrac.BackColor = Color.Red;
            btnElon.BackColor = Color.Red;
            timer2.Enabled = true;
        }

        private void btnTesla_Click(object sender, EventArgs e)
        {
            Click.Play();
            Correto.Play();
            timer1.Enabled = false;
            btnTesla.BackColor = Color.LimeGreen;
            btnDrac.BackColor = Color.Red;
            btnElon.BackColor = Color.Red;
            timer2.Enabled = true;
            //prgnta2 P2 = new prgnta2();
            //P2.Show(); this.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Click.Play();
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            Click.Play();
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false; btnMin.Location = btnMax.Location;
            btnMin.Visible = true;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            Click.Play();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            Click.Play();
            this.WindowState = FormWindowState.Normal;
            btnMax.Visible = true; btnMin.Location = btnMax.Location;
            btnMin.Visible = false;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
        }

        private void rtrn2_Click(object sender, EventArgs e)
        {
            Click.Play();
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
                //PictureBox.pcture2.Visible = false;
            }
            AA.Show(); this.Close();
            //////////\\\\\\\\////////\\\\\\///////////\\\\\\\\\////////\\\\\\\\\\////////////\\\\\\
           //<<//TINHA O PROBLEMA DA "prgnta1" NÃO VOLTAR PARA O "index" COM O TAMANHO DE ANTES!!\\>>\\
           //\\\\\\\///////\\\\\\\\\\\\\\//////////\\\\\\\\\\\\\\///////////\\\\\\\\\\///////\\\/////
        }
        int secondsforbuttonclick=10;
        private void timer2_Tick(object sender, EventArgs e)
        {
            centesimos = centesimos + 1;
            //label1.Text = Convert.ToString(centesimos);
            if (centesimos == 5)
            {
                centesimos = 0;
                secondsforbuttonclick -= 5;
                if (secondsforbuttonclick == 0)
                {
                    timer2.Enabled = false;
                    prgnta2 P2 = new prgnta2();
                    P2.Show(); this.Visible = false;
                }
                //\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\/\
                //PROBLEM WITH THE VALUE OF THE CIRCULARPROGRESSBAR1 NO MORE!\\
                //\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\
                //if ((circularProgressBar1.Value) == 100)
                //    {
                //    }
            }
        }
        int seconds = 20,centesimos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //circularProgressBar1.Value = 0;
            //label1.Text = Convert.ToString("");
            centesimos = centesimos + 1;
            //label1.Text = Convert.ToString(centesimos);
            if (centesimos==7)
            {
                centesimos = 0;
                if (circularProgressBar1.Value == 1)
                {
                    circularProgressBar1.Value += 4;
                }
                if ((circularProgressBar1.Value>1)&&(circularProgressBar1.Value < 100))
                {
                circularProgressBar1.Value += 5;
                }
                //label1.Text = Convert.ToString(circularProgressBar1.Value);
                label1.Text = Convert.ToString(seconds);
                if (seconds<=10)
                {
                    Timing.Play();
                }
                if ((seconds==0)&& ((circularProgressBar1.Value) == 100))
                    {
                        timer1.Enabled = false;
                        Timing.Stop();
                        prgnta2 P2 = new prgnta2();
                        P2.Show(); this.Visible = false;
                    }
                seconds -= 1;
                    //\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\/\
                    //PROBLEM WITH THE VALUE OF THE CIRCULARPROGRESSBAR1 NO MORE!\\
                    //\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\
            //if ((circularProgressBar1.Value) == 100)
            //    {
            //    }
            }

        }
    }
}
