public class Program
{
    public static void Main(string[] args)
    {
        int numContests = int.Parse(Console.ReadLine());

        string[] input = Console.ReadLine().Split();


        int[] points = new int[numContests];
        for (int i = 0; i < numContests; i++)
        {
            points[i] = int.Parse(input[i]);
        }

        int amazingPerformances = 0;
        int maxPoints = points[0];
        int minPoints = points[0];

        for (int i = 1; i < numContests; i++)
        {
            if (points[i] > maxPoints)
            {
                maxPoints = points[i];
                amazingPerformances++;
            }
            else if (points[i] < minPoints)
            {
                minPoints = points[i];
                amazingPerformances++;
            }
        }

        Console.WriteLine(amazingPerformances);
    }
}
