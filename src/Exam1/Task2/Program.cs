//In this task, you have to create an object oriented design (Class, method, etc.) of a Chess game. [Score: 50]

using System;
using Task2;

class Program
{
    static void Main()
    {
        ChessPieceModel chessPieceModel1 = new ChessPieceModel();


        chessPieceModel1.Name = "King";
        chessPieceModel1.BoxMovingNumber = 1;



        ChessPieceModel chessPieceModel2 = new ChessPieceModel();

        chessPieceModel2.Name = "Horse";
        chessPieceModel2.BoxMovingNumber = 2.5f;

        chessPieceModel1.MoveTo();
        chessPieceModel2.MoveTo();

        ChessPieceModel2 king2 = new King();
        king2.BoxMovingInfo();

        /*

        Console.WriteLine("Write the name of piece");
        chessPieceModel.Name = Console.ReadLine();


        Console.WriteLine("Write how many box the piece can move");
        chessPieceModel.BoxMovingNumber = toInt((Console.ReadLine());

        */

    }
}