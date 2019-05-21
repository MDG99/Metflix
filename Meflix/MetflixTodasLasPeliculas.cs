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
    public partial class MetflixTodasLasPeliculas : Form
    {
        private SQLiteConn conn = new SQLiteConn("Metflix.db", true);
        public MetflixTodasLasPeliculas()
        {
            InitializeComponent();
        }

        private void MetflixTodasLasPeliculas_Load(object sender, EventArgs e)
        {
            Items();
        }

        private void Items()
        {
            UCPeliculas[] listItem = new UCPeliculas[conn.GetPeliculas().Count()];
            Pelicula[] Peliculas;
            Peliculas = conn.GetPeliculas().ToArray();

            for (int i = 0; i < listItem.Length; i++)
            {

                //Llenando cada item
                listItem[i] = new UCPeliculas();
                listItem[i].Titulo = Peliculas[i].Titulo;
                //Agregr Calificación
                listItem[i].Duracion = $"{Peliculas[i].Duracion} min";
                listItem[i].Genero = Peliculas[i].Genero;
                listItem[i].Year = $"{Peliculas[i].Year}";
                listItem[i].PortadaLocation = Peliculas[i].Imagen;
                listItem[i].Portada();
                listItem[i].Sinopsis = Peliculas[i].Sinopsis;

                //Agegando el nuevo item a la pantalla

                flowLayoutPanel1.Controls.Add(listItem[i]);

            }

        }
    }
}
