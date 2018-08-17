namespace _15.DebuggingExerciseSubstring
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            {
                const char ch = 'p';

                string text = Console.ReadLine();
                int jump = int.Parse(Console.ReadLine());
                bool hasMatch = false;
                int counter = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == ch)
                    {
                        hasMatch = true;
                        int endIndex = jump + 1;

                        if ((i + endIndex) > text.Length)
                        {
                            endIndex = text.Length - i;
                        }

                        string matchedString = text.Substring(i, endIndex);
                        Console.WriteLine(matchedString);
                        i += jump;
                    }
                }

                if (!hasMatch)
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}
