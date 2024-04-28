using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMine
{
    public partial class pergunta1 : UserControl
    {
        public pergunta1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnTesla.BackColor = Color.LimeGreen;
            btnDrac.BackColor = Color.Red;
            btnElon.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnTesla.BackColor = Color.LimeGreen;
            btnDrac.BackColor = Color.Red;
            btnElon.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnTesla.BackColor = Color.LimeGreen;
            btnDrac.BackColor = Color.Red;
            btnElon.BackColor = Color.Red;
        }

        private void pergunta1_Load(object sender, EventArgs e)
        {

        }
    }
}
