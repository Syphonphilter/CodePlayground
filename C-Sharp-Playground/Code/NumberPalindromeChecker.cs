namespace C_Sharp_Playground.Code
{
    public class NumberPalindromeChecker
    {
        public bool isPalindrome(int x)
        {
            bool response;
            char[] inputArray = x.ToString().ToCharArray();
            string[] outputarray = { };
            for (int i = inputArray.Length - 1; i >= 0; i--)
            {
                outputarray = outputarray.Append(inputArray[i].ToString()).ToArray();
            }
            string reversed = string.Join("", outputarray).ToString();
            response = x.ToString() == reversed ? true : false;
            return response;
        }
    }
}
