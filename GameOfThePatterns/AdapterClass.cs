using System;

namespace GameOfThePatterns {
    class Client {
        public void Request(Target target) {
            target.Request();
        }
    }
    class Target {
        public virtual void Request() {
            Console.WriteLine("Hello from original target!");
        }
    }
    class AdapterClass : Target {
        private Adaptee adaptee = new Adaptee();
        public override void Request() {
            adaptee.SpecificRequest();
        }
    }
    class Adaptee {
        public void SpecificRequest() {
            Console.WriteLine("Hello from adaptee!");
        }
    }
    class LetsAdapterGame {
        public static void Start() {
            Client client = new Client();
            Target target = new Target();
            client.Request(target);

            AdapterClass adapterClass = new AdapterClass();
            client.Request(adapterClass);
        }
    }
}
