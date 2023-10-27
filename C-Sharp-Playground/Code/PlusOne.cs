using System.Numerics;

public class PlusOne
{
    public static int[] PlusOne_slow(int[] digits)
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