using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgeOfEmpires
{
    public class FightResult
    {
        public List<string> UnitsInBattle { get; set; }
        public string winner { get; set; }
        public bool IsTie { get; set; }
    }
}
