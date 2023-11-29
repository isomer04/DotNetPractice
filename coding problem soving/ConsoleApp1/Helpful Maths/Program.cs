using System;
class Program
{
    static void Main(string[] args)
    {
        string inputString = Console.ReadLine();  

        string[] numbersOnly = inputString.Trim().Split('+');
        Array.Sort(numbersOnly);

        string[] sortedString = new string[numbersOnly.Length];
        for (int i = 0; i < numbersOnly.Length; i++)
        {
            sortedString[i] = numbersOnly[i].ToString();
        }

        string desuredOutput = string.Join("+", sortedString);
       
        Console.WriteLine(desuredOutput);
    }
}
