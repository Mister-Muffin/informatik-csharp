using System;

namespace REIS {

    class DasIstDerMarkusUndDerMagVorangefertigteDateienMitVielReis {

        static void Main(string[] args) {
            long counter = 0;

            Console.WriteLine("Program ready!\n--------------");

            ulong a = 1;

            Console.WriteLine("Bitte gib eine beliebige, natürliche Zahl ein:");
            Console.Write("> ");
            try {
                a = Convert.ToUInt64(Console.ReadLine());
            } catch {
                Console.WriteLine("Bitte eine richtige Zahl ein!");
            }
            DateTime start = DateTime.UtcNow;

        two:
            if (a == 1) {
                Console.WriteLine($"Total interations: {counter}, took {Convert.ToInt32((DateTime.UtcNow - start).TotalMilliseconds)}ms");
                return;
            }

            if (a % 2 == 0) a /= 2;
            else a = a * 3 + 1;
            counter++;
            Console.WriteLine(a);
            goto two;

        }

    }
}