namespace leetcode_sharp;

// 1202. Smallest String With Swaps
// https://leetcode.com/problems/smallest-string-with-swaps
public class S01202
{
    public string SmallestStringWithSwaps(string s, IList<IList<int>> pairs)
    {
        var n = s.Length;
        var ds = new int[n];
        Array.Fill(ds, -1);
        List<List<int>> groups = [..new List<int>[n]];

        for (var i = 0; i < n; i++)
        {
            groups[i] = [];
        }

        foreach (var pair in pairs)
        {
            var i = Find(ds, pair[0]);
            var j = Find(ds, pair[1]);

            if (i != j)
            {
                ds[j] = i;
            }
        }

        for (var i = 0; i < n; i++)
        {
            groups[Find(ds, i)].Add(i);
        }

        var result = s.ToCharArray();

        foreach (var ids in groups)
        {
            if (ids.Count <= 0) continue;

            var charGroup = ids.Select(id => result[id]).ToList();
            charGroup.Sort();

            for (var i = 0; i < ids.Count; i++)
            {
                result[ids[i]] = charGroup[i];
            }
        }

        return new string(result);
    }

    private static int Find(int[] ds, int i)
    {
        return ds[i] < 0 ? i : ds[i] = Find(ds, ds[i]);
    }
}
