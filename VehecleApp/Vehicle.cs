using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehecleApp
{
    public class Vehicle

    {
        public string ?Brand { get; set; }
        public string ?Model { get; set; }
        public string ?Year { get; set; }
        public override string ToString()
        {
            return $"{Year} {Brand} {Model}";
        }
    }
}
