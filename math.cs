using System;
namespace Mathematics {

    public class Add {
        public Add (int a, int b) {
            System.Console.WriteLine("Addition: " + a + " + " + b + " = " + (a + b));
        }
    }

    public class Sub {
        public Sub (int a, int b) {
            System.Console.WriteLine("Subtraction: " + a + " - " + b + " = " + (a - b));
        }
    }

    public class Mul {
        public Mul (int a, int b) {
            System.Console.WriteLine("Multiplication: " + a + " * " + b + " = " + (a * b));
        }
    }

    public class Div {
        public Div (int a, int b) {
            System.Console.WriteLine("Division: " + a + " / " + b + " = " + (a / b));
        }
    }

    class Operations {
        static void Main(string[] args) {
            Console.WriteLine("Enter Two Numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Add addObj = new Add(a, b);
            Sub subObj = new Sub(a, b);
            Mul mulObj = new Mul(a, b);
            Div divObj = new Div(a, b);
        }
    }
}