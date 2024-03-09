namespace leetcode_sharp;

// 3038. Maximum Number of Operations With the Same Score I
// https://leetcode.com/problems/maximum-number-of-operations-with-the-same-score-i
public class S03038
{
    public int MaxOperations(int[] nums)
    {
        var n = nums.Length;
        var sum = nums[0] + nums[1];
        var count = 0;
        
        for (var i = 0; i < n - 1; i += 2)
        {
            if (sum != nums[i] + nums[i + 1])
                break;

            count++;
        }

        return count;
    }
}