namespace Playground.Code
{
    public class RemoveDuplicates
    {
        static int LeetCodeRemoveDuplicates_(int[] nums)
    {
        int k = 1;
        if (nums.Length == 0)
        {
            return 0;
        }

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[k++] = nums[i];
            }
        }

        return k;
    }
   static int myVersionRemoveDuplicates(int[] nums) {
    int k = 0;
    Dictionary<int, string> uniqueNums = new Dictionary<int, string>();
    
    for (int i = 0; i < nums.Length; i++) {
        if (!uniqueNums.ContainsValue(nums[i].ToString())) {
            uniqueNums.Add(i, nums[i].ToString());
        }
    }
    
    k = uniqueNums.Keys.Count;

    for (int i = uniqueNums.Count; i < nums.Length; i++) {
        uniqueNums.Add(i, "_");
    }
    
    return k;    
    }
}
}