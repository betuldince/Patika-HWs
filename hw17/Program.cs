// See https://aka.ms/new-console-template for more information
using System;

namespace metotlar{


 class program{
static void Main(string[] args){

    List<int> numbers = new List<int>();
    numbers.Add(2);
    numbers.Add(3);
    numbers.Add(5);
    numbers.Add(6);

    //Console.WriteLine(numbers.Count);

    foreach(var num in numbers){
       // Console.Write(num);
    }

    //numbers.Remove(3);
    numbers.ForEach(num=> Console.WriteLine(num));

    numbers.RemoveAt(1);
    numbers.ForEach(num=> Console.WriteLine(num));

    if(numbers.Contains(3)){
        Console.WriteLine("here");
    }else{
        Console.WriteLine("no 3 present");
    }
    //6'nın kacıncı indexte oldugunu verdi
    Console.WriteLine(numbers.BinarySearch(6));

    //Array to list
    string[] animals={"cow", "cat", "dog"};
    List<string> animals2=new List<string>(animals);
    animals2.ForEach(anm=> Console.WriteLine(anm));

    //animals2.Clear();

    List<users> userList=new List<users>();

    users user1= new users();
    user1.Name="bet";
    user1.Lastname="din";
    user1.Age=22;

    users user2 =new users();
    user2.Name="ege";
    user2.Lastname="tez";
    user2.Age=23;

    userList.Add(user1);
    userList.Add(user2);

    userList.Add(new users(){
        Name="iro",
        Lastname="unv",
        Age=66
    }
    
    );


    foreach(var user in userList){
        Console.WriteLine(user.Name);
        Console.WriteLine(user.Lastname);
        Console.WriteLine(user.Age);
    }

    List<users> userList2= new List<users>();
    userList2.Add(new users(){
        Name="rem",
        Lastname="din",
        Age=54

    });




    }

 }

 public class users{
     string name;

     string lastname;

     int age;

        public string Lastname { get => lastname; set => lastname = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
    }
 
 
 }   
