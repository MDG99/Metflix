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

    public partial class UsuarioAlta : Form
    {
        private SQLiteConn conn;
        bool Cerrar = true;

        public UsuarioAlta()
        {
            InitializeComponent();
            conn = new SQLiteConn("Metflix.db", true);
        }

        private void btmCrear_Click(object sender, EventArgs e)
        {
            bool duracion = false;
            string Duracion = " ";
            foreach (Control control in panel1.Controls)
            {
                if(control is RadioButton)
                {
                    RadioButton radioButton = control as RadioButton;
                    if (radioButton.Checked)
                    {
                        duracion = true;
                        Duracion = radioButton.Name;
                    }
                }
            }
            if(txtNombre.Text == null || txtApellido.Text == null || txtUserName.Text == null ||
                txtPassword.Text == null || (RbtmBasico.Checked == false && RbtmPremium.Checked == false)||!duracion)
            {
                MessageBox.Show("Es necesario que rellene todos los campo" +
                    "\nPor favor, regresa y llena lo solicitado", "Creación de Usuario", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            else
            {
                List<Usuario> Usuarios = new List<Usuario>();
                Usuarios = conn.GetUsuarios();
                if ((Usuarios.Exists(N => N.Name == txtNombre.Text ) && Usuarios.Exists(A=> A.LastName == txtApellido.Text)) ||
                   Usuarios.Exists(U=> U.UserName == txtUserName.Text))
                {
                    MessageBox.Show("Ya existe un usuario registrado con esos datos",
                        "Creación de Usuario", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                }
                else
                {
                    Usuarios.Clear();
                    conn.AddUser(txtNombre.Text, txtApellido.Text, txtUserName.Text, txtPassword.Text, duracion, Duracion);
                    MessageBox.Show("Usuario creado con éxito",
                        "Creación de Usuario", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    InicioSesión inicio = new InicioSesión();
                    inicio.Show();
                    Cerrar = false;
                    Close();
                }
            }
        }

        private void UsuarioAlta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Cerrar)
                Application.Exit();
        }
    }
}
