using System;

namespace REIS {

    class DasIstDerMarkusUndDerMagReis {

        static void Main(string[] args) {

            String inp = Console.ReadLine();

            for (int i = 0; i < inp.Length; i++) {
                if (inp[i] != ' ') {
                    Console.Write(inp[i]);
                } else {
                    Console.Write("\n");
                }
            }
            Console.WriteLine();

        }
    }
}