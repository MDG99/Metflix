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
    public partial class MetflixInicio : Form
    {
        public Usuario UsuarioActual { get; }
        private SQLiteConn conn = new SQLiteConn("Metflix.db", true);

        public MetflixInicio(Usuario usuario)
        {
            UsuarioActual = usuario;
            InitializeComponent();
        }

        private void MetflixInicio_Load(object sender, EventArgs e)
        {
            Items();
            if(flowLayoutPanel1.Controls.Count == 0)
            {
                NoResultados.Enabled = true;
            }
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
                if (conn.avgcalificacion(PeliculasVistas[i].Codigo) != -1)
                    listItem[i].Calificacion = $"Calificación: {conn.avgcalificacion(PeliculasVistas[i].Codigo)}/5";
                else listItem[i].Calificacion = "Película no calificada aún";
                listItem[i].Duracion = $"{PeliculasVistas[i].Duracion} min";
                listItem[i].Genero = PeliculasVistas[i].Genero;
                listItem[i].Year = $"{PeliculasVistas[i].Year}";
                listItem[i].PortadaLocation = PeliculasVistas[i].Imagen;
                listItem[i].Portada();
                listItem[i].Sinopsis = PeliculasVistas[i].Sinopsis;

                //Agegando el nuevo item a la pantalla

                flowLayoutPanel1.Controls.Add(listItem[i]);

            }

        }

    }
}
