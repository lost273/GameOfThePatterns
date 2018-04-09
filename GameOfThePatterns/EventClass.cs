using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThePatterns {
    class EventClass {
        public delegate void MethodContainer();
        public event MethodContainer onCount;
        public void EventGame() {
            for (int i = 0; i < 100; i++) {
                Console.Write("#");
            }
            onCount();
        }
    }
    class Handler {
        public void SomeMessage() {
            Console.WriteLine("Something!");
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
