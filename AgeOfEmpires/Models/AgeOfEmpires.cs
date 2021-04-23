using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AgeOfEmpires.Models;
using Newtonsoft.Json;

namespace AgeOfEmpires
{
    public class AgeOfEmpires : IAgeOfEmpires
    {
        #region Private member variables
        private IGameProxy _proxy;
        private readonly Random _random = new Random();
        #endregion

        #region Ctor
        public AgeOfEmpires(IGameProxy proxy)
        {
            _proxy = proxy;
        }
        #endregion

        Tuple<int, int> GetRandomUnits()
        {
            int id1 = _random.Next(1, 100);
            int id2 = id1;
            while(id1 == id2)
            {
                id2 = _random.Next(1, 100);
            }
            return new Tuple<int, int>(id1, id2);
        }

        public FightResult DoBattle()
        {
            
            Tuple<int, int> units = GetRandomUnits();
            Unit unit1 = _proxy.GetUnitInfo(units.Item1).GetAwaiter().GetResult();
            Unit unit2 = _proxy.GetUnitInfo(units.Item2).GetAwaiter().GetResult();
            string winner = string.Empty;

            if (unit1.attack == 0 && unit2.attack == 0)
                winner = "0";
            if (unit1.attack == 0)
                winner = unit2.name;
            else if (unit2.attack == 0)
                winner = unit1.name;
            else
            {
                winner = DualFight(unit1, unit2);
                
            }
            FightResult resultInfo = new FightResult
            {
                winner = winner,
                UnitsInBattle = new List<string>() { unit1.name, unit2.name },
                IsTie = (winner == "0" ? true : false)
            };
            return resultInfo;
        }

        private string DualFight(Unit unit1, Unit unit2)
        {
            int result1 = HitsRequired(unit1.attack, unit2.hit_points);
            int result2 = HitsRequired(unit2.attack, unit1.hit_points);
            
            return result1 == result2 ? "0" : (result1 < result2 ? unit1.name : unit2.name);
        }

        private int HitsRequired(int attack, int hitPoints)
        {
            return hitPoints / attack;
        }
    }
}
