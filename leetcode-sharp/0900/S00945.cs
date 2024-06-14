namespace leetcode_sharp;

// 945. Minimum Increment to Make Array Unique
// https://leetcode.com/problems/minimum-increment-to-make-array-unique/
public class S00945
{
    public int MinIncrementForUnique(int[] nums)
    {
        var result = 0;
        var next = 0;
        
        foreach (var a in nums.Order())
        {
            result += Math.Max(next - a, 0);
            next = Math.Max(a, next) + 1;
        }
        
        return result;
    }
}