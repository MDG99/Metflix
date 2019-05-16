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

    public partial class InicioSesión : Form
    {
        private SQLiteConn conn;

        int ContadorContraseña = 0;
        int ContadorUsuario = 0;

        public InicioSesión()
        {
            InitializeComponent();
            conn = new SQLiteConn("Metflix.db", true);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (ContadorUsuario == 0)
            {
                txtUsuario.Clear();
            }
            ContadorUsuario++;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if(ContadorContraseña == 0)
            {
                txtContraseña.Clear();
            }
            txtContraseña.PasswordChar = '*';
            ContadorContraseña++;
        }

        private void btmIniciarSesión_Click(object sender, EventArgs e)
        {
            List<Usuario> Usuarios = new List<Usuario>();
            Usuarios = conn.GetUsuarios();
            if (Usuarios.Exists(U => U.UserName == txtUsuario.Text))
            {
                if (Usuarios.Find(C => C.UserName == txtUsuario.Text).Password == txtContraseña.Text)
                {
                    Usuario UsuarioActual = Usuarios.Find(C => C.UserName == txtUsuario.Text);
                    var resultadoCorrecto = MessageBox.Show("Logueado con Éxito",
                        "Inicio de sesión",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    var resultadoIncorrecto = MessageBox.Show("Usuario o contraseña incorrectos\nIntente de nuevo",
                        "Inicio de sesión",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    //Retornando al estado inicial a los campos de usuario y contraseña
                    txtContraseña.Text = "Contraseña";
                    ContadorContraseña = 0;
                    txtUsuario.Text = "Usuario";
                    ContadorUsuario = 0;
                }
            }
            else
            {
                var resultadoIncorrecto = MessageBox.Show("Usuario o contraseña incorrectos\nIntente de nuevo",
                    "Inicio de sesión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                //Retornando al estado inicial a los campos de usuario y contraseña
                txtContraseña.Text = "Contraseña";
                ContadorContraseña = 0;
                txtUsuario.Text = "Usuario";
                ContadorUsuario = 0;
            }
        }

        private void txtCrearCuenta_Click(object sender, EventArgs e)


















     
        {
            UsuarioAlta usuarioAlta = new UsuarioAlta();
            usuarioAlta.Show();
            Close();
        }
    }
}
