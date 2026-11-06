namespace leetcode_sharp;

// 2747. Count Zero Request Servers
// https://leetcode.com/problems/count-zero-request-servers
public class S02747
{
    public int[] CountServers(int n, int[][] logs, int x, int[] queries)
    {
        Array.Sort(logs, (l1, l2) => l1[1].CompareTo(l2[1]));

        var m = queries.Length;
        var ids = Enumerable.Range(0, m).ToArray();
        var result = new int[m];
        var cnt = new int[n + 1];

        Array.Sort(ids, (i, j) => queries[i].CompareTo(queries[j]));

        var i = 0;
        var j = 0;
        var used = 0;

        foreach (var id in ids)
        {
            while (i < logs.Length && logs[i][1] <= queries[id])
            {
                if (++cnt[logs[i][0]] == 1)
                {
                    used++;
                }

                i++;
            }

            while (j < logs.Length && logs[j][1] < queries[id] - x)
            {
                if (--cnt[logs[j][0]] == 0)
                {
                    used--;
                }

                j++;
            }

            result[id] = n - used;
        }

        return result;
    }
}