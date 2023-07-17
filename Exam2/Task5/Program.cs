//Create a method named “Print” and show use of “params” in it. This method should take string messages and print all the messages in parameter. 

static void Print(params string[] messages)
{
    for(int i = 0; i < messages.Length; i++)
    {
        Console.WriteLine(messages[i]);
    }
}

Print("Hello my friend");
Print("I am giving an exam now");