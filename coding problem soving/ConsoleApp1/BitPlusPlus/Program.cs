class Program
{
     public static void Main(string[] args)
    {
        int numStatements = int.Parse(Console.ReadLine());

        int result = 0;

        for (int i = 0; i < numStatements; i++)
        {
            string statement = Console.ReadLine();

            if (statement.Contains("++"))
            {
                result++;
            }

            else if (statement.Contains("--"))
            {
                result--;
            }
        }

        Console.WriteLine(result);
    }
}
