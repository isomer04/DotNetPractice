class Program
{
    static void Main(string[] args)
    {
        int numberOfDrink = int.Parse(Console.ReadLine());
        string[] orangeJuicesInFraction = Console.ReadLine().Split(' ');


        double responses = 0;

        for (int i = 0; i < numberOfDrink; i++)
        {
            responses += int.Parse(orangeJuicesInFraction[i]);
        }

        responses = responses / numberOfDrink;

        Console.WriteLine(responses);

    }
}
