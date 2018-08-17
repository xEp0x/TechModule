using System;

namespace _01.BlankReceipt
{
   
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();           
        }

        private static void PrintReceipt()
        {
            PrintHeaderReceipt();
            PrintBodyReceipt();
            PrintFooterReceipt();
        }

        private static void PrintFooterReceipt()
        {
            Console.WriteLine("------------------------------");
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\u00A9" + " SoftUni");
            Console.WriteLine("© SoftUni");

        }

        private static void PrintBodyReceipt()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        private static void PrintHeaderReceipt()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
    }
}
