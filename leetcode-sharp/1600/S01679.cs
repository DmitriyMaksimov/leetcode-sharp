namespace leetcode_sharp;

// 1679. Max Number of K-Sum Pairs
// https://leetcode.com/problems/max-number-of-k-sum-pairs/
public class S01679
{
    public int MaxOperations(int[] nums, int k)
    {
        Array.Sort(nums);
        
        var i = 0;
        var j = nums.Length - 1;
        var count = 0;

        while (j > i)
        {
            if (nums[i] + nums[j] == k)
            {
                i++;
                j--;
                count++;
            }
            else if (nums[i] + nums[j] < k)
            {
                i++;
            }
            else
            {
                j--;
            }
        }

        return count;
    }
}