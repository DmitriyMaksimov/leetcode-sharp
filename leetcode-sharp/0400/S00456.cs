namespace leetcode_sharp;

// 456. 132 Pattern
// https://leetcode.com/problems/132-pattern
public class S00456
{
    public bool Find132pattern(int[] nums)
    {
        var s3 = int.MinValue;

        var stack = new Stack<int>();
        
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            if (nums[i] < s3) return true;
            
            while (stack.Count > 0 && nums[i] > stack.Peek())
            {
                s3 = stack.Peek();
                stack.Pop();
            }

            stack.Push(nums[i]);
        }

        return false;
    }
}