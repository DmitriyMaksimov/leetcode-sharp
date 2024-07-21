namespace leetcode_sharp;

// 2392. Build a Matrix With Conditions
// https://leetcode.com/problems/build-a-matrix-with-conditions
public class S02392
{
    public int[][] BuildMatrix(int k, int[][] rowConditions, int[][] colConditions)
    {
        var row = GenerateTopologicalSort(rowConditions, k);
        var col = GenerateTopologicalSort(colConditions, k);

        if (row.Count < k || col.Count < k)
        {
            return [];
        }

        var idx = new int[k + 1];
        for (var j = 0; j < col.Count; j++)
        {
            idx[col[j]] = j;
        }

        var res = new int[k][];

        for (var i = 0; i < k; i++)
        {
            res[i] = new int[k];
            res[i][idx[row[i]]] = row[i];
        }

        return res;
    }

    private static List<int> GenerateTopologicalSort(int[][] conditions, int k)
    {
        var deg = new int[k + 1];
        var graph = new List<int>[k + 1];

        for (var i = 1; i <= k; i++)
        {
            graph[i] = [];
        }

        foreach (var c in conditions)
        {
            graph[c[0]].Add(c[1]);
            deg[c[1]]++;
        }

        var q = new Queue<int>();

        for (var i = 1; i <= k; i++)
        {
            if (deg[i] == 0)
            {
                q.Enqueue(i);
            }
        }

        var order = new List<int>();

        while (q.Count > 0)
        {
            var x = q.Dequeue();
            order.Add(x);

            foreach (var y in graph[x])
            {
                if (--deg[y] == 0)
                {
                    q.Enqueue(y);
                }
            }
        }

        return order;
    }
}