// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;
namespace question1{
class Program{
static void Main(string[] args){

ArrayList asal = new ArrayList();
ArrayList not_asal = new ArrayList();

for(int i=0;i<20;i++){
    bool isNumber= int.TryParse(Console.ReadLine(), out int number );
    if(isNumber){
        if(IsPrime(number)){
            asal.Add(number);
        }else{
            not_asal.Add(number);
        }
    }
}
Console.WriteLine("Asal");
asal.Sort();
asal.Reverse();
foreach(var k in asal){
    Console.WriteLine(k);
}
Console.WriteLine("Asal Olmayanlar");
not_asal.Sort();
not_asal.Reverse();
foreach(var k in not_asal){
    Console.WriteLine(k);
}
Console.WriteLine("Asal Eleman Sayısı:");
Console.WriteLine(asal.Count);
Console.WriteLine("Asal Ortalaması:");
double top=0;
foreach(var i in asal){
    top=top+Convert.ToDouble(i);

}
Console.WriteLine(top/asal.Count);

Console.WriteLine("Asal Olmayan Eleman Sayısı:");
Console.WriteLine(not_asal.Count);
Console.WriteLine("Asal Olmayan Ortalaması:");
double top2=0;
foreach(var i in not_asal){
    top2=top2+Convert.ToDouble(i);

}
Console.WriteLine(top2/not_asal.Count);





}
public static bool IsPrime(int number)
{

    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    var boundary = (int)Math.Floor(Math.Sqrt(number));
          
    for (int i = 3; i <= boundary; i += 2)
        if (number % i == 0)
            return false;
    
    return true;        
}


}}

