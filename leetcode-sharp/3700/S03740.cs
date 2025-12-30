namespace leetcode_sharp;

// 3740. Minimum Distance Between Three Equal Elements I
// https://leetcode.com/problems/minimum-distance-between-three-equal-elements-i
public class S03740
{
    public int MinimumDistance(int[] nums)
    {
        var dictionary = new Dictionary<int, List<int>>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (!dictionary.ContainsKey(nums[i]))
            {
                dictionary[nums[i]] = [];
            }

            dictionary[nums[i]].Add(i);
        }

        var result = int.MaxValue;

        foreach (var list in dictionary.Select(kvp => kvp.Value).Where(list => list.Count >= 3))
        {
            for (var i = 0; i + 2 < list.Count; i++)
            {
                var left = list[i];
                var right = list[i + 2];
                var dist = 2 * (right - left);
                result = Math.Min(result, dist);
            }
        }

        return result == int.MaxValue ? -1 : result;
    }
}