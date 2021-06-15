using System;

namespace REIS {

    class DasIstDerMarkusUndDerMagVorangefertigteDateienMitVielReis {

        static void Main(string[] args) {
            Console.WriteLine("Program ready!\n--------------");

            string[] input;

            Console.WriteLine("Bitte gib ein Datum in dem Format dd.mm.yyyy ein:");
            Console.Write("> ");

            try {
                input = (Console.ReadLine().Split("."));
            } catch {
                Console.WriteLine("Bitte gib eine Zahl ein!");
                return;
            }

            Console.WriteLine($"Dein eingegebenes Datum in der {Convert.ToInt32(input[1]) * 30 + Convert.ToInt32(input[0])}ste Tag in Jahr");

        }


    }
}