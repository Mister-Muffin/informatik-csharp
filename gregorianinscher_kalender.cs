using System;

namespace REIS {

    class DasIstDerMarkusUndDerMagReis {

        static void Main(string[] args) {

            bool reisanbau = false;
            long input = Convert.ToInt64(Console.ReadLine());
            if (input % 4 == 0 && input % 100 != 0 || input % 400 == 0) {
                Console.WriteLine("Der Markus mag Reis!");

            } else {
                Console.WriteLine("Heute mag der Markus kein Reis!");
            }
        }
    }
}