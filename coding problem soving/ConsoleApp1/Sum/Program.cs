class Program
{
    static void Main(string[] args)
    {
        int numOfTest = int.Parse(Console.ReadLine());

        for(int i = 0; i< numOfTest; i++)
        {
            string[] numArray = Console.ReadLine().Split();
            int firstValue = int.Parse(numArray[0]);
            int secondValue = int.Parse(numArray[1]);
            int thirdValue = int.Parse(numArray[2]);

            if((firstValue + secondValue ==  thirdValue) || secondValue + thirdValue == firstValue || firstValue + thirdValue == secondValue)
            {
                Console.WriteLine("YES");
            } else
            {
                Console.WriteLine("NO");
            }
        }
       

    }
}
