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
    public partial class MetflixPantallaPrincipal : Form
    {
        public Usuario UsuarioActual { get; }
        private SQLiteConn conn = new SQLiteConn("Metflix.db", true);
        bool Cerrar = true;

        public MetflixPantallaPrincipal(Usuario usuarioActual)
        {
            UsuarioActual = usuarioActual;
            InitializeComponent();

        }

        private void AbrirForma(object forma)
        {
            if (panelForms.Controls.Count > 0)
                panelForms.Controls.RemoveAt(0);
            Form form = forma as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelForms.Controls.Add(form);
            panelForms.Tag = form;
            form.Show();
        }

        private void MetflixPantallaPrincipal_Load(object sender, EventArgs e)
        {
            AbrirForma(new MetflixInicio(UsuarioActual));
        }

        private void btmCerrarSesion_Click(object sender, EventArgs e)
        {
            InicioSesión inicio = new InicioSesión();
            Cerrar = false;
            inicio.Show();
            Close();
        }

        private void btmInicio_Click(object sender, EventArgs e)
        {
            AbrirForma(new MetflixInicio(UsuarioActual));
        }

        private void btmPeliculas_Click(object sender, EventArgs e)
        {
            AbrirForma(new MetflixTodasLasPeliculas());
        }

        private void btmBuscar_Click(object sender, EventArgs e)
        {
            AbrirForma(new Busqueda(UsuarioActual));
        }

        private void MetflixPantallaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Cerrar)
            {
                Application.Exit();
            }
        }
    }
}
