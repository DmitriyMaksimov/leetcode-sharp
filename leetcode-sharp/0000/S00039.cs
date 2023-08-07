namespace leetcode_sharp;

// 39. Combination Sum
// https://leetcode.com/problems/combination-sum/
public class S00039
{
    private readonly IList<IList<int>> _list = new List<IList<int>>();

    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        Array.Sort(candidates);
        backtrack(new List<int>(), candidates, target, 0);
        return _list;
    }

    private void backtrack(IList<int> tempList, IReadOnlyList<int> candidates, int remain, int start)
    {
        switch (remain)
        {
            case < 0:
                return;
            case 0:
                _list.Add(new List<int>(tempList));
                break;
            default:
            {
                for (var i = start; i < candidates.Count; i++)
                {
                    tempList.Add(candidates[i]);
                    backtrack(tempList, candidates, remain - candidates[i], i);
                    tempList.RemoveAt(tempList.Count - 1);
                }

                break;
            }
        }
    }
}