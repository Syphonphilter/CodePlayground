namespace C_Sharp_Playground.Code
{
    public class MinMaxSum
    {
        public static void miniMaxSum(List<int> arr)
    {
        
        
        List<long> arr_long = (from c in arr select (long)c).ToList();
        arr_long.Sort();
        long lr = 0;
        long rl = 0;
        lr = arr_long.Take(arr_long.Count-1).Sum();
        rl = arr_long.Skip(1).Sum();
        Console.WriteLine(lr+" "+rl);
    }
    }
}