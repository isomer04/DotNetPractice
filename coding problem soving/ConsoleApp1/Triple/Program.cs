using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCases; i++)
        {
            int lengthOfElements = int.Parse(Console.ReadLine());
            int[] elementsArray = new int[lengthOfElements];

            string[] arrayOfElements = Console.ReadLine().Split();
            for (int j = 0; j < lengthOfElements; j++)
            {
                elementsArray[j] = int.Parse(arrayOfElements[j]);
            }

            Dictionary<int, int> countDict = new Dictionary<int, int>();

            for (int k = 0; k < elementsArray.Length; k++)
            {
                if (countDict.ContainsKey(elementsArray[k]))
                {
                    countDict[elementsArray[k]]++;
                }
                else
                {
                    countDict[elementsArray[k]] = 1;
                }

                if (countDict[elementsArray[k]] >= 3)
                {
                    Console.WriteLine(elementsArray[k]);
                    break;
                }
            }

            bool hasValueAppearingThreeTimes = false;
            foreach (var count in countDict.Values)
            {
                if (count >= 3)
                {
                    hasValueAppearingThreeTimes = true;
                    break;
                }
            }

            if (!hasValueAppearingThreeTimes)
            {
                Console.WriteLine(-1);
            }
        }
    }
}
