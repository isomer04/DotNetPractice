using System;

class Program
{
    static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());

        int mishkaW = 0;
        int christW = 0;

        for (int i = 0; i < testCases; i++)
        {
            string[] gameRounds = Console.ReadLine().Split(' ');
            int mishkaTurn = int.Parse(gameRounds[0]);
            int christTurn = int.Parse(gameRounds[1]);

            if (mishkaTurn > christTurn)
            {
                mishkaW += 1;
            }
            else if (christTurn > mishkaTurn)
            {
                christW += 1;
            }
        }

        if (mishkaW > christW)
        {
            Console.WriteLine("Mishka");
        }
        else if (christW > mishkaW)
        {
            Console.WriteLine("Chris");
        }
        else
        {
            Console.WriteLine("Friendship is magic!^^");
        }
    }
}
