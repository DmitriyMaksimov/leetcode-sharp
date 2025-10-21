namespace leetcode_sharp;

// 3346. Maximum Frequency of an Element After Performing Operations I
// https://leetcode.com/problems/maximum-frequency-of-an-element-after-performing-operations-i
public class S03346
{
    public int MaxFrequency(int[] nums, int k, int numOperations)
    {
        var maxVal = nums.Max() + k + 2;
        var count = new int[maxVal];

        foreach (var num in nums)
        {
            count[num]++;
        }

        for (var i = 1; i < maxVal; i++)
        {
            count[i] += count[i - 1];
        }

        var result = 0;

        for (var i = 0; i < maxVal; i++)
        {
            var left = Math.Max(0, i - k);
            var right = Math.Min(maxVal - 1, i + k);
            var total = count[right] - (left > 0 ? count[left - 1] : 0);
            var freq = count[i] - (i > 0 ? count[i - 1] : 0);

            result = Math.Max(result, freq + Math.Min(numOperations, total - freq));
        }

        return result;
    }
}
