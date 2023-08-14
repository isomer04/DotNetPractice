//In this task, you will take input from the user and write the text in a file using append mode and stream. The file should be created inside a Data folder in the project (beside program.cs file)

using System.IO;

string input = Console.ReadLine();

string dataPath = "Data";
string fileName = "file.txt";


string wholePath = Path.Combine(dataPath, fileName);
Directory.CreateDirectory(dataPath);


using (FileStream fs = new FileStream(wholePath, FileMode.Append, FileAccess.Write))
{
    using (StreamWriter sw = new StreamWriter(fs))
    {
        sw.WriteLine(input);
    }
}



//string input = Console.ReadLine();

//string path = "C:\\Users\\isome\\Desktop\\c#\\c# new\\DotNetPractice\\Exam3\\Task2\\Data\\file.txt";


//using (StreamWriter sw = new StreamWriter(path, true))

//{
//    sw.WriteLine(input);

//}


