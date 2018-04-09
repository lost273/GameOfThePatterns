using System;

namespace GameOfThePatterns {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello! Choose the game.");
            Console.WriteLine("1. Event pattern.");
            switch (Console.ReadLine()) {
                case "1":
                    LetsEventGame.Start();
                    break;
            }
            Console.ReadLine();
        }
    }
}
