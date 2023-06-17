using System;

class Program
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
