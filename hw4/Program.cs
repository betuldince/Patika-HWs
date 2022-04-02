using System;

namespace ConsoleProgramming
{
    class Program
    {
               static void Main(string[] args)
        {
           int time= DateTime.Now.Hour;

           string sonuc= time<=18 ? "good morning" : "good afternoon";
           Console.WriteLine(sonuc);
           
         }
    }
}