using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meflix
{
    public sealed class Usuario
    {
        public int Id { get; }
        public string UserName { get; }
        public string Password { get; }
        public string Name { get; }
        public string LastName { get; }
        public int MembresiaId { get; }
        public string FullName { get { return Name + " " + LastName; } }

        public Usuario(int id, string userName, string password, string name, string lastName, int membresiaId)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Name = name;
            LastName = lastName;
            MembresiaId = membresiaId;
        }
    }

    public sealed class Pelicula
    {
        public int Codigo { get; }
        public string Titulo { get; }
        public string Genero { get; }
        public int Year { get; }
        public string Sinopsis { get; }
        public string Clasificacion { get; }
        public int Duracion { get; }
        public string Imagen { get; }

        public Pelicula(int codigo, string titulo,
            string genero, int year, string sinopsis, 
            string clasificacion, int duracion, string imagen)
        {
            Codigo = codigo;
            Titulo = titulo;
            Genero = genero;
            Year = year;
            Sinopsis = sinopsis;
            Clasificacion = clasificacion;
            Duracion = duracion;
            Imagen = imagen;
        }
    }
}
