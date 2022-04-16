// See https://aka.ms/new-console-template for more information
using System;

namespace metotlar{


 class program{
static void Main(string[] args){
    islem ins=new();
    Console.WriteLine(ins.fact(5,4));
    string name="betul dincer";
    Console.WriteLine(exten.space(name));
    Console.WriteLine(exten.removeit(name));
    string name2="betul dincer 23 years";
    string [] dizi2=name2.Split(" ");
    Console.WriteLine(dizi2[2]);
    int [] numbers={1,4,3,2,5,6,8};
    exten.sortArray(numbers);
    foreach(int var in numbers){
        Console.Write(var+" ");
    }

 }}   
public class islem{

    public int fact(int say1,int say2){
        if(say2<2)
            return say1;
        return fact(say1,say2-1)*(say1);
     
    }}
    public static class exten{
        public static bool space(this string param){
            return param.Contains(" ");

        }
        public static string removeit(this string param){
            string[] dizi=param.Split(" ");
            return string.Join("!",dizi);
                    }

        public static int[] sortArray(this int[] param){
            Array.Sort(param);
            return param;
        }

    }


}



