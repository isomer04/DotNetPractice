//In this task, you will take input from the user and write the text in a file using append mode and stream. The file should be created inside a Data folder in the project (beside program.cs file)

string input = Console.ReadLine();

string path = "C:\\Users\\isome\\Desktop\\c#\\c# new\\DotNetPractice\\Exam3\\Task2\\Data\\file.txt";


using (StreamWriter sw = new StreamWriter(path, true))

{
    sw.WriteLine(input);

}


