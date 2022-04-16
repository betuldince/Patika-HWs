// See https://aka.ms/new-console-template for more information
using System;

namespace metotlar{


 class program{
static void Main(string[] args){
    string sayı="999";
    bool sonuc=int.TryParse(sayı, out int outsayı);
    if(sonuc){
        outsayı++;;
        Console.WriteLine(outsayı);
    }

    
    metot ins =new metot();
    ins.art(5,6,out int h);
    Console.WriteLine(h);

    int num=99;
    int num2=1;
    ins.printscreen(num,num2);
}


 }   
class metot{

    public void art(int a,  int b, out int toplam){
       toplam=a+b;

    }
    public void printscreen(string var){
    Console.WriteLine(var);
    }
    public void printscreen(int var, int var2){
    Console.WriteLine(var+var2);
    }



}



}



