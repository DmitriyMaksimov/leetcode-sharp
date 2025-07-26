namespace leetcode_sharp;

// 3480. Maximize Subarrays After Removing One Conflicting Pair
// https://leetcode.com/problems/maximize-subarrays-after-removing-one-conflicting-pair
public class S03480
{
    public long MaxSubarrays(int n, int[][] conflictingPairs)
    {
        var right = new List<int>[n + 1];
        for (var i = 0; i <= n; i++)
        {
            right[i] = [];
        }

        foreach (var pair in conflictingPairs)
        {
            var max = Math.Max(pair[0], pair[1]);
            var min = Math.Min(pair[0], pair[1]);
            right[max].Add(min);
        }

        var result = 0L;
        var top1 = 0L;
        var top2 = 0L;

        var bonus = new long[n + 1];

        for (var i = 1; i <= n; i++)
        {
            foreach (var val in right[i])
            {
                if (val > top1)
                {
                    top2 = top1;
                    top1 = val;
                }
                else if (val > top2)
                {
                    top2 = val;
                }
            }

            result += i - top1;

            if (top1 > 0)
            {
                bonus[top1] += top1 - top2;
            }
        }

        var maxBonus = bonus.Max();

        return result + maxBonus;
    }
}