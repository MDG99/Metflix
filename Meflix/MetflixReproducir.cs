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

        private SQLiteConn conn = new SQLiteConn("Metflix.db", true);
        int PeliId;
        int duracion;
        int ttranscurrido = 0;

        public MetflixReproducir(int id)
        {
            PeliId = id;
            InitializeComponent();

            duracion = conn.GetPeliculas().Find(P => P.Codigo == PeliId).Duracion;

            timer1.Interval = duracion * 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ttranscurrido += timer1.Interval;

            progressBar1.Increment(1);
            label1.Text = $"Minuto {ttranscurrido}";
            label2.Text = $"{duracion - ttranscurrido} minutos restantes";
        }

        private void bttnstop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void bttnplay_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            timer1.Start();
            bttnplay.Enabled = false;
            bttnplay.Visible = false;
            bttnpause.Enabled = true;
            bttnpause.Visible = true;
        }

        private void bttnpause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            bttnpause.Enabled = false;
            bttnpause.Visible = false;
            bttnplay.Enabled = true;
            bttnplay.Visible = true;
        }
    }
}
