using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var logCount = int.Parse(Console.ReadLine());
            var usersIpAddresses = new SortedDictionary<string, List<string>>();
            var usersDuration = new SortedDictionary<string, int>();

            EnterLogs(logCount, usersIpAddresses, usersDuration);

            //Print output info
            foreach (var userDuration in usersDuration)
            {
                Console.Write($"{userDuration.Key}: {userDuration.Value} ");
                var userIpAddresses = usersIpAddresses[userDuration.Key];
                userIpAddresses = userIpAddresses.OrderBy(ipAddress => ipAddress).ToList();
                Console.WriteLine($"[{string.Join(", ", userIpAddresses)}]");
            }
        }

        private static void EnterLogs(int logCount, SortedDictionary<string, List<string>> usersIpAddresses, SortedDictionary<string, int> usersDuration)
        {
            for (int i = 0; i < logCount; i++)
            {
                var logLine = Console.ReadLine().Split().ToList();
                var ipAddress = logLine[0];
                var user = logLine[1];
                var duration = int.Parse(logLine[2]);

                if (!usersDuration.ContainsKey(user))
                {
                    usersDuration.Add(user, duration);
                    var ipAddresses = new List<string>();
                    ipAddresses.Add(ipAddress);
                    usersIpAddresses.Add(user, ipAddresses);
                }
                else
                {
                    var totalDuration = usersDuration[user] + duration;
                    usersDuration[user] = totalDuration;
                    var ipAddresses = new List<string>();
                    ipAddresses = usersIpAddresses[user];
                    ipAddresses.Add(ipAddress);
                    ipAddresses = ipAddresses.Distinct().ToList();
                    usersIpAddresses[user] = ipAddresses;
                }
            }
        }
    }
}
