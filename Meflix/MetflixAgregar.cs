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
    public partial class MetflixAgregar : Form
    {

        private SQLiteConn conn = new SQLiteConn("Metflix.db", true);
        public MetflixAgregar()
        {
            InitializeComponent();
            Verificar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image imagen;

            saveFileDialog1.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagen = Image.FromFile(saveFileDialog1.FileName);
                imagen.Save(@"250x300\\" + saveFileDialog1.FileName);
            }
        }

        private void Verificar()
        {
            if(txtbxtitulo.Text == "" ||
               txtbxaño.Text == "" ||
               txtbxsinopsis.Text == "" ||
               txtbxduracion.Text == "" ||
               cmbxclasificacion.Text == "" ||
               cmbxgenero.Text == "" ||
               cmbxpremium.Text == "")
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string titulo = txtbxtitulo.Text;
            string sinopsis = txtbxsinopsis.Text;
            string clasificacion = cmbxclasificacion.Text;
            string generoid;
            generoid = conn.GetGenerosID().Find(G => G.Descripcion == cmbxgenero.Text).ID;
            int membresia_id;
            if (cmbxpremium.Text == "Premium")
            {
                membresia_id = 1;
            }
            else
            {
                membresia_id = 0;
            }
            int duracion = Convert.ToInt32(txtbxduracion.Text);
            int año = Convert.ToInt32(txtbxaño.Text);
            int codigo = conn.GetPeliculas().Count() + 1001;
            string imagen = $"250x300\\{saveFileDialog1.FileName}";

            conn.AddPelicula(codigo, titulo, generoid, año, sinopsis, imagen, clasificacion, duracion, membresia_id);
        }

        private void cmbxgenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbxgenero.DisplayMember = "generos";
            cmbxgenero.DataSource = conn.GetGeneros();
        }

        private void cmbxclasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbxclasificacion.DisplayMember = "clasificacion";
            cmbxclasificacion.DataSource = conn.GetClasificaciones();
        }

        private void cmbxpremium_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbxpremium.DisplayMember = "descripcion";
            cmbxpremium.DataSource = conn.GetMembresias();
        }
    }
}
