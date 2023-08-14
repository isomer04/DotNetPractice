//In this task, you have to print the names of fruits grouped by their last letter.Print the last letter and the fruits that belong to that letter.

string[] fruits = { "apple", "banana", "mango", "goava", "strawberry", "pineapple" };


var lLetters = fruits.Select(f => f.Last()).Distinct().ToList();