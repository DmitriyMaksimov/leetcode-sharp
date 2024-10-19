namespace leetcode_sharp;

// 1283. Find the Smallest Divisor Given a Threshold
// https://leetcode.com/problems/find-the-smallest-divisor-given-a-threshold
public class S01283
{
    public int SmallestDivisor(int[] nums, int threshold)
    {
        var left = 1;
        var right = 1_000_000;

        while (left < right)
        {
            var m = left  + (right - left) / 2;
            var sum = nums.Sum(num => (num + m - 1) / m);

            if (sum > threshold)
            {
                left = m + 1;
            }
            else
            {
                right = m;
            }
        }

        return left;
    }
}
