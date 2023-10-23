using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using C_Sharp_Playground.Code;
using Playground.Code;

class Program
{  

 
     static void Main()
    {
    
      Console.WriteLine(strStr("sad","sadbutsad"));
    }
    public static int strStr(string needle, string haystack){
        string _haystack = haystack.ToLower();
        string _needle= needle.ToLower();
        return _haystack.IndexOf(_needle);
       
    }



    
   
    
   
}
