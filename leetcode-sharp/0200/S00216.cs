namespace leetcode_sharp;

// 216. Combination Sum III
// https://leetcode.com/problems/combination-sum-iii/
public class S00216
{
    private readonly int[] _arr = [1, 2, 3, 4, 5, 6, 7, 8, 9];
    private readonly List<IList<int>> _ans = [];
    private readonly List<int> _ds = [];

    public IList<IList<int>> CombinationSum3(int k, int n)
    {
        helper(0, k, n);
        return _ans;
    }

    private void helper(int idx, int len, int target)
    {
        if (idx == _arr.Length)
        {
            if (_ds.Count == len && target == 0) _ans.Add(new List<int>(_ds));
            return;
        }

        _ds.Add(_arr[idx]);
        helper(idx + 1, len, target - _arr[idx]);
        _ds.RemoveAt(_ds.Count - 1);
        helper(idx + 1, len, target);
    }
}