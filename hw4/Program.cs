using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    
    private static string isWeird(int N){
        string wr="Not Weird";
        if(N>100 || N <1){
            wr="Weird";
        }
        if(N%2==1){
            wr="Weird";
        }else{
            if((N>=2 && N<=5) ||N>20){
               wr="Not Weird";    
            }else if(N>=6 && N<=20){
                wr="Weird";
                
            }
        }
        
        return wr;
    }
    
    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());
        string wr= isWeird( N);
        
        Console.WriteLine(wr);
    }
}
