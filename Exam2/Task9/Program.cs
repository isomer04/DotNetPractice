//Create a generic method named Reverse that takes a generic parameter. Apply constraint so that this parameter must be of type IList

using System.Collections.Generic;

List<int> nums = new List<int> {1 , 23, 4 };

Reverse(nums);

void Reverse<T>(IList<T> lists)
{

    //foreach( list in  lists )
    //{
    //    Console.WriteLine(list.ToString());

    //}

    for(int i  = 0; i < lists.Count; i++)
    {
        Console.WriteLine(lists[i]);
    }
}