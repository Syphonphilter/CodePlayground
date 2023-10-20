using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Playground.Code;

class Program
{  

 
     static void Main()
    {
     Console.WriteLine(b2("abc##def","ab#def"));
    }
    static bool b2(string s, string t)
    {
      
      if(s.Length<1&&t.Length>200){
        return false;
      }
  
      do{
          if(s.Contains('#') || t.Contains('#')){
          Console.WriteLine(s.IndexOf('#'));
          s = new string(s.TakeWhile((c,i)=>  i<s.IndexOf('#')-1).ToArray())+s.Substring(s.IndexOf("#") + "#".Length);
          t = new string(t.TakeWhile((c,i)=>  i<t.IndexOf('#')-1).ToArray())+t.Substring(t.IndexOf("#") + "#".Length);
          
          }
          
      }while(s.Contains('#') || t.Contains('#'));
      
     return s==t;
                
      }
      
    
   
}
