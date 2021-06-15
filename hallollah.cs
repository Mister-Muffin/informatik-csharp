using System;

namespace lel {

    class HalloIchBinEineKlasse {

        static void Main(string[] args) {

            String input = Console.ReadLine().ToLower();
            String output = "";

            for (int i = input.Length - 1; i >= 0; i--) {
                output += input[i];
            }

            if (input == output) Console.WriteLine($"{input} ist ein palindrom");
            else Console.WriteLine($"{input} ist kein palindrom");

        }
    }
}