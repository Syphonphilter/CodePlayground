namespace C_Sharp_Playground.Code
{
    public class PlusMinusRatio
    {
        public string[] _PlusMinusRatio(List<int> s){
        List<int> pos = new List<int>();
        List<int> _zeros = new List<int>();
        List<int> neg = new List<int>();
        s.Sort();
        pos = (from item in s where item>0 select item).ToList();
        _zeros = (from item in s where item==0 select item).ToList();
        neg = (from item in s where item<0 select item).ToList();

        var _pos_six =((double)pos.Count/(double)s.Count).ToString("0.000000");
        var _neg_six  =((double)_zeros.Count/(double)s.Count).ToString("0.000000");
        var _zero_six =((double)neg.Count/(double)s.Count).ToString("0.000000");
        string [] ratio_array = {_pos_six,_neg_six,_zero_six};
        return ratio_array;
    }
    }
}