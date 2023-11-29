
class Program
{
    static void Main(string[] args)
    {
        string[] inputArr = Console.ReadLine().Split();
        
        int numOfFriends = int.Parse(inputArr[0]);
        int numberOfBottles = int.Parse(inputArr[1]);
        int millilitersBottles = int.Parse(inputArr[2]);
        int numOfLimes = int.Parse(inputArr[3]);
        int slicesPerLime = int.Parse(inputArr[4]);
        int totalSalt = int.Parse(inputArr[5]);
        int millitersPerToast = int.Parse(inputArr[6]);
        int gramsOfSaltPerToast = int.Parse(inputArr[7]);

        int totalDrink = numberOfBottles * millilitersBottles;
        int totalLimes = numOfLimes * slicesPerLime;

        int maxToasts = Math.Min(totalDrink / (numOfFriends * millitersPerToast),
            Math.Min(totalLimes / numOfFriends,
            totalSalt / (numOfFriends * gramsOfSaltPerToast)));


        Console.WriteLine(maxToasts);
    }
}


