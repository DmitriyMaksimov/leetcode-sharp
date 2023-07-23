namespace leetcode_sharp;

// 875. Koko Eating Bananas
// https://leetcode.com/problems/koko-eating-bananas/
public class S00875
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        var left = 1;
        var right = int.MaxValue;

        while (left < right)
        {
            var mid = left + (right - left) / 2;

            var hours = 0L;

            foreach (var n in piles)
            {
                hours += (n + mid - 1) / mid;   // Ceiling for int
                if (hours > h)
                {
                    // To avoid sum overflow
                    break;
                }
            }

            if (hours <= h)
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }
}