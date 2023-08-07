namespace leetcode_sharp;

// 40. Combination Sum II
// https://leetcode.com/problems/combination-sum-ii/
public class S00040
{
    private readonly IList<IList<int>> _list = new List<IList<int>>();

    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
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
                    if (i > start && candidates[i] == candidates[i - 1])
                    {
                        continue;
                    }

                    tempList.Add(candidates[i]);
                    backtrack(tempList, candidates, remain - candidates[i], i + 1);
                    tempList.RemoveAt(tempList.Count - 1);
                }

                break;
            }
        }
    }
}