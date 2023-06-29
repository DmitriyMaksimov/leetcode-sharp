namespace leetcode_sharp;

// 2089. Find Target Indices After Sorting Array
// https://leetcode.com/problems/find-target-indices-after-sorting-array/
public class S02089
{
    public IList<int> TargetIndices(int[] nums, int target)
    {
        Array.Sort(nums);

        var result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                result.Add(i);
            }
            else if (nums[i] > target)
            {
                break;
            }
        }
        
        return result;
    }
}