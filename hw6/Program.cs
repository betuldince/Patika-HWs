using System;

namespace Loops {
    class Program {
        static void Main (string[] args) {
            //Ekrana girilen sayıya kadar olan tek sayıları ekrana yazdır.

            Console.WriteLine ("enter number");

            int sayac = int.Parse (Console.ReadLine());

            for (int i = 1; i <= sayac; i++) {

                if (i % 2 == 1) {
                    Console.WriteLine (i);
                }
            }

            //1 ile 1000 arasındaki tek ve çift sayıların toplamını ekrana yazdır.
            int oddSum = 0;
            int evenSum = 0;

            for (var i = 1; i <= 1000; i++) {
                if (i % 2 == 1) {
                    oddSum += i;
                } else {
                    evenSum += i;
                }
            }

            Console.WriteLine ("odd: " + oddSum);
            Console.WriteLine ("even: " + evenSum);

            //break, continue
            for (int i = 1; i <= 10; i++) {
                if (i == 4)
                    break;
                Console.WriteLine (i);
            }

            for (int i = 1; i <= 10; i++) {
                if (i == 4)
                    continue;
                Console.WriteLine (i);
            }

            // While
            // 1 den başlayarak konsoldan girilen sayıya kadar sayı dahil ortalama hesaplayıp konsola yazdıran program

            Console.Write ("Bir sayı giriniz");
            int number = int.Parse (Console.ReadLine ());
            int counter = 1;
            int summary = 0;
            while (counter <= number) {
                summary += counter;
                counter++;
            }

 

            

        }
    }
}