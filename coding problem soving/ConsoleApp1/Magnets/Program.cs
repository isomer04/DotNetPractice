class Program
{
    static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());

        int numOfgroups = 1; 
        string previousOne = Console.ReadLine();

        for (int i = 1; i < testCases; i++)
        {
            string currentOne = Console.ReadLine();

            if (currentOne != previousOne)
                numOfgroups++;

            previousOne = currentOne;
        }

        Console.WriteLine(numOfgroups);
    }
}



