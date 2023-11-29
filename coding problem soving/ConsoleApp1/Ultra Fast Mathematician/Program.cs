class Program
{
    static void Main(string[] args)
    {
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();

        string output = "";

        for(int i = 0; i< input1.Length; i++)
        {
            int input1digit = int.Parse(input1[i].ToString());
            int input2digit = int.Parse(input2[i].ToString());

            int difference = input1digit - input2digit;

            if(difference == 0)
            {
                output += 0;

            } else
            {
                output += 1;
            }



        }
        Console.WriteLine(output);

    }
}
