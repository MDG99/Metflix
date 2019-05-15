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
}
