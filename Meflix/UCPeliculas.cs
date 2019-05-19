using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meflix
{
    public partial class UCPeliculas : UserControl
    {
        public UCPeliculas()
        {
            InitializeComponent();
        }
        #region Propiedades

        public string PortadaLocation
        {
            get { return pbPortada.ImageLocation; }
            set { pbPortada.ImageLocation = value; }
        }

        public string Genero
        {
            get { return labelGenero.Text; }
            set { labelGenero.Text = value; }
        }

        public string Year
        {
            get { return labelYear.Text; }
            set { labelYear.Text = value; }
        }

        public string Titulo
        {
            get { return labelTitulo.Text; }
            set { labelTitulo.Text = value; }
        }

        public string Calificacion
        {
            get { return labelCalificacion.Text; }
            set { labelCalificacion.Text = value; }
        }

        public string Duracion
        {
            get { return labelDuracion.Text; }
            set { labelDuracion.Text = value; }
        }

        public string Sinopsis
        {
            get { return txtSinopsis.Text; }
            set { txtSinopsis.Text = value; }
        }

        #endregion

        public void Portada()
        {
            pbPortada.ImageLocation = PortadaLocation;
        }

    }
}
