using System.Text.RegularExpressions;

namespace C_Sharp_Playground.Code
{
    public class ValidPalindromeChecer
    {
        public bool isPalindrome(string s)
        {
            s = s.ToLower();
            bool response;
            char[] inputArray = (from c in s where Char.IsLetter(c) || Char.IsDigit(c) select c).ToArray();
            string reverse = string.Join("", inputArray.Reverse());
            string final = string.Join("", inputArray);
            response = reverse == final ? true : false;
            return response;
        }
    }
}
