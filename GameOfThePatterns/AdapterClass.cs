using System;

namespace GameOfThePatterns {
    class Client {
        public void Request(Target target) {
            target.Request();
        }
    }
    class Target {
        public virtual void Request() {

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

        }
    }
}
