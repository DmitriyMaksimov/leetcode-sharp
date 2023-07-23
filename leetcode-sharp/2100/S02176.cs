namespace leetcode_sharp;

// 2176. Count Equal and Divisible Pairs in an Array
// https://leetcode.com/problems/count-equal-and-divisible-pairs-in-an-array/
public class S02176
{
    public int CountPairs(int[] nums, int k)
    {
        var result = 0;
        
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j] && i * j % k == 0)
                {
                    ++result;
                }
            }
            
        }

        return result;
    }
}