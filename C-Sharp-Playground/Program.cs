using System.Runtime.InteropServices.ComTypes;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using C_Sharp_Playground.Code;
using Playground.Code;
using Xunit.Sdk;
using System.Numerics;

class Program
{


    static void Main()
    {
        int[] d = { 7,2,8,5,0,9,1,2,9,5,3,6,6,7,3,2,8,4,3,7,9,5,7,7,4,7,4,9,4,7,0,1,1,1,7,4,0,0,6 };
        PlusOne(d);

    }
    public static int[] PlusOne(int[] digits)
    {
        var concatDigits = BigInteger.Parse(string.Join("", digits)) + 1;
        string counter = concatDigits.ToString();

        digits = counter.Length > digits.Length ? new int[counter.Length] : digits;
        for (int i = 0; i <= counter.Length - 1; i++)
        {
            Console.WriteLine(counter[i]);
            digits[i] = int.Parse(counter[i].ToString());
        }
        return digits;
    }
}
