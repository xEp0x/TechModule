using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.NetherRealms
{
    class NetherRealms
    {
        static void Main(string[] args)
        {
            var demonsInput = Console.ReadLine().Split(',').Select(d => d.Trim()).ToList();
            var healthPattern = @"[^\d+\-\*\/\.]+";
            var damagePattern = @"-?(\d+)(\.\d+)?";
            List<Demon> demons = new List<Demon>();

            EnterDemonsData(demonsInput, healthPattern, damagePattern, demons);

            //demons = demons.OrderBy(d => d.Name).ToList();

            foreach (var demon in demons.OrderBy(d=>d.Name))
            {
                var name = demon.Name;
                var health = demon.Health;
                var damage = demon.Damage;
                Console.WriteLine($"{name} - {health} health, {damage:F2} damage ");
            }
        }

        static void EnterDemonsData(List<string> demonsInput, string healthPattern, string damagePattern, List<Demon> demons)
        {
            foreach (var demon in demonsInput)
            {
                var healthMatches = Regex.Matches(demon, healthPattern);
                var damageMatches = Regex.Matches(demon, damagePattern);

                var healthPoints = CalcHealthPoints(healthMatches);
                var damagePoints = CalcDamagePoints(demon, damageMatches);

                Demon currentDemon = new Demon(demon, healthPoints, damagePoints);
                demons.Add(currentDemon);
            }
        }

        static double CalcDamagePoints(string demon, MatchCollection damageMatches)
        {
            var damagePoints = 0.0;

            foreach (Match damage in damageMatches)
            {
                var damageStr = damage.Value;
                damagePoints += double.Parse(damageStr);
            }

            var multiplyCount = demon.Count(ch => ch == '*');
            var divisionCount = demon.Count(ch => ch == '/');
            damagePoints *= Math.Pow(2, multiplyCount);
            damagePoints /= Math.Pow(2, divisionCount);

            return damagePoints;
        }

        static int CalcHealthPoints(MatchCollection healthMatches)
        {
            var healthPoints = 0;

            foreach (Match health in healthMatches)
            {
                var healthStrArr = health.Value.ToList();
                healthPoints += healthStrArr.Sum(ch => (int)ch);
            }

            return healthPoints;
        }
    }

    public class Demon
    {
        public Demon(string name, int health, double damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public string Name { get; set; }

        public int Health { get; set; }

        public double Damage { get; set; }
    }
}
