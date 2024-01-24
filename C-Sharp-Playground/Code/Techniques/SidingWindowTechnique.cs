using System;

class SlidingWindowTechnique
{
    public SlidingWindowTechnique(){

    }
    public int MaxSumSubarray(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0 || k <= 0 || k > nums.Length)
            return 0;

        int maxSum = 0;
        int currentSum = 0;

        // Calculate the sum of the first window of size k
        for (int i = 0; i < k; i++)
        {
            currentSum += nums[i];
        }

        maxSum = currentSum;

        // Slide the window and find the maximum sum
        for (int i = k; i < nums.Length; i++)
        {
            // Remove the element going out of the window
            currentSum -= nums[i - k];

            // Add the new element entering the window
            currentSum += nums[i];

            // Update the maximum sum if a new maximum is found
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }
}
