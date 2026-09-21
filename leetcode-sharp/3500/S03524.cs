namespace leetcode_sharp;

// 3524. Find X Value of Array I
// https://leetcode.com/problems/find-x-value-of-array-i
public class S03524
{
    public long[] ResultArray(int[] nums, int k)
    {
        var result = new long[k];
        var frequencies = new int[k];
        
        foreach (var num in nums)
        {
            var n = num % k;
            var cur = new int[k];
            cur[n] = 1;

            for (var x = 0; x < k; x++)
            {
                cur[x * n % k] += frequencies[x];
            }

            frequencies = cur;

            for (var x = 0; x < k; x++)
            {
                result[x] += frequencies[x];
            }
        }

        return result;
    }
}