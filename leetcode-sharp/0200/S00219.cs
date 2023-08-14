namespace leetcode_sharp;

// 219. Contains Duplicate II
// https://leetcode.com/problems/contains-duplicate-ii/
public class S00219
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            var j = i + 1;
            while (j < nums.Length && Math.Abs(i - j) <= k)
            {
                if (nums[i] == nums[j])
                {
                    return true;
                }

                j++;
            }
        }

        return false;
    }
}