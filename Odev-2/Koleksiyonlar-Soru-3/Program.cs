using System;
using System.Collections;
using System.Collections.Generic;
namespace question1{
class Program{
static void Main(string[] args){

List<string> vowels= new List<string>();
string sent="";
sent=sent+Console.ReadLine();
string[] vow={"a","e","ı","i","ö","ü","u"};
    for(int j=0;j<vow.Length;j++){
        if(sent.Contains(vow[j])){
            vowels.Add(vow[j]);
        }

    }

foreach(var i in vowels){
Console.WriteLine(i);

}



}
}}
