namespace C_Sharp_Playground.Code
{
    public class FirstOccuranceIndex
    {
        public static int findingFirstOccuranceIndex(string needle, string haystack){
        string _haystack = haystack.ToLower();
        string _needle= needle.ToLower();
        return _haystack.IndexOf(_needle);
       
    }
    }
}