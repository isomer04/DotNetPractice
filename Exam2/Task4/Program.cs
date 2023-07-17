
//Take input from the user a string. Then using StringBuilder replace all vowels in that string with dash (-). Finally print the string.

using System.Text;

string userInput = Console.ReadLine();

StringBuilder strBuilder = new StringBuilder(userInput);

strBuilder.Replace("a", "-");
strBuilder.Replace("i", "-");
strBuilder.Replace("e", "-");
strBuilder.Replace("o", "-");
strBuilder.Replace("u", "-");

Console.WriteLine(strBuilder.ToString());
    
