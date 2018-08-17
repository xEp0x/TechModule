using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Jarvis
{
    public class Arm
    {
        public int Energy { get; set; }

        public int ReachDistance { get; set; }

        public int Fingers { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"#Arm:\n");
            sb.Append($"###Energy consumption: {Energy}\n");
            sb.Append($"###Reach: {ReachDistance}\n");
            sb.Append($"###Fingers: {Fingers}\n");

            return sb.ToString();
        }
    }
}
