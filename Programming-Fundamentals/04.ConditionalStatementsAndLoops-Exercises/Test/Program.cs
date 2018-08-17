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
            var peshodmg = int.Parse(Console.ReadLine());
            var goshodmg = int.Parse(Console.ReadLine());
            var attacker = " ";
            var peshohp = 100;
            var goshohp = 100;

            var attack = " ";
            var defender = " ";
            var round = 1;
            var winner = " ";
            while (peshohp != 0 || goshohp != 0)
            {              
                if (round % 2 == 0)
                {
                    //even
                    attacker = "Gosho";
                    attack = "Thunderous fist";
                    defender = "Pesho";
                    peshohp -= goshodmg;
                    if (peshohp <= 0)
                    {
                        winner = "Gosho";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("{0} used {1} and reduced {2} to {3} health.", attacker, attack, defender, peshohp);
                    }
                }
                else 
                {
                    //odd
                    attacker = "Pesho";
                    attack = "Roundhouse kick";
                    defender = "Gosho";
                    goshohp -= peshodmg;
                    if (goshohp <= 0)
                    {
                        winner = "Pesho";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("{0} used {1} and reduced {2} to {3} health.", attacker, attack, defender, goshohp);
                    }
                }
                
                if (round % 3 == 0)
                {
                    peshohp += 10;
                    goshohp += 10;
                }
                round++;
            }

            Console.WriteLine("{0} won in {1}th round.", winner, round);

        }
    }
}
