class Program
{
    static void Main(string[] args)
    {
        string[] calories = Console.ReadLine().Split(' ');
        int a1 = int.Parse(calories[0]);
        int a2 = int.Parse(calories[1]);
        int a3 = int.Parse(calories[2]);
        int a4 = int.Parse(calories[3]);

        string s = Console.ReadLine();

        int totalCaloriesWaste = 0;

        for(int i = 0; i< s.Length; i++)
        {
            char character = s[i];

            if(character == '1')
            {
                totalCaloriesWaste += a1;

            }
            else if (character == '2')
            {
                totalCaloriesWaste += a2;
            } else if (character == '3')
            {
                totalCaloriesWaste += a3;

            } else if (character == '4')
            {
                totalCaloriesWaste += a4;
            }


        }

        Console.WriteLine(totalCaloriesWaste);

    }
}