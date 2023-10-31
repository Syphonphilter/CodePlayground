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
    public static string AddBinary(string a, string b)
    {
        UInt128 _a = UInt128.Parse(a, System.Globalization.NumberStyles.AllowHexSpecifier);
        UInt128 _b = UInt128.Parse(b, System.Globalization.NumberStyles.AllowHexSpecifier);
        UInt128 sum = _a + _b;
        return Convert.ToString((byte)sum, 2);
    }
}
