namespace leetcode_sharp;

// 1470. Shuffle the Array
// https://leetcode.com/problems/shuffle-the-array/
public class S01470
{
    public int[] Shuffle(int[] nums, int n)
    {
        var result = new int[nums.Length];

        for (var i = 0; i < n; i++)
        {
            result[i * 2] = nums[i];
            result[i * 2 + 1] = nums[i + n];
        }
        
        return result;
    }
}