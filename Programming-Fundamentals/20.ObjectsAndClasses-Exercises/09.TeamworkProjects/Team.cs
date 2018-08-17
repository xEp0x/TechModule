using System;
using System.Collections.Generic;

namespace _09.TeamworkProjects
{
    public class Team
    {
        public Team(string name, string creator, List<string> members)
        {
            Name = name;
            Creator = creator;
            Members = members;
        }

        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }     
    }
}
