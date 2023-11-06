namespace C_Sharp_Playground.Code
{
    public class ClimbStairs
    {
        /// <summary>
        /// Calculates the number of distinct ways to climb to the top of a staircase with the given number of steps.
        /// </summary>
        /// <param name="num">The number of steps in the staircase.</param>
        /// <returns>The number of distinct ways to climb to the top of the staircase.</returns>
        public static int ClimbStairs_BottomUpApproach(int num)
        {
            int[] mem = new int[num + 1];
            mem[num] = 1;
            mem[num - 1] = 1;

            for (int i = num - 2; i >= 0; i--)
            {
                mem[i] = mem[i + 1] + mem[i + 2];
            }

            return mem[0];
        }

        public static int ClimbStairs_TopDownApproach(int num)
        {
            int[] dp = new int[num + 1];
            dp[0] = 1;
            dp[1] = 1;

            for (int i = 2; i <= num; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[num];
        }
        /// End Code Snippet ///
    }
}