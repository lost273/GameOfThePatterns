using System;

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
    //additional functionality
    class MonoPrint : PrinterDecorator {
        public MonoPrint(Printer p) : base(p.Name + ", with mono printing", p) {
        }
    }
    //additional functionality
    class BorderlessPrint : PrinterDecorator {
        public BorderlessPrint(Printer p) : base(p.Name + ", with borderless printing", p) {
        }
    }

    class LetsDecoratorGame {
        public static void Start() {
            Printer printerHP = new LaserPrinter();
            printerHP = new MonoPrint(printerHP);

            Printer printerSamsung = new InkPrinter();
            printerSamsung = new ColorPrint(printerSamsung);
            printerSamsung = new MonoPrint(printerSamsung);
            printerSamsung = new BorderlessPrint(printerSamsung);
            Console.WriteLine($"First printer - {printerHP.Name}");
            Console.WriteLine($"Second printer - {printerSamsung.Name}");
        }
    }
}
