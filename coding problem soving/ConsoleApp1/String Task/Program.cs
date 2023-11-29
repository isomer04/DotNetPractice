

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();


        string vowelList = "AEOYUIaeoyui";

        string resultingString = "";
        

        for(int i = 0; i< input.Length; i++)
        {
            char c = input[i];

            if(!vowelList.Contains(c.ToString()))
            {
                resultingString += "." + char.ToLower(c);
            }
        }

        Console.WriteLine(resultingString);

    }
}