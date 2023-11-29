class Program
{
    static void Main(string[] args)
    {
        /* int input = Console.ReadLine();
         int minSteps = MinimumSteps(14);

         Console.WriteLine(minSteps);

         */

        string inputString = Console.ReadLine();
        int input = int.Parse(inputString);

        int minSteps = MinimumSteps(input);
        Console.WriteLine( minSteps);
    }
    
    static int MinimumSteps(int input)
    {
        int minSteps = input / 5; 
        if (input % 5 != 0) 
        {
            minSteps++;
        }
        return minSteps;
    }

    
}
