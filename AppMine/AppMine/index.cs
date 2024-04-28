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
using System.Media;

namespace AppMine
{

    public partial class index : Form
    {
        #region Cores do About
        //Color cl1 = Color.Blue, cl2 = Color.Orange;
        //public Color Color1
        //{
        //    get { return cl1; }
        //    set { cl1 = value; Invalidate(); }
        //}
        #endregion

        SoundPlayer BackgroundSound1 = new SoundPlayer(@"Sounds\timer.wav");
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
        public static index AA;
        /*public partial class Reguladores : PictureBox { }
        public static Reguladores pcture2,pcture3;*/
        public index()
        {
            InitializeComponent();
            //pcture2 = System.Windows.Forms.PictureBox;
            //pcture3 = ;
            AA = this;
            //Som.PlayLooping();
            if (this.WindowState == FormWindowState.Normal)
            {
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
                //pictureBox2.Visible = true; pictureBox3.Location = pictureBox2.Location;
                //pictureBox3.Visible = false;
            }
            if(this.WindowState==FormWindowState.Maximized)
            {
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));
                //pictureBox2.Visible = false; pictureBox3.Location = pictureBox2.Location;
                //pictureBox3.Visible = true;
            }
        }

        private void index_Load(object sender, EventArgs e)
        {
            //BackgroundSound1.PlayLooping();
            //if (this.WindowState == FormWindowState.Normal)
            //{
            //    pictureBox2.Visible = true; //pictureBox3.Location = pictureBox2.Location;
            //    pictureBox3.Visible = false;
            //}
            //if (this.WindowState == FormWindowState.Maximized)
            //{
            //    pictureBox2.Visible = false; //pictureBox3.Location = pictureBox2.Location;
            //    pictureBox3.Visible = true;
            //}
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Click.Play();
            this.Close();
            BackgroundSound1.Stop();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Click.Play();
            this.WindowState = FormWindowState.Normal;
            pictureBox3.Visible=false;
            //pictureBox2.Location = pictureBox3.Location;
            pictureBox2.Visible = true;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Click.Play();
            this.WindowState = FormWindowState.Maximized;
            pictureBox2.Visible = false;
            pictureBox3.Location = pictureBox2.Location;
            pictureBox3.Visible = true;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Click.Play();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Click.Play();
            pictureBox5.Visible = true;
            button1.Visible = false; button3.Location = button1.Location;
            button3.Visible = true;
            //index.BackgroundImage = AppMine.Properties.Resources.form2;
            if (pictureBox5.Visible == true)
            {
                pictureBox1.BackColor = Color.LightGray;
                pictureBox2.BackColor = Color.LightGray;
                pictureBox3.BackColor = Color.LightGray;
                pictureBox4.BackColor = Color.LightGray;
                button1.BackColor = Color.LightGray;
                button2.BackColor = Color.LightGray;
                button3.BackColor = Color.LightGray;
            } button3.Location = button1.Location;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Click.Play();
            button3.Visible = false; pictureBox5.Visible = false;
            button1.Visible = true;
            if (pictureBox5.Visible == false)
            {

                pictureBox1.BackColor = Color.Black;
                pictureBox2.BackColor = Color.Black;
                pictureBox3.BackColor = Color.Black;
                pictureBox4.BackColor = Color.Black;
                button1.BackColor = Color.Black;
                button2.BackColor = Color.Black;
                button3.BackColor = Color.Black;
            }
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //pictureBoxSair
            //
            Click.Play();
            Application.Exit(); BackgroundSound1.Stop();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Click.Play();
            BackgroundSound1.Stop();
            prgnta1 A = new prgnta1();
            A.Show(); this.Close();
            //pictureBoxjogar
            //panel1.Visible = true;            pergunta11.Visible = true;
            //btnTesla.Visible = true; btnDrac.Visible = true; btnElon.Visible = true;

        }

        private void btnElon_Click(object sender, EventArgs e)
        {
            //btnTesla.BackColor = Color.LimeGreen;
            //btnDrac.BackColor = Color.Red;
            //btnElon.BackColor = Color.Red;
        }

        private void btnDrac_Click(object sender, EventArgs e)
        {
            //btnTesla.BackColor = Color.LimeGreen;
            //btnDrac.BackColor = Color.Red;
            //btnElon.BackColor = Color.Red;
        }

        private void btnTesla_Click(object sender, EventArgs e)
        {
            //btnTesla.BackColor = Color.LimeGreen;
            //btnDrac.BackColor = Color.Red;
            //btnElon.BackColor = Color.Red;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            if ((pictureBox3.Visible == true))
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Color cl1 = Color.Blue, cl2 = Color.Orange;
            //public Color Color1
            //{
            //    get { return cl1; }
            //    set { cl1 = value; Invalidate(); }
            }
    }
}
