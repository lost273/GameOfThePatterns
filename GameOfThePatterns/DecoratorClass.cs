using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThePatterns {
    abstract class Printer {
        public Printer(string n) {
            this.Name = n;
        }
        public string Name { get; protected set; }
    }
    class LaserPrinter : Printer {
        public LaserPrinter() : base("Laser printer"){

        }
    }
    class InkPrinter : Printer {
        public InkPrinter() : base("Ink printer"){

        }
    }
    abstract class PrinterDecorator : Printer{
        protected Printer printer;
        public PrinterDecorator(string n, Printer p) : base(n) {
            printer = p;
        }
        
    }
    //additional functionality
    class ColorPrint : PrinterDecorator {
        public ColorPrint(Printer p) : base(p.Name + ", with color printing",p){
        }

    }
    class LetsDecoratorGame {
        public static void Start() {

        }
    }
}
