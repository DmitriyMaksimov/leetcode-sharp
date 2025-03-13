namespace leetcode_sharp;

// 3356. Zero Array Transformation II
// https://leetcode.com/problems/zero-array-transformation-ii
public class S03356
{
    public int MinZeroArray(int[] nums, int[][] queries)
    {
        var cnt = new int[nums.Length + 1];
        var cumulativeSum = 0;
        var result = 0;

        for (var i = 0; i < nums.Length; ++i)
        {
            while (cumulativeSum + cnt[i] < nums[i])
            {
                result++;
                if (result - 1 >= queries.Length)
                {
                    return -1;
                }

                var left = queries[result - 1][0];
                var right = queries[result - 1][1];
                var val = queries[result - 1][2];

                if (right < i)
                {
                    continue;
                }

                cnt[Math.Max(left, i)] += val;
                cnt[right + 1] -= val;
            }

            cumulativeSum += cnt[i];
        }

        return result;
    }
}
