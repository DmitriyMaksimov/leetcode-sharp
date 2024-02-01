namespace leetcode_sharp;

// 2966. Divide Array Into Arrays With Max Difference
// https://leetcode.com/problems/divide-array-into-arrays-with-max-difference
public class S02966
{
    public int[][] DivideArray(int[] nums, int k)
    {
        var size = nums.Length;
        if (size % 3 != 0)
        {
            return [];
        }

        Array.Sort(nums);

        var result = new List<int[]>();

        for (var i = 0; i < size; i += 3)
        {
            if (i + 2 < size && nums[i + 2] - nums[i] <= k)
            {
                result.Add([nums[i], nums[i + 1], nums[i + 2]]);
            }
            else
            {
                return [];
            }
        }

        return result.ToArray();
    }
}