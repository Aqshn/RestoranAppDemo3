using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.Models
{
    public class Food
    {
        public string? Name { get; set; }
        public float Price { get; set; }
        Food(string? name, float price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()=>$@"{Name}     {Price}";
    }
}
