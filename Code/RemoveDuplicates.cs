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
    }
}