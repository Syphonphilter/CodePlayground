namespace C_Sharp_Playground.Code
{
    public class MergeSortedArray
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int count = n;
            count = count <= 0 ? Math.Max(m, n) : count;
            for (int j = m; j <= nums1.Length - 1; j++)
            {
                nums1[j] = nums2[count - 1];
                count--;
            }
            Array.Sort(nums1);
        }
    }
}