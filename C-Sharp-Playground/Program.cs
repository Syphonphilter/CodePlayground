using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using C_Sharp_Playground.Code;
using Playground.Code;

class Program
{  

 
     static void Main()
    {
    
      var fruits = new List<string>
        {
            "apple", "banana", "cherry", "apple", "date", "banana"
        };

// Create a lookup table based on the length of each fruit name
var lookup = fruits.ToLookup(fruit => fruit.Length);
foreach(var f in lookup[4]){
    Console.WriteLine(f);
    }
    }
    public static int strStr(string needle, string haystack){
        haystack = haystack.ToLower();
        needle = needle.ToLower();
        return 1;
    }



    
   
    
   
}
