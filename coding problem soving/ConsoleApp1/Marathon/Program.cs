class Program
{
    static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());

        for(int  i = 0; i < testCases; i++)
        {
            int participantsFront = 0;


            string[] distances = Console.ReadLine().Split();
            int a  = int.Parse(distances[0]);
            int b = int.Parse(distances[1]);
            int c = int.Parse(distances[2]);
            int d = int.Parse(distances[3]);

            if (b > a || c > a || d > a)
                participantsFront++;
            if (c > a)
                participantsFront++;
            if (d > a)
                participantsFront++;

            Console.WriteLine(participantsFront);

        }
    }
}