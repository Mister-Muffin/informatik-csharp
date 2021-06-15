using System;

namespace Calculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Gib eine Zahl ein.");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gib halt noch eine Zahl ein.");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 0;

            for (int i = a; i >= 1; i /= 2) {
                Console.Write("A: " + i);
                Console.WriteLine(" B: " + b);
                if (i % 2 != 0) {
                    c += b;
                }
                b *= 2;
            }

            Console.WriteLine("Krasses Ergebnis: 🙂 " + c);
        }
    }
}