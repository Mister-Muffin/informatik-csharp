using System;

namespace REIS {

    class DasIstDerMarkusUndDerMagVorangefertigteDateienMitVielReis {

        static void Main1(string[] args) {
            Console.WriteLine("Program ready!");

            int input = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (input > 0) {
                sum += input % 10;
                input /= 10;
            }

            Console.WriteLine(sum);

        }

        static void Main2(string[] args) {
            Console.WriteLine("Program ready!");

            double gelt = Convert.ToDouble(Console.ReadLine());
            double zinssatz = Convert.ToDouble(Console.ReadLine()) / 100;
            double jahre = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < jahre; i++) {
                gelt += zinssatz * gelt;
            }
            Console.WriteLine(gelt);
        }

        static void Main3(string[] args) {
            Console.WriteLine("Program ready!");
            int input = Convert.ToInt32(Console.ReadLine());
            string output = "";

            while (input > 0) {
                if (input % 2 > 0) {
                    output += 1;
                } else {
                    output += 0;
                }
                input /= 2;
            }

            Console.WriteLine(output);


        }

        static void Main4(string[] args) {
            Console.WriteLine("Program ready!");

            var input = Console.ReadLine();
            var letter = Console.ReadLine()[0];
            var counter = 0.0;

            for (var i = 0; i < input.Length; i++) {
                if (input[i] == letter) counter++;
            }

            Console.WriteLine(counter / input.Length * 100 + "%");
        }

        static void Main(string[] args) {
            Console.WriteLine("Program ready!");


            if (mike.lässtDenWlanSteckerStecken) {
                Console.WriteLine("jees");

            }
        }


    }

    public static class mike {
        public static bool lässtDenWlanSteckerStecken = true;
    }
}