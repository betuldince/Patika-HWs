using System;
using System.Collections;
using System.Collections.Generic;
namespace question1{
class Program{
static void Main(string[] args){
int m=20;
int [] numarray= new int[m];
for(int i=0;i<m;i++){
numarray[i]=int.Parse(Console.ReadLine());
}
Array.Sort(numarray);
foreach(var val in numarray){
    Console.WriteLine(val);
}
int[] low= new int [3];
int[] high= new int [3];

for(int i=0;i<3;i++){
    low[i]=numarray[i];
    high[i]=numarray[m-i-1];
}
Console.WriteLine( "Lowest 3");
foreach(var v in low){
    Console.WriteLine(v);
}
Console.WriteLine( "Highest 3");
foreach(var v in high){
    Console.WriteLine(v);
}
double top_l=0;
double top_h=0;
foreach(var v in low){
    top_l=top_l+v;
}
foreach(var v in high){
    top_h=top_h+v;
}
Console.WriteLine( "Mean of Lowest 3");
Console.WriteLine(top_l/3);
Console.WriteLine( "Mean of Highest 3");
Console.WriteLine(top_h/3);
Console.WriteLine( "Addition of Means");
Console.WriteLine((top_h+top_l)/3);


}}}

