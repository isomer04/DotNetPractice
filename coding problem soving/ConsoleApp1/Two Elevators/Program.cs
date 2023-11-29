using System.Threading.Channels;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCases; i++)
        {
            string[] input = Console.ReadLine().Split();

            int aFloor = int.Parse(input[0]);
            int bFloor = int.Parse(input[1]);
            int cFloor = int.Parse(input[2]);

            int timeElevator1 = Math.Abs(aFloor - 1);
            int timeElevator2 = Math.Abs(bFloor - cFloor) + Math.Abs(cFloor - 1);

            if (timeElevator1 < timeElevator2)
            {
                Console.WriteLine(1);
            }
            else if (timeElevator2 < timeElevator1)
            {
                Console.WriteLine(2);
            }
            else
            {
                Console.WriteLine(3);
            }
        }
    }
}