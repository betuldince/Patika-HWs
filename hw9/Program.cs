// See https://aka.ms/new-console-template for more information
using System;

namespace Name
{
    class Program{



        static void Main(string [] args){
        
        int[]sayıdizi={1,5,4,3,2};
        Array.Sort(sayıdizi);

        // foreach(var say in sayıdizi){
        //  Console.WriteLine( say);

        // }

        Array.Clear(sayıdizi,2,2);

        // foreach(var say in sayıdizi){
        //  Console.WriteLine(say);
        // }
        
        Array.Reverse(sayıdizi);
        foreach(var say in sayıdizi){
         Console.WriteLine(say);
        }        
        

        }




    }
    
}