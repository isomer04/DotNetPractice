class Program
{
    static string IsPangram (int length, string str) 
    {
        bool[] alphabetArr = new bool[26];

        foreach (char ch in str.ToLower())
        {
           if(char.IsLetter (ch))
            {
                int index = ch - 'a';
                alphabetArr[index] = true;
            }
        }

        foreach(bool  letter in alphabetArr)
        {
            if (!letter) return "NO";
        }

        return "YES";
    }

    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        string str =  Console.ReadLine();

        string output = IsPangram (length, str);
        Console.WriteLine (output);
    }
}