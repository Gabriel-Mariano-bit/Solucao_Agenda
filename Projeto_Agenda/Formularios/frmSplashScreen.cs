using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Agenda.Formularios;

namespace Projeto_Agenda
{
    public partial class frmSplashScreen : Form
    {
        SoundPlayer meuPlayer = new SoundPlayer(@"C:\Users\mathe\Downloads\2-Minute-Timer-Relaxing-Music-Lofi-Fish-Background.wav");

        public frmSplashScreen()
        {
            InitializeComponent();
            meuPlayer.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 2;
            if (panel2.Width >= 800)
            {
                timer1.Stop();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                meuPlayer.Stop();
                this.Hide();

            }
        }
    }
}
