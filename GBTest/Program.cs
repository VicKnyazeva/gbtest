using System;

namespace GBTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = { "Hello", "2", "world", ":-)" };

            FindStrings(input);
        }

        private static void FindStrings(string[] input)
        {
            int counter = 0;

            foreach (var e in input)
            {
                if (e.Length <= 3)
                    counter++;
            }

            if (counter == 0)
                Console.WriteLine("Нужных строк нет");
            else
            {
                string[] output = new string[counter];
                int index = 0;

                foreach (var e in input)
                {
                    if (e.Length <= 3)
                        output[index++] = e;
                }

                foreach (var e in output)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
