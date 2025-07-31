namespace leetcode_sharp;

// 898. Bitwise ORs of Subarrays
// https://leetcode.com/problems/bitwise-ors-of-subarrays
public class S00898
{
    public int SubarrayBitwiseORs(int[] arr)
    {
        var resultSet = new HashSet<int>();
        var currentSet = new HashSet<int> { 0 };

        foreach (var x in arr)
        {
            var nextSet = currentSet.Select(y => x | y).Prepend(x).ToHashSet();
            currentSet = nextSet;
            resultSet.UnionWith(currentSet);
        }

        return resultSet.Count;
    }
}