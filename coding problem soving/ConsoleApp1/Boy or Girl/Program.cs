class Program
{
    static void Main(string[] args)
    {
        string userName = Console.ReadLine();

        FindGender(userName);
    }

    static void FindGender(string userName)
    {
        HashSet<char> distinctChars = new HashSet<char>();
        foreach (char c in userName)
        {
            distinctChars.Add(c);
        }

        if (distinctChars.Count % 2 == 0)
        {
            Console.WriteLine("IGNORE HIM!");
        }
        else
        {
            Console.WriteLine("CHAT WITH HER!");
        }

    }
}
