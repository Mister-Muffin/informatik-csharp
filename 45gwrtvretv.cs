using System;

namespace lel {

    class HalloIchBinNochEineKlasse {

        static void Main(string[] args) {

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            
            int x = a;
            int y = 0;

            while (x >= b) {
                x-=b;
                y++;
            }

            Console.WriteLine($"Zu {a} und {b} lautet der Rest {x}");
            Console.WriteLine($"Zu {a} und {b} lautet der Divisionsergebnis {y}");

        }
    }
}