using System;

namespace REIS {

    class DasIstDerMarkusUndDerMagVorangefertigteDateienMitVielReis {

        static void Main(string[] args) {
            Console.WriteLine("Program ready!\n--------------");

            const string alphabet = "abcdefghijklmnopqrstuvwxyz";

            var output = new String[25];
            Console.WriteLine("Bitte gib ein Wort oder Satz ein:");
            Console.Write("> ");
            var input = Console.ReadLine().ToLower();
            Console.WriteLine();

            for (int i = 0; i < alphabet.Length; i++) {
                for (int j = 0; j < input.Length; j++) {
                    if (input[j] == alphabet[i]) {
                        output[i] += alphabet[i];
                    }

                }
            }

            foreach (var item in output) {
                if (item != null) Console.WriteLine(item);
            }

        }


    }
}