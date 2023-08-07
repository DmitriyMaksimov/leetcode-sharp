namespace leetcode_sharp;

// 47. Permutations II
// https://leetcode.com/problems/permutations-ii/
public class S00047
{
    private readonly IList<IList<int>> _list = new List<IList<int>>();
    private bool[] _used;

    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        Array.Sort(nums);
        _used = new bool[nums.Length];
        backtrack(new List<int>(), nums);
        return _list;
    }

    private void backtrack(IList<int> tempList, IReadOnlyList<int> nums)
    {
        if (tempList.Count == nums.Count)
        {
            _list.Add(new List<int>(tempList));
            return;
        }

        for (var i = 0; i < nums.Count; i++)
        {
            if (_used[i] || i > 0 && nums[i] == nums[i - 1] && !_used[i - 1])
            {
                continue;
            }

            _used[i] = true;
            tempList.Add(nums[i]);
            backtrack(tempList, nums);
            _used[i] = false;
            tempList.RemoveAt(tempList.Count - 1);
        }
    }
}