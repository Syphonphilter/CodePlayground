namespace C_Sharp_Playground.Code
{
    public class AddBinary
    {
        public static string AaddBinary(string a, string b)
        {
            UInt128 _a = UInt128.Parse(a, System.Globalization.NumberStyles.AllowHexSpecifier);
            UInt128 _b = UInt128.Parse(b, System.Globalization.NumberStyles.AllowHexSpecifier);
            UInt128 sum = _a + _b;
            return Convert.ToString((byte)sum, 2);
        }
    }
}