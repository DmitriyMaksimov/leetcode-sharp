namespace leetcode_sharp;

// 2190. Most Frequent Number Following Key In an Array
// https://leetcode.com/problems/most-frequent-number-following-key-in-an-array/
public class S02190
{
    public int MostFrequent(int[] nums, int key)
    {
        var dict = new Dictionary<int, int>();
        var max = int.MinValue;

        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] != key) continue;
            
            var target = nums[i + 1];
            dict[target] = dict.GetValueOrDefault(target) + 1;
            max = Math.Max(max, dict[target]);
        }

        return dict.First(kvp => kvp.Value == max).Key;
    }
}