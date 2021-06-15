using System;

namespace Lidl {

    class DasIstDerMarkusUndDerMagDieNiedrigenPreiseImLidl {

        static void Main(string[] args) {
            int day = 0;
            int month = 0;
            int year = 0;

            Console.WriteLine("Bitte gib ein Datum zwichen dem 1. März 2000 und dem 28. Februar 2100 ein.\n");

            String[] input = (Console.ReadLine()).Split(".");

            try {
                day = Convert.ToInt32(input[0]);
                month = Convert.ToInt32(input[1]);
                year = Convert.ToInt32($"{input[2][input.Length - 1]}{input[2][input.Length]}");

            } catch (Exception) {
                Console.WriteLine("Fehler: Bitte gib ein richtiges Datum ein!");
                System.Environment.Exit(1);
            }

            Console.WriteLine($"d={day} m={month} y={year}");

            if (day > 31 || month > 12) {
                Console.WriteLine("Feher: Bitte gib ein richtiges Datum ein!");
                System.Environment.Exit(1);
            } else if (Convert.ToInt32(input[2]) < 2000 || Convert.ToInt32(input[2]) > 2100) {
                Console.WriteLine("Bitte gib ein Datum zwischen dem 1 März 2000 bis zum 28. Februar 2100 ein");
                System.Environment.Exit(1);
            } else if (month < 3 && Convert.ToInt32(input[2]) <= 2000 || month > 2 && day > 28 && Convert.ToInt32(input[2]) >= 2100) {
                Console.WriteLine("Bitte gib ein Datum zwischen dem 1 März 2000 bis zum 28. Februar 2100 ein");
                System.Environment.Exit(1);
            }

            month -= 2;
            if (month < 1) {
                month += 12;
            }

            if (month >= 11) {
                year--;
            }

            Console.WriteLine($"month: {month}");

            int w = ((day + (int)(2.6 * month - 0.2) - 2 + year + (int)(year / 4) + 2) % 7);

            String output = "";

            switch (w) {
                case 0:
                    output = "Sonntag";
                    break;
                case 1:
                    output = "Montag";
                    break;
                case 2:
                    output = "Dienstag";
                    break;
                case 3:
                    output = "Mittwoch";
                    break;
                case 4:
                    output = "Donnerstag";
                    break;
                case 5:
                    output = "Freitag";
                    break;
                case 6:
                    output = "Samstag";
                    break;
                default:
                    output = "Fehler!";
                    break;
            }
            Console.WriteLine($"\nDer {String.Join(".", input)} ist ein {output}");
        }

    }
}