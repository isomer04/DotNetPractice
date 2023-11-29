using System;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            int maxVotes = Math.Max(Math.Max(a, b), c);
            int additionalVotesA = maxVotes - a + 1;
            int additionalVotesB = maxVotes - b + 1;
            int additionalVotesC = maxVotes - c + 1;

            Console.WriteLine($"{additionalVotesA} {additionalVotesB} {additionalVotesC}");
        }
    }
}
