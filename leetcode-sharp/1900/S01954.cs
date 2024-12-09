namespace leetcode_sharp;

// 1954. Minimum Garden Perimeter to Collect Enough Apples
// https://leetcode.com/problems/minimum-garden-perimeter-to-collect-enough-apples
public class S01954
{
    public long MinimumPerimeter(long neededApples)
    {
        var low = 1L;
        var hi = 100000L;

        while (low < hi)
        {
            var m = low + (hi - low) / 2;
            var n = 2 * m * (m + 1) * (2 * m + 1);

            if (n < neededApples)
            {
                low = m + 1;
            }
            else
            {
                hi = m;
            }
        }

        return 8 * low;
    }
}
