using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int cryptKey = int.Parse(Console.ReadLine());
            int charactersCount = int.Parse(Console.ReadLine());
            string decryptedMessage = string.Empty;

            for (int i = 0; i < charactersCount; i++)
            {
                char character = char.Parse(Console.ReadLine());
                char decryptedCharacter = (char)(cryptKey + character);
                decryptedMessage += (decryptedCharacter);
            }

            Console.WriteLine(decryptedMessage);

        }
    }
}
