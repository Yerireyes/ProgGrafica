using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Impacto de Genchi");
            Game game = new Game(1000, 700, ":D");
            game.Run();
        }
    }
}
