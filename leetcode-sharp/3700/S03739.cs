namespace leetcode_sharp;

// 3739. Count Subarrays With Majority Element II
// https://leetcode.com/problems/count-subarrays-with-majority-element-ii
public class S03739
{
    public long CountMajoritySubarrays(int[] nums, int target)
    {
        var n = nums.Length;
        var pre = n + 1;
        var count = new long[2 * n + 2];
        var acc = new long[2 * n + 2];
        var result = 0L;
        count[pre] = acc[pre] = 1;
        
        foreach (var a in nums)
        {
            pre += (a == target ? 1 : -1);
            acc[pre] = ++count[pre] + acc[pre - 1];
            result += acc[pre - 1];
        }

        return result;
    }
}