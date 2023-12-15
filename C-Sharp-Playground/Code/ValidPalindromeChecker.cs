using System.Text.RegularExpressions;

namespace C_Sharp_Playground.Code
{
    public class ValidPalindromeChecer
    {
        public bool isPalindrome(string s)
        {
            bool response;
            char[] inputArray = s.ToCharArray();
            string[] outputarray = { };

            for (int i = 0; i <= s.Length - 1; i++)
            {
                outputarray = Regex.IsMatch(s, "[a-zA-Z]") ? outputarray : outputarray.Append(inputArray[i].ToString()).ToArray();
            }
            string reverse = string.Join("", outputarray.Reverse());
            string final = string.Join("", outputarray).ToString();
            response = reverse == final ? true : false;
            return response;
        }
    }
}
