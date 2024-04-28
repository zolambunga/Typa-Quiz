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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScrn());
        }
        //private void audio (){ 
        //SoundPlayer Timing = new SoundPlayer(@"Sounds\Timing.wav");
        //SoundPlayer Errado = new SoundPlayer(@"Sounds\wrong.wav");
        //SoundPlayer Correto = new SoundPlayer(@"Sounds\right.wav");
        //SoundPlayer Click = new SoundPlayer(@"Sounds\click.wav");
        //}
    }
}
