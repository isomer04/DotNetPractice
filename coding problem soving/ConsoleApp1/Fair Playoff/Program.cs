class Program
{
    static void Main()
    {
        int testCasess = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCasess; i++)
        {
            string[] playerSkills = Console.ReadLine().Split();

            int[] sortedPlayerSkills = new int[4];

            for (int j = 0; j < 4; j++)
            {
                sortedPlayerSkills[j] = int.Parse(playerSkills[j]);
            }

            Array.Sort(sortedPlayerSkills);


            bool isFair = sortedPlayerSkills[2] == Math.Max(sortedPlayerSkills[0], sortedPlayerSkills[1]) ||sortedPlayerSkills[2] == Math.Min(sortedPlayerSkills[0], sortedPlayerSkills[1]);

            if(isFair)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
