using System;
class Program
{
    static void Main(string[] args)
    {
        string inputString = Console.ReadLine();


        int upper = 0;
        int lower = 0;


        for (int i = 0; i < inputString.Length; i++)
        {
            char c = inputString[i];

            if(char.IsUpper(c)) {  upper++; } else if(char.IsLower(c)) {  lower++; }
            

        }

        if(upper > lower)
        {
            inputString = inputString.ToUpper();
        } else { inputString = inputString.ToLower(); }



        Console.WriteLine(inputString);
    }
}
