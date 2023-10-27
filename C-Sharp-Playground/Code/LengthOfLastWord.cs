using System.Text.RegularExpressions;

public class LengthOfLastWord
{
    public static int LengthOfLastWord_regex(string s)
    {
        Regex regex1 = new Regex(@"[A-Za-z]+");
        MatchCollection words = regex1.Matches(s);
        Console.WriteLine(words[words.Count - 1]);
        return words[words.Count - 1].Length;

    }
    public static int LengthOfLastWord_charArray(string s)
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