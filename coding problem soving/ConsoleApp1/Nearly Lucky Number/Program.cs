using System;
class Program
{
    static void Main(string[] args)
    {
        string inputString = Console.ReadLine();




        for (int i = 0; i < inputString.Length; i++)
        {
            if (inputString[i] == '4' || inputString[i]== '7')
            {
                Console.WriteLine("YES");
            } else
            {
                Console.WriteLine("NO");

            }

        }


    }
}
// not solved