namespace leetcode_sharp;

// 2554. Maximum Number of Integers to Choose From a Range I
// https://leetcode.com/problems/maximum-number-of-integers-to-choose-from-a-range-i
public class S02554
{
    public int MaxCount(int[] banned, int n, int maxSum)
    {
        var set = banned.ToHashSet();
        var result = 0;

        for (var i = 1; i <= n; i++)
        {
            if (set.Contains(i))
            {
                continue;
            }

            if (i > maxSum)
            {
                break;
            }

            result++;
            maxSum -= i;
        }

        return result;
    }
}
