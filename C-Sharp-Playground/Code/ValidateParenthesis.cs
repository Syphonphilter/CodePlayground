  public class ValidateParenthesis{
    public static bool IsValid(string s) {
    bool isvalid = false;
    Stack<string> openParenthesis = new Stack<string>();
    Dictionary<string,string> parenthesisDict = new Dictionary<string, string>(){
      {"{","}"},
      {"[","]"},
      {"(",")"}
    };
    if(s.Length%2!=0){
       return isvalid;
    }
    else{
    for(int i = 0 ; i<= s.Length-1; i ++){
        if(parenthesisDict.ContainsKey(s[i].ToString()) ){
        openParenthesis.Push(s[i].ToString());
        }
        else if(openParenthesis.Count==0){
            break;
        }
        else{
            string topElement = openParenthesis.Peek();
            string cvalue = parenthesisDict[topElement];
            if(s[i].ToString()!=cvalue || cvalue == null){
                isvalid = false;
                break;
            }
            else{
                openParenthesis.Pop();
            }
                
            }
    isvalid = openParenthesis.Count==0? true :false;    
    }
    }
    return isvalid;
    }

  }