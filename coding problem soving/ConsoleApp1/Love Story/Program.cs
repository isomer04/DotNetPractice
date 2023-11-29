using System;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCases; i++)
        {
            string s = Console.ReadLine();

            int differs = 0;
            string mainString = "codeforces";

            for (int j = 0; j < s.Length; j++)
            {
                if (s[j] != mainString[j])
                    differs++;
            }

            Console.WriteLine(differs);
        }
    }
}
