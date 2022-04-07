// See https://aka.ms/new-console-template for more information
using System;

namespace Program{

    class homework{

    static void Main(string[]args){
    //Part 1    

    Console.WriteLine("enter positive number");

    int num= int.Parse(Console.ReadLine());
    while(num%2==1){
    Console.WriteLine("Error! enter positive number"); 
    Console.WriteLine("enter positive number");
    num= int.Parse(Console.ReadLine());

    }
    Console.WriteLine("enter "+num+ " positive number");  

    


    int[] num_array=new int[num];
    for(int i=0;i<num;i++){
    num_array[i]=int.Parse(Console.ReadLine());    
    }
    Console.Write("positive numbers ");

    for(int i=0;i<num;i++){
        if(num_array[i] %2==0){
    
        Console.Write( num_array[i]+ " ");

        }  
    }

    //Part 2
    Console.WriteLine("Second part");
    Console.WriteLine("enter two numbers");  
    int n=int.Parse(Console.ReadLine());
    int m=int.Parse(Console.ReadLine());

    Console.WriteLine("enter "+ n + " numbers" );  

    int []dizi=new int[n];

    for(int i =0; i<n;i++){
    dizi[i]=int.Parse(Console.ReadLine());    

    }
    for(int i=0; i<n;i++){
        if(dizi[i]%m==0){
            Console.Write(dizi[i]+" ");
        }

    }
    //part3
    Console.WriteLine("third part");

    Console.WriteLine("enter numbers" );  
    int num3=int.Parse(Console.ReadLine());
    Console.WriteLine("enter words" );  
    string[] str=new string[num3];

    for(int i=0;i<num3;i++){
        str[i]=Console.ReadLine();

    }

    for(int i=num3-1;i>=0;i--){
        Console.Write(str[i]+" ");

    }

    //part 4
    Console.WriteLine("");

    Console.WriteLine("fourth part");

    Console.WriteLine("enter sentence");
    string str2;
    str2 =Console.ReadLine();
    string[] str_arr=str2.Split(' ');
    int wn=str_arr.Length;
    Console.Write("word count "+wn);

    foreach(var wr in str_arr){

    }
    int num_h=str2.Replace(" ","").Length;
    Console.Write(" letter count  "+num_h);
   


    }   








    }

}