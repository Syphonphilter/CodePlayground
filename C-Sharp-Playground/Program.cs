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
using C_Sharp_Playground.Code.Functions;

class Program
{


    static void Main()
    {
        List<int> ints = new List<int>();
        ints.Add(10);
        ints.Add(5);
        ints.Add(20);
        ints.Add(20);
        ints.Add(2);
        ints.Add(5);
        ints.Add(25);
        ints.Add(1);
        Console.WriteLine(breakingRecords(ints));

    }
    public static List<int> breakingRecords(List<int> scores)
    {
        int maxScore = scores[0];
        int minScore = scores[0];
        List<int> recordSheet = new List<int> { 0, 0 };

        for (int i = 1; i < scores.Count; i++)
        {
            if (scores[i] > maxScore)
            {
                maxScore = scores[i];
                recordSheet[0]++;
            }
            else if (scores[i] < minScore)
            {
                minScore = scores[i];
                recordSheet[1]++;
            }
        }

        return recordSheet;
    }
}
