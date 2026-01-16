namespace leetcode_sharp;

// 2975. Maximum Square Area by Removing Fences From a Field
// https://leetcode.com/problems/maximum-square-area-by-removing-fences-from-a-field
public class S02975
{
    public int MaximizeSquareArea(int m, int n, int[] hFences, int[] vFences)
    {
        const long mod = 1_000_000_007;

        var hList = new List<long>(hFences.Length + 2);
        var vList = new List<long>(vFences.Length + 2);

        hList.AddRange(hFences.Select(h => (long)h));
        vList.AddRange(vFences.Select(v => (long)v));

        hList.Add(1);
        hList.Add(m);
        vList.Add(1);
        vList.Add(n);

        hList.Sort();
        vList.Sort();

        var hDistances = new HashSet<long>();
        for (var i = 0; i < hList.Count; i++)
        {
            for (var j = i + 1; j < hList.Count; j++)
            {
                hDistances.Add(hList[j] - hList[i]);
            }
        }

        var maxSide = -1L;
        for (var i = 0; i < vList.Count; i++)
        {
            for (var j = i + 1; j < vList.Count; j++)
            {
                var dist = vList[j] - vList[i];
                if (hDistances.Contains(dist))
                {
                    if (dist > maxSide)
                    {
                        maxSide = dist;
                    }
                }
            }
        }

        if (maxSide == -1)
        {
            return -1;
        }

        var area = (maxSide * maxSide) % mod;
        return (int)area;
    }
}