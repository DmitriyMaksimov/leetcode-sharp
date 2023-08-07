namespace leetcode_sharp;

// 90. Subsets II
// https://leetcode.com/problems/subsets-ii/
public class S00090
{
    private readonly IList<IList<int>> _list = new List<IList<int>>();

    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        Array.Sort(nums);
        backtrack(new List<int>(), nums, 0);
        return _list;
    }

    private void backtrack(IList<int> tempList, IReadOnlyList<int> nums, int start)
    {
        _list.Add(new List<int>(tempList));
        for (var i = start; i < nums.Count; i++)
        {
            if (i > start && nums[i] == nums[i - 1])
            {
                continue;
            }

            tempList.Add(nums[i]);
            backtrack(tempList, nums, i + 1);
            tempList.RemoveAt(tempList.Count - 1);
        }
    }
}