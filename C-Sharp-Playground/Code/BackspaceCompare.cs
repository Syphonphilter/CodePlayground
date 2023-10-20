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

       static bool BackspaceCompare_v2(string s, string t)
        {
        Stack<string> s1 = new Stack<string>();
        Stack<string> s2 = new Stack<string>();
        foreach(char x in s){
            if(x=='#'&& s1.Count>0){
            s1.Pop();
            }
            else {
            s1.Push(x.ToString());
            }
            
        }
        foreach(char x in t){
            if(x=='#'&& s2.Count>0){
            s2.Pop();
            }
            else {
            s2.Push(x.ToString());
            }
            
        }
        
        
        return s1.SequenceEqual(s2);
                    
        }
      
 }