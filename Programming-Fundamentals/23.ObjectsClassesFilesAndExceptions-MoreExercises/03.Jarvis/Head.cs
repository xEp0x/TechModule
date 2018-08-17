using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Jarvis
{
    public class Head
    {
        public int Energy { get; set; }

        public int Iq { get; set; }

        public string SkinMaterial { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"#Head:\n");
            sb.Append($"###Energy consumption: {Energy}\n");
            sb.Append($"###IQ: {Iq}\n");
            sb.Append($"###Skin material: {SkinMaterial}\n");

            return sb.ToString();
        }
    }
}
