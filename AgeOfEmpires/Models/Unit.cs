using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgeOfEmpires.Models
{
    public class Unit
    {
        public int id { get; set; }
        public string name { get; set; }
        public int hit_points { get; set; }
        public int attack { get; set; }
    }
}
