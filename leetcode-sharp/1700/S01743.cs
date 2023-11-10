namespace leetcode_sharp;

// 1743. Restore the Array From Adjacent Pairs
// https://leetcode.com/problems/restore-the-array-from-adjacent-pairs
public class S01743
{
    public int[] RestoreArray(int[][] adjacentPairs)
    {
        var ps = new Dictionary<int, List<int>>();

        foreach (var adjacentPair in adjacentPairs)
        {
            ps.TryAdd(adjacentPair[0], new List<int>());
            ps.TryAdd(adjacentPair[1], new List<int>());
            ps[adjacentPair[0]].Add(adjacentPair[1]);
            ps[adjacentPair[1]].Add(adjacentPair[0]);
        }


        var res = new List<int>();
        foreach (var (key, value) in ps)
        {
            if (value.Count == 1)
            {
                res.Add(key);
                res.Add(value[0]);
                break;
            }
        }

        while (res.Count < adjacentPairs.Length + 1)
        {
            var tail = res[^1];
            var prev = res[^2];
            var next = ps[tail];

            res.Add(next[0] != prev ? next[0] : next[1]);
        }

        return res.ToArray();
    }
}