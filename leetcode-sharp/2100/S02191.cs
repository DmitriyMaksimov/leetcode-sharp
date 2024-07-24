namespace leetcode_sharp;

// 2191. Sort the Jumbled Numbers
// https://leetcode.com/problems/sort-the-jumbled-numbers/
public class S02191
{
    public int[] SortJumbled(int[] mapping, int[] nums)
    {
        var list = new List<(int mappedValue, int index)>();

        for (var i = 0; i < nums.Length; ++i)
        {
            var mappedValue = int.Parse(nums[i].ToString().Aggregate("", (current, n) => current + mapping[n - '0']));
            list.Add((mappedValue, i));
        }

        var index = 0;
        var ans = new int[nums.Length];

        foreach (var element in list.OrderBy(x => x.mappedValue).ThenBy(x => x.index))
        {
            ans[index++] = nums[element.index];
        }

        return ans;
    }
}