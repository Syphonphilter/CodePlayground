namespace C_Sharp_Playground.Code
{
    public class SqrtConverter
    {
        public int MySqrt(int x)
        {
            if (x == 0)
                return 0;

            int left = 1;
            int right = x;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int result = x / mid;

                if (result == mid)
                {
                    return mid; // Found the exact square root
                }
                else if (result < mid)
                {
                    right = mid - 1; // Adjust the search range to the left
                }
                else
                {
                    left = mid + 1; // Adjust the search range to the right
                }
            }

            // Since we need to return the square root rounded down, 'right' contains the floor value.
            return right;
        }
    }
}