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
    public partial class Opiniones : UserControl
    {
        public Opiniones()
        {
            InitializeComponent();
        }

       public string Usuario
        {
            get { return labelUsuario.Text; }
            set { labelUsuario.Text = value; }
        }

       public string Puntaje
        {
            get { return labelPuntaje.Text; }
            set { labelPuntaje.Text = value; }
        } 

       public string Descripcion
        {
            get { return txtOpinion.Text; }
            set { txtOpinion.Text = value; }
        }

    }
}
