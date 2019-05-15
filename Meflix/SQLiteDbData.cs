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
    }


}