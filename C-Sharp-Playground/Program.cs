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
        AddBinary("1110001", "110100100");

    }
    public static int MySqrt(int num)
    {
        int val = 0;
        for (int i = 1; i < 10; i++)
        {
            if (i * i > num)
            {
                break;
            }
            val = i;
        }
    
    }
}
