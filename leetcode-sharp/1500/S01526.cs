namespace leetcode_sharp;

// 1526. Minimum Number of Increments on Subarrays to Form a Target Array
// https://leetcode.com/problems/minimum-number-of-increments-on-subarrays-to-form-a-target-array
public class S01526
{
    public int MinNumberOperations(int[] target)
    {
        var result = target[0];

        for (var i = 1; i < target.Length; ++i)
        {
            result += Math.Max(target[i] - target[i - 1], 0);
        }

        return result;
    }
}