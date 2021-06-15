using System;

namespace IchBinEinProgramm {

    class Ehre {

        static void Main(string[] args) {

            Console.WriteLine("Running, give me a sec. :)");

            int runs = 0, found = 0;

            int[] day = new int[2];
            int[] month = new int[2];
            int[] year = new int[4];

            string palindrom = "";

            for (int yr = 0000; yr <= 2100; yr++) {

                for (int mon = 1; mon <= 12; mon++) {

                    for (int dy = 1; dy <= 31; dy++) {

                        day[0] = dy / 10;
                        day[1] = dy % 10;
                        month[0] = mon / 10;
                        month[1] = mon % 10;
                        year[0] = yr / 1000;
                        year[1] = yr % 1000 / 100;
                        year[2] = yr % 100 / 10;
                        year[3] = yr % 10;

                        string date = $"{day[0]}{day[1]}{month[0]}{month[1]}{year[0]}{year[1]}{year[2]}{year[3]}";
                        string date2 = $"{day[0]}{day[1]}.{month[0]}{month[1]}.{year[0]}{year[1]}{year[2]}{year[3]}";
                        //Console.WriteLine(date);

                        if (date == Reverse(date)) {
                            found++;
                            palindrom = palindrom + $"\n{date2}";
                            //Console.WriteLine(date);
                        }

                        runs++;

                        Array.Reverse(palindrom.ToCharArray());

                        // #modulbausteinistgleichmodulo

                    }
                }
            }

            Console.Write("\n" + palindrom);
            Console.Write("\n--------------");
            Console.Write("\nRuns: " + runs);
            Console.Write("\nFound: " + found);
            Console.Write("\nJava.lang.NullPointerException at line 23;56");
            Console.Write("\n***Finished***");
            Console.Write("\n");

        }

        public static string Reverse(string s) {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}