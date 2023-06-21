class Program
{
    static void Main(string[] args)
    {
        int inputDigit1 = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');


        double responses = 0;

        for (int i = 0; i < inputDigit1; i++)
        {
            responses += int.Parse(input[i]);
        }

        responses = responses / inputDigit1;

        Console.WriteLine(responses);

    }
}
