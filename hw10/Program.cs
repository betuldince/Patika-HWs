// See https://aka.ms/new-console-template for more information
using System;

namespace Name
{
    class Program{



        static void Main(string [] args){
        
        int a=3;
        int b=5;

        int sonuc=Multp(a,b);
       Console.WriteLine(sonuc);
        
        func printit= new func();
        printit.printmet(Convert.ToString(sonuc));

        int c=3;
        int d=9;
        int sonuc2=Multp2(ref c, ref d);
       Console.WriteLine(sonuc2);

        }
        static int Multp(int bir, int iki){
            return iki*bir;

        }
        static int Multp2(ref int bir, ref  int iki){
            return iki*bir;

        }



        class func{
        public void printmet(string var){
            Console.WriteLine(var);
        }

        }




    }
    
}