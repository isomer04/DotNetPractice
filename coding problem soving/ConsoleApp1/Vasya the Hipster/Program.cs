class Program
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        int maxDifferentDays = Math.Min(a, b);
        int maxSameDays = Math.Abs(a - b) / 2;

        Console.WriteLine($"{maxDifferentDays } {maxSameDays }");
    }
}