using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Meflix;
using SQLiteDb;


namespace SQLiteDb
{
    public partial class SQLiteConn
    {
        public List<Usuario> GetUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (SQLiteRecordSet rs = ExecuteQuery("SELECT * FROM usuarios"))
            {
                while (rs.NextRecord())
                {
                    usuarios.Add(new Usuario(rs.GetInt32("id"),
                        rs.GetString("username"),
                        rs.GetString("password"),
                        rs.GetString("name"),
                        rs.GetString("lastname"),
                        rs.GetInt32("membresia_id")));
                }
            }
            return usuarios;
        }

        public void AddUser(string name, string lastname, string username, string password, bool membresia, string duracion)
        {
            int membresia_id;
            if (membresia) membresia_id = 0; //basica
            else membresia_id = 1; //premium

            //Agregar dos métodos, uno para calcular el tiempo de expiracion y otro para saber el tiempo que estas contratando
            //ver como guardar el tiempo

            using (SQLiteRecordSet rs = ExecuteQuery($"INSERT INTO usuarios(id, name, lastname, username, password, " +
                $"membresia_id) VALUES ({GetUsuarios().Count()}, '{name}', '{lastname}', '{username}', '{password}'," +
                $"'{membresia_id}')")) { }
        }
    }


}