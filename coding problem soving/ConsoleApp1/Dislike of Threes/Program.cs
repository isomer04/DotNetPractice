public class Program
{
    public static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());


        for (int i = 0; i < testCases; i++)
        {
            int input = int.Parse(Console.ReadLine());

            int count = 0;
            int output = 1;

            while (count < input)
            {
                if (output % 3 != 0 && output % 10 != 3)
                {
                    count++;
                }

                output++;
            }

            Console.WriteLine(output - 1);
        }
    }
}
