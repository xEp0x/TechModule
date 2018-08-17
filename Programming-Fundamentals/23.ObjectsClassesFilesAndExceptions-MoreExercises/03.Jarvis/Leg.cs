using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Jarvis
{
    public class Leg
    {
        public int Energy { get; set; }

        public int Strength { get; set; }

        public int Speed { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"#Leg:\n");
            sb.Append($"###Energy consumption: {Energy}\n");
            sb.Append($"###Strength: {Strength}\n");
            sb.Append($"###Speed: {Speed}\n");

            return sb.ToString();
        }
    }
}

