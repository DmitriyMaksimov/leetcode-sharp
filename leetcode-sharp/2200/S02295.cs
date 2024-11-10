namespace leetcode_sharp;

// 2295. Replace Elements in an Array
// https://leetcode.com/problems/replace-elements-in-an-array
public class S02295
{
    public int[] ArrayChange(int[] nums, int[][] operations)
    {
        var numIndexMap = nums.Select((num, index) => new { num, index }).ToDictionary(x => x.num, x => x.index);

        foreach (var op in operations)
        {
            var oldValue = op[0];
            var newValue = op[1];
            var index = numIndexMap[oldValue];

            nums[index] = newValue;
            numIndexMap.Remove(oldValue);
            numIndexMap[newValue] = index;
        }

        return nums;
    }
}
