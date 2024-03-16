namespace leetcode_sharp;

// 525. Contiguous Array
// https://leetcode.com/problems/contiguous-array
public class S00525
{
    public int FindMaxLength(int[] nums)
    {
        var sumToIndex = new Dictionary<int, int> {[0] = -1};
        var sum = 0;
        var max = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i] == 1 ? 1 : -1;

            if (sumToIndex.TryGetValue(sum, out var value))
            {
                max = Math.Max(max, i - value);
            }
            else
            {
                sumToIndex[sum] = i;
            }
        }

        return max;
    }
}