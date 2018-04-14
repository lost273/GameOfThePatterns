using System;

namespace GameOfThePatterns {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello! Choose the game.");
            Console.WriteLine("1. Event pattern.");
            Console.WriteLine("2. Decorator pattern.");
            switch (Console.ReadLine()) {
                case "1":
                    LetsEventGame.Start();
                    break;
                case "2":
                    LetsDecoratorGame.Start();
                    break;
            }
            Console.ReadLine();
        }
    }
}
