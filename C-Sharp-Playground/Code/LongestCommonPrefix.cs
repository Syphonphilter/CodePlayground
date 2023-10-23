using System;
namespace Playground
{
	public partial class LongestCommonPrefix
	{
        public static string LongestCommonPrefix_v1(string[] strs) {
            //finds the min value in the array
            var commonPrefix = new string(strs.MinBy(s => s.Length)
            // using the takeWhile  loop fuction with the lambda expression to get each
            // char for the min value and match across all the values in the array where each char
            // matches the min value until it does not match and return the longest common prefix
            .TakeWhile((c, i) => strs.All(s => s[i] == c)).ToArray());
          return commonPrefix;
        }
//
        public static string LongestCommonPrefix_v2(string[] strs)
        {
            //if array length == 0 
            if (strs.Length == 0)
            {
                return "";
            }
            //sort arrar
            Array.Sort(strs);
            //init prefix
            string prefix = "";
            // loop through all the chars of  the first index of the array
            for (int i = 0; i < strs[0].Length; i++)
            {
                //add char of first index to a c variable
                char c = strs[0][i];
                //loop though the rest of the array 
                for (int j = 1; j < strs.Length; j++)
                {
                    // check if index i > or eqal the length of the next item of in array or 
                    // the next item in the array for char i iz not equal c then return prefix
                    if (i >= strs[j].Length || strs[j][i] != c)
                    {
                        return prefix;
                    }
                }
                // add c to prefix
                prefix += c;
            }
            return prefix;
        }

	}
}

