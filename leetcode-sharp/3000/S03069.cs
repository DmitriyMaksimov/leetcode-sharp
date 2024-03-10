namespace leetcode_sharp;

// 3069. Distribute Elements Into Two Arrays I
// https://leetcode.com/problems/distribute-elements-into-two-arrays-i
public class S03069
{
    public int[] ResultArray(int[] nums)
    {
        List<int> v1 = [nums[0]];
        List<int> v2 = [nums[1]];

        for (var i = 2; i < nums.Length; i++)
        {
            if (v1[^1] > v2[^1])
            {
                v1.Add(nums[i]);
            }
            else
                v2.Add(nums[i]);
        }

        return v1.Concat(v2).ToArray();
    }
}