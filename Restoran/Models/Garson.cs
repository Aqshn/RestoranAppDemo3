using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.Models
{
    public class Garson
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }

        public string? Password { get; set; }
        Garson(string? name, string? password, string? surname)
        {
            Name = name;
            Password = password;
            Surname = surname;
        }
        public override string ToString() => @$"{Name}            {Surname}";
    }
}
