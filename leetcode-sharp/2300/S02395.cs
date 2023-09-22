namespace leetcode_sharp;

// 2395. Find Subarrays With Equal Sum
// https://leetcode.com/problems/find-subarrays-with-equal-sum/
public class S02395
{
    public bool FindSubarrays(int[] nums)
    {
        var hashSet = new HashSet<int>();
        
        for (var i = 1; i < nums.Length; i++)
        {
            var sum = nums[i- 1] + nums[i];

            if (hashSet.Contains(sum))
            {
                return true;
            }
            
            hashSet.Add(sum);
        }

        return false;
    }
}