namespace leetcode_sharp;

// 632. Smallest Range Covering Elements from K Lists
// https://leetcode.com/problems/smallest-range-covering-elements-from-k-lists
public class S00632
{
    public int[] SmallestRange(IList<IList<int>> nums)
    {
        List<(int number, int group)> list = [];

        for (var i = 0; i < nums.Count; ++i)
        {
            list.AddRange(nums[i].Select(n => (n, i)));
        }

        list.Sort();

        var left = 0;
        var right = 0;
        var ans = new List<int>();
        Dictionary<int, int> counts = [];

        for (var j = 0; j < list.Count; ++j)
        {
            var group = list[j].group;
            counts[group] = counts.GetValueOrDefault(group) + 1;

            if (counts[group] == 1)
            {
                ++right;
            }

            if (right != nums.Count) continue;

            while (counts[list[left].group] > 1)
            {
                --counts[list[left].group];
                ++left;
            }

            if (ans.Count == 0 || ans[1] - ans[0] > list[j].number - list[left].number)
            {
                ans = [list[left].number, list[j].number];
            }
        }

        return ans.ToArray();
    }
}
