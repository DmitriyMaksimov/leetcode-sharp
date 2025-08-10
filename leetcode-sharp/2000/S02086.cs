namespace leetcode_sharp;

// 2086. Minimum Number of Food Buckets to Feed the Hamsters
// https://leetcode.com/problems/minimum-number-of-food-buckets-to-feed-the-hamsters
public class S02086
{
    public int MinimumBuckets(string hamsters)
    {
        var chars = hamsters.ToCharArray();

        for (var i = 0; i < chars.Length; i++)
        {
            if (chars[i] != 'H' || (i > 0 && chars[i - 1] == 'B'))
            {
                continue;
            }

            if (i < chars.Length - 1 && chars[i + 1] == '.')
            {
                chars[i + 1] = 'B';
            }
            else if (i > 0 && chars[i - 1] == '.')
            {
                chars[i - 1] = 'B';
            }
            else
            {
                return -1;
            }
        }

        return chars.Count(c => c == 'B');
    }
}