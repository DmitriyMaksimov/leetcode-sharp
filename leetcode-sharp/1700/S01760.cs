namespace leetcode_sharp;

// 1760. Minimum Limit of Balls in a Bag
// https://leetcode.com/problems/minimum-limit-of-balls-in-a-bag
public class S01760
{
    public int MinimumSize(int[] nums, int maxOperations)
    {
        var left = 1;
        var right = int.MaxValue;

        while (left < right)
        {
            var mid = left + (right - left) / 2;
            var requiredOps = nums.Aggregate(0, (s, n) => s + (n - 1) / mid);

            if (requiredOps <= maxOperations)
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
