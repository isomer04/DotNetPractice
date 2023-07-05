class Program
{
    static void Main(string[] args)
    {
        int numOfEmply = int.Parse(Console.ReadLine());

        int result = 0;

        for (int i = 1; i < numOfEmply; i++)
        {
            if (numOfEmply % i == 0)
                result++;
        }

        Console.WriteLine(result);
    }
}
