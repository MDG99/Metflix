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
            DateTime Hoy = DateTime.Today;

            if (membresia) membresia_id = 0; //basica
            else membresia_id = 1; //premium

            if (duracion == "Rbtm1Mes")
            {
                Hoy.AddMonths(1);
            }
            if (duracion == "Rbtm3Meses")
            {
                Hoy.AddMonths(3);
            }
            if (duracion == "Rbtm6Meses")
            {
                Hoy.AddMonths(6);
            }
            if (duracion == "Rbtm9Meses")
            {
                Hoy.AddMonths(9);
            }
            if (duracion == "Rbtm1Year")
            {
                Hoy.AddMonths(12);
            }


            using (SQLiteRecordSet rs = ExecuteQuery($"INSERT INTO usuarios(id, name, lastname, username, password, " +
                $"membresia_id, expiracion) VALUES ({GetUsuarios().Count()}, '{name}', '{lastname}', '{username}', '{password}'," +
                $"'{membresia_id}','{Hoy.ToString("yyyy-MM-dd")}')")) { }
        }

        public List<Pelicula> GetPeliculasVistas (int UsuarioId)
        {
            List<Pelicula> PeliculasVistas = new List<Pelicula>();

            using (SQLiteRecordSet rs2 = ExecuteQuery($"SELECT pv.codigo AS codigo, pv.titulo AS titulo, pv.sinopsis AS sinopsis, " +
                $"g.descripcion AS genero, pv.clasificacion AS clasificacion, " +
                $"pv.duracion AS duracion, pv.imagen AS imagen, pv.year AS year " +
                $"FROM generos g " +
                $"INNER JOIN(" +
                $"      SELECT p.codigo AS codigo, p.titulo AS titulo, p.sinopsis AS sinopsis, " +
                $"      p.genero_id AS genero_id, p.clasificacion AS clasificacion, " +
                $"      p.duracion AS duracion, p.imagen AS imagen, p.year AS year " +
                $"      FROM peliculas p " +
                $"      INNER JOIN( " +
                $"              SELECT * FROM registro_peliculas rs WHERE rs.usuario_id = {UsuarioId}" +
                $"              ) rs ON(rs.pelicula_codigo = p.codigo)" +
                $"      ) pv ON(pv.genero_id = g.id)"))
            {
                while (rs2.NextRecord())
                {
                    PeliculasVistas.Add(new Pelicula(rs2.GetInt32("codigo"),
                        rs2.GetString("titulo"),
                        rs2.GetString("genero"),
                        rs2.GetInt32("year"),
                        rs2.GetString("sinopsis"),
                        rs2.GetString("clasificacion"),
                        rs2.GetInt32("duracion"),
                        rs2.GetString("imagen")));
                }
            }
            return PeliculasVistas;
        }


    }


}