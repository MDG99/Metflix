using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLiteDb;

namespace Meflix
{
    public partial class MetflixReproducir : Form
    {
        public MetflixReproducir()
        {
            InitializeComponent();
            //timer1.Interval = duracion * 1000;
        }

        private void bttnpp_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled is false)
            {
                bttnpp.Text = "Stop";
                //bttnpp.Image
                //pictureBox1.
                label2.Visible = true;
                timer1.Start();
            }
            else if (timer1.Enabled is true)
            {
                bttnpp.Text = "Play";
                //bttnpp.Image
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            label1.Text = $"Minuto {progressBar1.Value}";
            label2.Text = $"{100 - progressBar1.Value} minutos restantes";
        }

        private void bttnstop_Click(object sender, EventArgs e)
        {
            //progressBar1.Value = ;
            timer1.Stop();
        }
    }
}
