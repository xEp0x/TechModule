using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Jarvis
{
    public class Torso
    {
        public int Energy { get; set; }

        public double ProcessorSize { get; set; }

        public string HousingMaterial { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"#Torso:\n");
            sb.Append($"###Energy consumption: {Energy}\n");
            sb.Append($"###Processor size: {ProcessorSize:F1}\n");
            sb.Append($"###Corpus material: {HousingMaterial}\n");

            return sb.ToString();
        }
    }
}
