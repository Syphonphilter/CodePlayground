using System.Net.NetworkInformation;

namespace C_Sharp_Playground.Code
{
    public class MaxProfit
    {
        public static int Approach1(int[] prices)
        {
            if (prices.Length == 0)
            {
                return 0;
            }
            int max = 0;
            int minPos = Array.IndexOf(prices, prices.Min());
            prices = prices[minPos..];
            for (int i = 0; i < prices.Length - 1; i++)
            {
                int[] tempPrices = { };
                int currentDay = prices[i];
                tempPrices = prices[(i + 1)..];
                int currentProfit = tempPrices.Max() - currentDay;
                max = currentProfit > max ? currentProfit : max;

            }
            return max;
        }

        public static int Approach2(int[] prices)
        {
            if (prices.Length == 0)
            {
                return 0;
            }

            int min_pos = Array.IndexOf(prices, prices.Min());
            if (min_pos == prices.Length - 1)
            {

                prices = prices[..^1];
                return Approach2(prices);
            }

            else
            {
                prices = prices[min_pos..];

                return prices.Max() - prices[0];
            }
        }
        public static int Approach3(int[] prices)
        {
            if (prices == null || prices.Length < 2)
            {
                return 0;
            }

            int minPrice = prices[0];
            int maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i]; // Update the minimum price
                }
                else
                {
                    maxProfit = Math.Max(maxProfit, prices[i] - minPrice); // Update the maximum profit
                }
            }

            return maxProfit;
        }
    }
}