 public class BackspaceCompare{

 
 bool BackspaceCompare_v1(string s, string t)
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