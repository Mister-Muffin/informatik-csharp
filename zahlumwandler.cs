using System;

namespace REIS {

    class DasIstDerMarkusUndDerMagVorangefertigteDateienMitVielReis {

        static void Main(string[] args) {


            Console.WriteLine("Program ready!\n--------------");

            Console.WriteLine("Bitte gib eine beliebige, benär Zahl ein:");
            Console.Write("> ");

            string input = Console.ReadLine();
            
            int output = 0;
            for (int i = input.Length - 1; i >= 0; i--) {
                output += Convert.ToInt32(input[i].ToString()) * (int) Math.Pow(2, input.Length -1 - i);
            }
            Console.WriteLine(output);

        }

    }
}