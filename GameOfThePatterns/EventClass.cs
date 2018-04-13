using System;

namespace GameOfThePatterns {
    class EventClass {
        public delegate void MethodContainer();
        public event MethodContainer onCount;
        public void EventGame() {
            string message;
            Console.WriteLine("Enter - stop - to activate an event.");
            while (true) {
                message = Console.ReadLine();
                if (message.Equals("stop")) {
                    onCount();
                    break;
                }
                else {
                    Console.WriteLine("Event wasn't activate.");
                }
            }
            
        }
    }
    class Handler {
        public void SomeMessage() {
            Console.WriteLine("The event was activated!");
        }
    }
    class LetsEventGame {
        public static void Start() {
            EventClass letsPlay = new EventClass();
            Handler handlerOne = new Handler();
            letsPlay.onCount += handlerOne.SomeMessage;
            letsPlay.EventGame();
        }
    }
}
