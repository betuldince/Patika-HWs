// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

namespace metotlar{


 class program{
static void Main(string[] args){

    ArrayList liste = new ArrayList();
    liste.Add("bet");
    liste.Add(2);
    liste.Add(true);
    liste.Add("harun");

    Console.WriteLine(liste[1]);

    //Add range
    string[] colors={"blue", "yellow", "green","red"};
    List<int> numbers= new List<int>(){1,2,3,4,3};
    liste.AddRange(colors);
    liste.AddRange(numbers);

    foreach (var item in liste)
    {
        Console.WriteLine(item);        
    }

    // liste.Sort();
    // liste.BinarySearch(4);
    // liste.Reverse();
    // liste.Clear();

    }

 }
 }   
