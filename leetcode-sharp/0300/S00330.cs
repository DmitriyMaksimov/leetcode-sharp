namespace leetcode_sharp;

// 330. Patching Array
// https://leetcode.com/problems/patching-array
public class S00330
{
    public int MinPatches(int[] nums, int n)
    {
        var miss = 1L;
        var added = 0L;
        var i = 0;
        
        while (miss <= n)
        {
            if (i < nums.Length && nums[i] <= miss)
            {
                miss += nums[i++];
            }
            else
            {
                miss += miss;
                added++;
            }
        }

        return (int)added;
    }
}