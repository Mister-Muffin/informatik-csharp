using System;

namespace REIS {

    class DasIstDerMarkusUndDerMagVorangefertigteDateienMitVielReis {

        static void Main(string[] args) {
            Console.WriteLine("Program running!");

            Random rnd = new Random();
            double[] point = new double[2];

            var hit = 0;
            var points = 0;

            for (int i = 0; i < 10000000; i++) {

                point[0] = rnd.NextDouble();
                point[1] = rnd.NextDouble();
                if (Math.Sqrt(Math.Pow(point[0], 2) + Math.Pow(point[1], 2)) <= 1) {
                    hit++;
                }

                points++;


            }
            Console.WriteLine("PI:         " + Math.PI);
            Console.WriteLine($"Simulation: {(decimal)4 * hit / points}");


        }
    }
}