using ChessInheritance.Chess.Figures;
using System;

namespace ChessInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //przykłady
            Goniec b = new Goniec();
            b.Name = "Goniec";
            b.Color = "Black";

            Console.WriteLine(b.ToString());
            Console.ReadKey();
        }
    }
}
