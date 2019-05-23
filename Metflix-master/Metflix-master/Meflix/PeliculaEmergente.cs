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
    public partial class PeliculaEmergente : Form
    {
        private SQLiteConn conn = new SQLiteConn("Metflix.db", true);
        public PeliculaEmergente(Pelicula pelicula)
        {
            InitializeComponent();
            pbPortada.ImageLocation = pelicula.Imagen;
            labelTitulo.Text = pelicula.Titulo;
            labelGenero.Text = pelicula.Genero;
            labelClasificacion.Text = pelicula.Clasificacion;
            labelYear.Text = $"{pelicula.Year}";
            labelDuracion.Text = $"{pelicula.Duracion} min";
            if (conn.avgcalificacion(pelicula.Codigo) != -1)
                labelCalificacion.Text = $"Calificación: {conn.avgcalificacion(pelicula.Codigo)}/5";
            else labelCalificacion.Text = "Película no calificada aún";
            txtSinopsis.Text = pelicula.Sinopsis;
        }

        private void btmPlay_Click(object sender, EventArgs e)
        {

        }

        private void btmReanudarPlay_Click(object sender, EventArgs e)
        {

        }

        private void btmSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

