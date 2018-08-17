﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            var usersIpAddresses = new SortedDictionary<string, Dictionary<string, int>>();
            var command = input[0];

            while (command != "end")
            {
                var ipAddressStr = input[0].Split('=').ToList();
                var ipAddress = ipAddressStr[1];
                var userStr = input[2].Split('=').ToList();
                var user = userStr[1];

                if (!usersIpAddresses.ContainsKey(user))
                {
                    var ipAddrCount = new Dictionary<string, int>();

                    if (!ipAddrCount.ContainsKey(ipAddress))
                    {
                        ipAddrCount.Add(ipAddress, 1);
                    }
                    else
                    {
                        ipAddrCount[ipAddress]++;
                    }

                    usersIpAddresses.Add(user, ipAddrCount);
                }
                else
                {
                    var ipAddrCount = new Dictionary<string, int>();
                    ipAddrCount = usersIpAddresses[user];

                    if (!ipAddrCount.ContainsKey(ipAddress))
                    {
                        ipAddrCount.Add(ipAddress, 1);
                    }
                    else
                    {
                        ipAddrCount[ipAddress]++;
                    }

                    usersIpAddresses[user] = ipAddrCount;
                }

                input = Console.ReadLine().Split().ToList();
                command = input[0];
            }        

            ////////////////////////////////////////////////
            foreach (var userIp in usersIpAddresses)
            {
                var ipAddressesCurrentUser = new Dictionary<string, int>();
                ipAddressesCurrentUser = userIp.Value;
                StringBuilder sb = new StringBuilder();

                Console.WriteLine($"{userIp.Key}:");
                foreach (var ip in ipAddressesCurrentUser)
                {
                    sb.Append($"{ip.Key} => {ip.Value}, ");
                }
                var currentUserIps = sb.ToString();
                currentUserIps = currentUserIps.Substring(0, currentUserIps.Length - 2) + ".";
                Console.WriteLine(currentUserIps);

            }
        }
    }
}
