using System;

namespace IchBinEinProgramm {

    class Ehre {

        static void Main(string[] args) {

            Console.WriteLine("Bitte gib eine unnormale krasse Zahl ein.");
            int input = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(Math.Sqrt(input));

            for (int i = 2; i <= Math.Sqrt(input); i++) {
                if (input % i == 0) {
                    Console.WriteLine("Nö");
                    return;
                }
            }

            Console.WriteLine("ERROR! Java.lang.NullPointerException! at Line 4:5");

        }
    }
}