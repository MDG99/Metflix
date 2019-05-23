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
    public partial class Busqueda : Form
    {
        SQLiteConn conn = new SQLiteConn("Metflix.db", true);
        Usuario u;

        public Busqueda(Usuario user)
        {
            u = user;
            InitializeComponent();
            if (u.MembresiaId != 1)
            {
                checkPremium.Visible = false;
                checkPremium.Enabled = false;
            }
        }

        public void MostrarPeliculas(Pelicula[] peliculasfiltradas)
        {
            UCPeliculas[] listItem = new UCPeliculas[peliculasfiltradas.Count()];


            for (int i = 0; i < listItem.Length; i++)
            {

                //Llenando cada item
                listItem[i] = new UCPeliculas();
                listItem[i].Titulo = peliculasfiltradas[i].Titulo;
                if (conn.avgcalificacion(peliculasfiltradas[i].Codigo) != -1)
                    listItem[i].Calificacion = $"Calificación: {conn.avgcalificacion(peliculasfiltradas[i].Codigo)}/5";
                else listItem[i].Calificacion = "Película no calificada aún";
                listItem[i].Duracion = $"{peliculasfiltradas[i].Duracion} min";
                listItem[i].Genero = peliculasfiltradas[i].Genero;
                listItem[i].Year = $"{peliculasfiltradas[i].Year}";
                listItem[i].PortadaLocation = peliculasfiltradas[i].Imagen;
                listItem[i].Portada();
                listItem[i].Sinopsis = peliculasfiltradas[i].Sinopsis;

                //Agegando el nuevo item a la pantalla

                flowLayoutPanel1.Controls.Add(listItem[i]);
                
            }
        }

        private void btmBuscar_Click_1(object sender, EventArgs e)
        {
            NoResultados.Visible = false;
            flowLayoutPanel1.Controls.Clear();

            List<Pelicula> peliculas = new List<Pelicula>(conn.GetPeliculas());
            foreach (var control in Controls)
            {
                if (control is TextBox)
                {
                    TextBox textbox = control as TextBox;
                    if (textbox.Text != "")
                    {
                        List<Pelicula> peliculasAux = new List<Pelicula>(peliculas);
                        foreach (Pelicula peli in peliculasAux)
                        {
                            if (peli.Titulo.Contains(txtPalabras.Text)==false)
                            {
                                peliculas.Remove(peli);
                            }
                        }
                    }
                }
                if (control is CheckBox)
                {
                    CheckBox check = control as CheckBox;
                    if (!check.Checked)
                    {
                        peliculas = peliculas.FindAll(p => p.Membresia == "Básica");
                    }
                }
                if (control is ComboBox)
                {
                    ComboBox combo = control as ComboBox;
                    if (combo.Name == "cmbYear")
                    {
                        if (cmbYear.Text != "  Año")
                        {
                            peliculas = peliculas.FindAll(y => y.Year == (int)cmbYear.SelectedValue);
                        }
                    }
                    if (combo.Name == "cmbClasificacion")
                    {
 
                        if (cmbClasificacion.Text != " Clasificación")
                        {
                            peliculas = peliculas.FindAll(c => c.Clasificacion == cmbClasificacion.Text);
                        }

                    }
                    if (combo.Name == "cmbGeneros")
                    {
                        if (combo.Text != "   Género")
                        {
                            peliculas = peliculas.FindAll(g => g.Genero == cmbGeneros.Text);
                        }
                    }
                }
                if (control is RadioButton)
                {
                    RadioButton rb = control as RadioButton;

                    if(rb.Checked && rb.Name == "rbtm1Estrella")
                        peliculas = conn.calificacionfiltro(1);

                    if (rb.Checked && rb.Name == "rbtm2Estrellas")
                        peliculas = conn.calificacionfiltro(2);

                    if (rb.Checked && rb.Name == "rbtm3Estrellas")
                        peliculas = conn.calificacionfiltro(3);

                    if (rb.Checked && rb.Name == "rbtm4Estrellas")
                        peliculas = conn.calificacionfiltro(4);

                    if (rb.Checked && rb.Name == "rbtm5Estrellas")
                        peliculas = conn.calificacionfiltro(5);
                }
            }

            if (peliculas.Count == 0)
                NoResultados.Visible = true;

            MostrarPeliculas(peliculas.ToArray());
        }

        private void btmLimpiar_Click_1(object sender, EventArgs e)
        {
            txtPalabras.Text = "";
            cmbGeneros.Text = "   Género";
            cmbClasificacion.Text = " Clasificación";
            cmbYear.Text = "  Año";
            checkPremium.Checked = false;
            rbtm1Estrella.Checked = false;
            rbtm2Estrellas.Checked = false;
            rbtm3Estrellas.Checked = false;
            rbtm4Estrellas.Checked = false;
            rbtm5Estrellas.Checked = false;
            flowLayoutPanel1.Controls.Clear();
            NoResultados.Visible = false;
        }

        private void cmbYear_Click_1(object sender, EventArgs e)
        {
            cmbYear.ValueMember = "year";
            cmbYear.DisplayMember = "year";
            cmbYear.DataSource = conn.Getyears();
        }

        private void cmbClasificacion_Click(object sender, EventArgs e)
        {
            cmbClasificacion.DisplayMember = "clasificacion";
            cmbClasificacion.DataSource = conn.GetClasificaciones();
        }

        private void cmbGeneros_Click(object sender, EventArgs e)
        {
            cmbGeneros.DisplayMember = "generos";
            cmbGeneros.DataSource = conn.GetGeneros();
        }
    }
}
