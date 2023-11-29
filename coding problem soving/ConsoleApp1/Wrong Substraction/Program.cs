using System;

class Program
{
    static void Main(string[] args)
    {
        string[] inputString = Console.ReadLine().Split(' ');
        int inputdigit = int.Parse(inputString[0]);
        int inputLengthdigit = int.Parse(inputString[1]);

        for (int i = 0; i < inputLengthdigit; i++)
        {
            if (inputdigit % 10 != 0)
            {
                inputdigit--;
            }
            else
            {
                inputdigit /= 10;
            }
        }

        Console.WriteLine(inputdigit);
    }
}
