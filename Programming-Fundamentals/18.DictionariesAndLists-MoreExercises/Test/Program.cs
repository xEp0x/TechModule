using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = new List<char>();
            string hexString = "48656C6C6F20776F726C64";
            var bytes = new byte[hexString.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
                output.Add((char)bytes[i]);
                //Console.WriteLine((char)bytes[i] + " ");
            }

            Console.WriteLine(string.Join("", output));


            var str1 = "A B C D";
            var str2 = "1 2 3 4";

            var str3  = string.Concat(str1, str2);
        }
    }
}
