using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Playground.Code;

class Program
{  

 
     static void Main()
    {
      BackspaceCompare("we#rt","");
    }
    static bool BackspaceCompare(string s, string t)
    {
      if(!s.Contains("#")||!t.Contains("#")){
        return false;
        
      }
      s= new string(s.ToArray().TakeWhile((c,i)=> ) );
      for( char x  in s )
      {
        Console.WriteLine(x);
      
      }
      return true;
                
      }
      
    
   
}
