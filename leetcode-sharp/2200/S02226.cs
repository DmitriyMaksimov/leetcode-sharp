namespace leetcode_sharp;

// 2226. Maximum Candies Allocated to K Children
// https://leetcode.com/problems/maximum-candies-allocated-to-k-children
public class S02226
{
    public int MaximumCandies(int[] candies, long k)
    {
        var left = 1;
        var right = candies.Max();
        var result = 0;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            var childrenCount = candies.Aggregate(0L, (current, candy) => current + candy / mid);

            if (childrenCount >= k)
            {
                result = mid;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;
    }
}
