namespace leetcode_sharp;

// 2553. Separate the Digits in an Array
// https://leetcode.com/problems/separate-the-digits-in-an-array/
public class S02553
{
    public int[] SeparateDigits(int[] nums)
    {
        var result = new List<int>();
        
        foreach (var num in nums)
        {
            var n = num;
            var stack = new Stack<int>();

            while (n > 0)
            {
                stack.Push(n % 10);
                n /= 10;
            }
            
            result.AddRange(stack.ToArray());
        }
        
        return result.ToArray();
    }
}