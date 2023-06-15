using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class ChessPieceModel
    {

        public string Name { get; set; }
        public float BoxMovingNumber { get; set; }



        public void MoveTo()
        {
            Console.WriteLine("This Piece name is " + Name + ". It can move to " + BoxMovingNumber + " box");
        }
    }
}




