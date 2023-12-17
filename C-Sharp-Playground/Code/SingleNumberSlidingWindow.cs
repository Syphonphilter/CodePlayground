namespace C_Sharp_Playground.Code
{
    public class SingleNumberSlidingWindow
    {
        public int singleNumber(int[] nums)
        {
            int window = 2;
            List<int> windowValues = new List<int>();
            if (nums.Length == 1)
            {
                return 1;
            }
            else
            {
                for (int i = 0; i < window; i++)
                {
                    if (windowValues.Contains(nums[i]))
                    {
                        windowValues.Remove(nums[i]);
                    }
                    else
                    {
                        windowValues.Add(nums[i]);
                    }

                }


                for (int i = window; i < nums.Length; i++)
                {
                    if (windowValues.Contains(nums[i]))
                    {
                        windowValues.Remove(nums[i]);
                    }
                    else
                    {
                        windowValues.Add(nums[i]);
                    }
                }
                return windowValues[0];

            }
        }
    }
}