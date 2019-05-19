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
    public partial class Metflix : Form
    {
        public Usuario UsuarioActual { get; }
        private SQLiteConn conn = new SQLiteConn("Metflix.db", true);

        public Metflix(Usuario usuarioActual)
        {
            UsuarioActual = usuarioActual;
            InitializeComponent();
            lstbPeliculasVistas.DisplayMember = "Titulo";
            lstbPeliculasVistas.DataSource = conn.GetPeliculasVistas(UsuarioActual.Id);
        }

        private void lstbPeliculasVistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbPortada.Visible = true;
            //pbPortada.ImageLocation = (lstbPeliculasVistas.SelectedValue as Pelicula).Imagen; 
            pbPortada.ImageLocation = "C:\\Users\\Sandra\\source\\repos\\Metflix\\Imágenes\\Portadas\\250x300\\It.jpg";
            TituloPeliculas.Text = (lstbPeliculasVistas.SelectedValue as Pelicula).Titulo;
            txtDuracion.Text = $"{(lstbPeliculasVistas.SelectedValue as Pelicula).Duracion} min.";
            txtGenero.Text = $"{(lstbPeliculasVistas.SelectedValue as Pelicula).Genero}";
            txtYear.Text = $"{(lstbPeliculasVistas.SelectedValue as Pelicula).Year}";
            txtSinopsis.Text = $"{(lstbPeliculasVistas.SelectedValue as Pelicula).Sinopsis}";
        }
    }
}
