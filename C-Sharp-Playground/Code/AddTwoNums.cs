using Xunit;

namespace C_Sharp_Playground.Code
{
    public class AddTwoNums
    {
          public object AddTwoNumbers(ListNode l1, ListNode l2) {
            List<string> l1Array = new List<string>();
            List<string> l2Array = new List<string>();
    
           while(l1 !=null){
           l1Array.Add(l1.data.ToString());
            l1 = l1.next;
           }
           while(l2 !=null){
           l2Array.Add(l1.data.ToString());
            l1 = l1.next;
           }
           string concatenatedString = string.Join("", l1Array.ToArray());
           string concatenatedString2 = string.Join("", l2Array.ToArray());
           string sumTotal = (int.Parse(new string(concatenatedString.ToCharArray()).ToArray()) +
                        int.Parse(new string(concatenatedString2.ToCharArray()).ToArray())).ToString();
            sumTotal = sumTotal.Reverse().ToString();

            ListNode final = new ListNode();
            foreach(char item in sumTotal){
                int value = int.Parse(item.ToString());
                final.data = final.length==0?value:0;
                final = final.next;
                final.length++;
            }
            
            return final;


    }
       
    }
}