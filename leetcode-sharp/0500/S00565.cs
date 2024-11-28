namespace leetcode_sharp;

// 565. Array Nesting
// https://leetcode.com/problems/array-nesting
public class S00565
{
    public int ArrayNesting(int[] nums)
    {
        var result = 0;
        var seen = new bool[nums.Length];

        foreach (var num in nums)
        {
            var cnt = 0;
            var n = num;
            while (!seen[n])
            {
                seen[n] = true;
                cnt++;
                n = nums[n];
            }

            result = Math.Max(result, cnt);
        }

        return result;
    }
}
