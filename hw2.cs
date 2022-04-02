using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        Double c=Double.Parse(Console.ReadLine());
        int tip=Int32.Parse(Console.ReadLine());
        int tax=Int32.Parse(Console.ReadLine());
        Console.WriteLine("The total meal cost is "+Math.Round(c+c*tip/100+c*tax/100,0)+" dollars.");
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
    }
}