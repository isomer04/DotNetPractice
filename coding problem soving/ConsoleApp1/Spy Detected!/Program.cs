using System;

class Program
{
    static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCases; i++)
        {
            int lengthOfArray = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split();

            int uniqueNumber = 0;

            for (int j = 0; j < lengthOfArray - 1; j++)
            {
                if (numbers[j] != numbers[j + 1])
                {
                    uniqueNumber = j + 1;
                    break;
                }
            }

            //if( uniqueNumber != ) { }
            Console.WriteLine(uniqueNumber);
        }
    }
}
