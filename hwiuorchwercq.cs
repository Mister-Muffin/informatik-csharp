using System;
namespace Primzahltest {
    class Program {

        static void Main(string[] args) {
            // Variablendeklaration
            long Kandidat = 1; long Rest = 0;
            // Überschrift
            Console.WriteLine("Primzahltest in C#\r");
            Console.WriteLine("------------------------\n");
            // Eingabe potentielle Primzahl
            Console.WriteLine("Welche Zahl soll untersucht werden?");

            Kandidat = Convert.ToInt64(Console.ReadLine());

            bool priim = true;

            int Teiler = 2;
            while (Teiler <= Math.Sqrt(Kandidat) && priim) {

                Rest = Kandidat % Teiler;

                priim = Rest != 0;

                Teiler++;
            }
            if (!priim) {
                Console.WriteLine($"Your result: {Kandidat}" + " ist keine Primzahl");
            } else {
                Console.WriteLine($"Your result: {Kandidat}" + " ist eine Primzahl");
            }
            Console.WriteLine();

        }

    }

}