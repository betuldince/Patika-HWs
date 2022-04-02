using System;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
             
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "betul";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g:" + g);

            

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);

            float w = 30.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            //ToString Metodu
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " + zz);

            //System.Covert Sınıfı
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("toplam: " + toplam);

            string metin1 = "10";
            int rakam1;
            rakam1 = Int32.Parse(metin1);
            Console.WriteLine("rakam1: " + rakam1);
         }

       
    }
}