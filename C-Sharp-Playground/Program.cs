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
        Console.WriteLine(ClimbStairs(44));

    }
    /// <summary>
    /// Calculates the number of distinct ways to climb to the top of a staircase with the given number of steps.
    /// </summary>
    /// <param name="num">The number of steps in the staircase.</param>
    /// <returns>The number of distinct ways to climb to the top of the staircase.</returns>
    public static int ClimbStairs(int num)
    {
        int[] dp = new int[num + 1];
        dp[0] = 1;
        dp[1] = 1;

        for (int i = 2; i <= num; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }

        return dp[num];
    }
    /// End Code Snippet ///
}
