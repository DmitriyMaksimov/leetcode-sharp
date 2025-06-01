namespace leetcode_sharp;

// 2929. Distribute Candies Among Children II
// https://leetcode.com/problems/distribute-candies-among-children-ii
public class S02929
{
    public long DistributeCandies(int n, int limit)
    {
        var count = 0L;

        for (var a = Math.Max(0, n - 2 * limit); a <= Math.Min(limit, n); a++)
        {
            var rangeOfB = Math.Min(limit, n - a) - Math.Max(0, n - a - limit) + 1;
            count += Math.Max(0, rangeOfB);
        }

        return count;
    }
}
