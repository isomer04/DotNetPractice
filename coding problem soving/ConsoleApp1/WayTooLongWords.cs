using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_problem_solving
{
    internal class Way_Too_Long_Words
    {

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string word = Console.ReadLine();

                if (word.Length > 10)
                {
                    string abbreviation = $"{word[0]}{word.Length - 2}{word[^1]}";
                    Console.WriteLine(abbreviation);
                }
                else
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
