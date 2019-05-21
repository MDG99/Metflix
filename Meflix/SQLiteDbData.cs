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

        public List<int> Getyears()
        {
            List<int> years = new List<int>();
            using (SQLiteRecordSet rs = ExecuteQuery("SELECT year FROM peliculas"))
            {
                while (rs.NextRecord())
                {
                    years.Add(rs.GetInt32("year"));
                }
            }
            return years;
        }

        public List<string> GetGeneros()
        {
            List<String> generos = new List<string>();
            using (SQLiteRecordSet rs = ExecuteQuery("SELECT descripcion FROM generos"))
            {
                while (rs.NextRecord())
                {
                    generos.Add(rs.GetString("descripcion"));
                }
            }
            return generos;
        }

        public List<string> GetClasificaciones()
        {
            List<String> clasificaciones = new List<string>();
            using (SQLiteRecordSet rs = ExecuteQuery("SELECT clasificacion FROM peliculas"))
            {
                while (rs.NextRecord())
                {
                    clasificaciones.Add(rs.GetString("clasificacion"));
                }
            }
            return clasificaciones;
        }

        public List<Pelicula> GetPeliculas()
        {
            List<Pelicula> Peliculas = new List<Pelicula>();

            using (SQLiteRecordSet rs2 = ExecuteQuery($"SELECT p.codigo AS codigo, p.titulo AS titulo, p.sinopsis AS sinopsis, " +
                $"p.genero AS genero, p.clasificacion AS clasificacion, " +
                $"p.duracion AS duracion, p.imagen AS imagen, p.year AS year, " +
                $"m.descripcion AS membresia " +
                $"FROM membresias m " +
                $"INNER JOIN( " +
                $"      SELECT pg.codigo AS codigo, pg.titulo AS titulo, pg.sinopsis AS sinopsis, " +
                $"      g.descripcion AS genero, pg.clasificacion AS clasificacion, " +
                $"      pg.duracion AS duracion, pg.imagen AS imagen, pg.year AS year, " +
                $"      pg.membresia_id AS membresia " +
                $"      FROM peliculas pg " +
                $"      INNER JOIN generos g ON (g.id = pg.genero_id) " +
                $"    ) p ON(p.membresia = m.id) "))
            {
                while (rs2.NextRecord())
                {
                    Peliculas.Add(new Pelicula(rs2.GetInt32("codigo"),
                        rs2.GetString("titulo"),
                        rs2.GetString("genero"),
                        rs2.GetInt32("year"),
                        rs2.GetString("sinopsis"),
                        rs2.GetString("clasificacion"),
                        rs2.GetInt32("duracion"),
                        rs2.GetString("imagen"),
                        rs2.GetString("membresia")));
                }
            }
            return Peliculas;
        }

        public List<Pelicula> GetPeliculasVistas(int UsuarioId)
        {
            List<Pelicula> PeliculasVistas = new List<Pelicula>();

            using (SQLiteRecordSet rs2 = ExecuteQuery($"SELECT pv.codigo AS codigo, pv.titulo AS titulo, pv.sinopsis AS sinopsis, " +
                $"pv.genero AS genero, pv.clasificacion AS clasificacion, " +
                $"pv.duracion AS duracion, pv.imagen AS imagen, pv.year AS year, " +
                $"pv.membresia AS membresia " +
                $"FROM( " +
                $"      SELECT p.codigo AS codigo, p.titulo AS titulo, p.sinopsis AS sinopsis, " +
                $"      p.genero AS genero, p.clasificacion AS clasificacion, " +
                $"      p.duracion AS duracion, p.imagen AS imagen, p.year AS year, " +
                $"      m.descripcion AS membresia " +
                $"      FROM membresias m " +
                $"      INNER JOIN( " +
                $"            SELECT pg.codigo AS codigo, pg.titulo AS titulo, pg.sinopsis AS sinopsis, " +
                $"              g.descripcion AS genero, pg.clasificacion AS clasificacion, "  +
                $"              pg.duracion AS duracion, pg.imagen AS imagen, pg.year AS year, " +
                $"              pg.membresia_id AS membresia " +
                $"              FROM peliculas pg " +
                $"              INNER JOIN generos g ON(g.id = pg.genero_id) " +
                $"            ) p ON(p.membresia = m.id) " +
                $"     ) pv " +
                $"        INNER JOIN( " +
                $"              SELECT * FROM registro_peliculas r WHERE r.usuario_id = 0 " +
                $"     ) rs ON(rs.pelicula_codigo = pv.codigo) "))
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
                        rs2.GetString("imagen"),
                        rs2.GetString("membresia")));
                }
            }
            return PeliculasVistas;
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


    }


}