class Program
{
    public static void Main(string[] args)
    {
        int lengthStr = int.Parse(Console.ReadLine());

        string str =  Console.ReadLine();

        int antonWon = 0;
        int danikWon = 0;

        for(int i = 0; i < lengthStr; i++)
        {
            if (str[i] == 'A')
            {
                antonWon++;
            } else
            {
                danikWon++;
            }

            
        }

        if (antonWon > danikWon) Console.WriteLine("Anton");
        else if (danikWon > antonWon) Console.WriteLine("Danik");
        else Console.WriteLine("Friendship");
    }
}