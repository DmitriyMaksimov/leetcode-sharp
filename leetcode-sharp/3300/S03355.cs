namespace leetcode_sharp;

// 3355. Zero Array Transformation I
// https://leetcode.com/problems/zero-array-transformation-i
public class S03355
{
    public bool IsZeroArray(int[] nums, int[][] queries)
    {
        var n = nums.Length;
        var freq = new int[n];

        foreach (var query in queries)
        {
            freq[query[0]]++;

            if (query[1] + 1 < n)
            {
                freq[query[1] + 1]--;
            }
        }

        var curFreq = 0;
        for (var i = 0; i < n; i++)
        {
            curFreq += freq[i];

            if (curFreq < nums[i])
            {
                return false;
            }
        }

        return true;
    }
}
