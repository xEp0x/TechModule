using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {


            var dragonCount = int.Parse(Console.ReadLine());
            var dragonTypeNameStats = new Dictionary<string, SortedDictionary<string, List<int>>>();

            for (int i = 0; i < dragonCount; i++)
            {
                var inputLine = Console.ReadLine().Split().ToList();
                var dragonType = inputLine[0];
                var dragonName = inputLine[1];
                inputLine.RemoveRange(0, 2);
                var stats = CalcInputStats(inputLine);

                FillDragonTypeNameStats(dragonType, dragonName, stats, dragonTypeNameStats);
            }

            PrintOutputStatistics(dragonTypeNameStats);
        }

        static void PrintOutputStatistics(Dictionary<string, SortedDictionary<string, List<int>>> dragonTypeNameStats)
        {

            foreach (var dragonTypeNameStat in dragonTypeNameStats)
            {
                var dragonNameStats = dragonTypeNameStat.Value;

                PrintAvarareTypeStats(dragonTypeNameStat, dragonNameStats);

                foreach (var dragonNameStat in dragonNameStats)
                {
                    var dragonName = dragonNameStat.Key;
                    var dragonStats = dragonNameStat.Value;
                    var dragonDamage = dragonStats[0];
                    var dragonHealth = dragonStats[1];
                    var dragonArmor = dragonStats[2];

                    Console.WriteLine($"-{dragonName} -> damage: {dragonDamage}, health: {dragonHealth}, armor: {dragonArmor}");
                }
            }
        }

        static void PrintAvarareTypeStats(KeyValuePair<string, SortedDictionary<string, List<int>>> dragonTypeNameStat
            , SortedDictionary<string, List<int>> dragonNameStats)
        {
            var dragonCountInType = dragonNameStats.Count;
            var sumDragonTypeStats = new List<double> { 0.0, 0.0, 0.0 };

            foreach (var dragonNameStat in dragonNameStats)
            {
                var dragonStats = new List<int>();
                dragonStats = dragonNameStat.Value;
                for (int i = 0; i < 3; i++)
                {
                    sumDragonTypeStats[i] += dragonStats[i];
                }
            }

            sumDragonTypeStats = sumDragonTypeStats.Select(avarage => (avarage * 1.0) / dragonCountInType).ToList();
            var avarageDamage = sumDragonTypeStats[0];
            var avarageHealth = sumDragonTypeStats[1];
            var avarageArmor = sumDragonTypeStats[2];
            Console.WriteLine($"{dragonTypeNameStat.Key}::({avarageDamage:F2}/{avarageHealth:F2}/{avarageArmor:F2})");
        }

        static void FillDragonTypeNameStats(string dragonType, string dragonName, List<int> stats
            , Dictionary<string, SortedDictionary<string, List<int>>> dragonTypeNameStats)
        {

            if (!dragonTypeNameStats.ContainsKey(dragonType))
            {
                var dragonNameStats = new SortedDictionary<string, List<int>>();
                dragonNameStats.Add(dragonName, stats);
                dragonTypeNameStats.Add(dragonType, dragonNameStats);
            }
            else
            {
                var dragonNameStats = new SortedDictionary<string, List<int>>();
                dragonNameStats = dragonTypeNameStats[dragonType];

                if (!dragonNameStats.ContainsKey(dragonName))
                {
                    dragonNameStats.Add(dragonName, stats);
                    dragonTypeNameStats[dragonType] = dragonNameStats;

                }
                else
                {
                    dragonNameStats[dragonName] = stats;
                    dragonTypeNameStats[dragonType] = dragonNameStats;
                }
            }
        }

        static List<int> CalcInputStats(List<string> inputLine)
        {
            var defaultStats = new List<int> { 45, 250, 10 };
            var stats = new List<int>();

            for (int i = 0; i < inputLine.Count; i++)
            {
                if (inputLine[i] == "null")
                {
                    stats.Add(defaultStats[i]);
                }
                else
                {
                    stats.Add(int.Parse(inputLine[i]));
                }
            }

            return stats;
        }
    }
}
