using System;

namespace Loops {
    class Program {
       
       static void Main(string[] args){
       int say=int.Parse(Console.ReadLine());

       int sum= 1;
       int first=1;
       while(first<=say){
           
           sum=sum*first;
           first++;
       }
       Console.WriteLine(sum);

        string[] araba={"a1", "a2", "a3"};
        foreach(var a in araba){
            Console.WriteLine(a);

        }
       }



    }
}