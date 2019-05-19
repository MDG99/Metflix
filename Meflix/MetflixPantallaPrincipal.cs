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
using System.Web.UI.Design.WebControls;

namespace Meflix
{
    public partial class MetflixPantallaPrincipal : Form
    {
        public Usuario UsuarioActual { get; }
        private SQLiteConn conn = new SQLiteConn("Metflix.db", true);

        public MetflixPantallaPrincipal(Usuario usuarioActual)
        {
            UsuarioActual = usuarioActual;
            InitializeComponent();

        }

        private void MetflixPantallaPrincipal_Load(object sender, EventArgs e)
        {
            Items();
        }

        private void Items()
        {
            UCPeliculas[] listItem = new UCPeliculas[conn.GetPeliculasVistas(UsuarioActual.Id).Count()];
            Pelicula[] PeliculasVistas;
            PeliculasVistas = conn.GetPeliculasVistas(UsuarioActual.Id).ToArray();

            for (int i = 0; i < listItem.Length; i++)
            {

                //Llenando cada item
                listItem[i] = new UCPeliculas();
                listItem[i].Titulo = PeliculasVistas[i].Titulo;
                //Agregr Calificación
                listItem[i].Duracion = $"{PeliculasVistas[i].Duracion} min";
                listItem[i].Genero = PeliculasVistas[i].Genero;
                listItem[i].Year = $"{PeliculasVistas[i].Year}";
                listItem[i].PortadaLocation =  PeliculasVistas[i].Imagen;
                listItem[i].Portada();
                listItem[i].Sinopsis = PeliculasVistas[i].Sinopsis;

                //Agegando el nuevo item a la pantalla

                flowLayoutPanel1.Controls.Add(listItem[i]);

            }

        } 

        private void btmCerrarSesion_Click(object sender, EventArgs e)
        {
            InicioSesión inicio = new InicioSesión();
            inicio.Show();
            Close();
        }


    }
}
