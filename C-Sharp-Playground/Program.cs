﻿using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using C_Sharp_Playground.Code;
using Playground.Code;
using Xunit.Sdk;

class Program
{


    static void Main()
    {
        LengthOfLastWord("a");

    }
    public static int LengthOfLastWord(string s)
    {

        int count = 0;
        var stringArray = s.ToCharArray();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            count = char.IsWhiteSpace(stringArray[i]) || char.IsDigit(stringArray[i]) ? count = count : count += 1;
            if (count > 0 && (char.IsWhiteSpace(stringArray[i]) || char.IsDigit(stringArray[i])))
            {
                break;
            }
        }
        return count;


    }
}
