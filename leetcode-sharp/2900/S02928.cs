namespace leetcode_sharp;

// 2928. Distribute Candies Among Children I
// https://leetcode.com/problems/distribute-candies-among-children-i
public class S02928
{
    public int DistributeCandies(int n, int limit)
    {
        var result = 0;

        for (var i = 0; i < Math.Min(n, limit) + 1; i++)
        {
            for (var j = 0; j < Math.Min(n - i, limit) + 1; j++)
            {
                var k = n - i - j;
                if (0 <= k && k <= limit)
                {
                    ++result;
                }
            }
        }

        return result;
    }
}