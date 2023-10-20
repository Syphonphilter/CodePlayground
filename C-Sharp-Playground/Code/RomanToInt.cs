using System;
namespace Playground
{
	public class RomanToInt
	{
        // a program that converts roman numerals to integers 
        int RomanToInteger(string s)
        {
            int currentVal = 0;
            int PreviousVal = 0;
            int totalVal = 0;
            char[] splitedRomanChars = s.ToUpper().ToCharArray();
            Dictionary<string, int> romanNumDictionary = new Dictionary<string, int>
        {
            
            {"I",1},
            {"V",5},
            {"X",10},
            {"L",50},
            {"C",100},
            {"D",500},
            {"M",1000}
        };
        //

            for (int c = splitedRomanChars.Length - 1; c >= 0; c--)
            {
                if (!romanNumDictionary.ContainsKey(splitedRomanChars[c].ToString()))
                {
                    break;
                }
                else
                {
                    currentVal = romanNumDictionary[splitedRomanChars[c].ToString()];
                    if (currentVal < PreviousVal)
                    {
                        totalVal -= currentVal;
                    }
                    else
                    {
                        totalVal += currentVal;
                    }
                }
               
            }
            return totalVal;

        }


	}
}

