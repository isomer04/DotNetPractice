using System;

class Program
{
    static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCases; i++)
        {
            string ticketNums = Console.ReadLine();
            int firstThreeDigits = int.Parse(ticketNums.Substring(0, 3));
            int lastThreeDigits = int.Parse(ticketNums.Substring(3));

            int sumFirstThreeDigits = 0;
            int sumLastThreeDigits = 0;
            int tempFirstThreeDigits = firstThreeDigits;
            int tempLastThreeDigits = lastThreeDigits;

            while (tempFirstThreeDigits > 0)
            {
                sumFirstThreeDigits += tempFirstThreeDigits % 10;
                tempFirstThreeDigits /= 10;
            }

            while (tempLastThreeDigits > 0)
            {
                sumLastThreeDigits += tempLastThreeDigits % 10;
                tempLastThreeDigits /= 10;
            }

            if (sumLastThreeDigits == sumFirstThreeDigits)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
