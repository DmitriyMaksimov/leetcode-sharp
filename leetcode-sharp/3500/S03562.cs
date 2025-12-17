namespace leetcode_sharp;

// 3562. Maximum Profit from Trading Stocks with Discounts
// https://leetcode.com/problems/maximum-profit-from-trading-stocks-with-discounts
public class S03562
{
    private int _budget;
    private int[] _present = null!;
    private int[] _future = null!;
    private List<int>[] _children = null!;

    public int MaxProfit(int n, int[] present, int[] future, int[][] hierarchy, int budget)
    {
        _budget = budget;
        _present = present;
        _future = future;

        _children = new List<int>[n];

        for (var i = 0; i < n; i++)
        {
            _children[i] = [];
        }

        foreach (var edge in hierarchy)
        {
            var u = edge[0] - 1;
            var v = edge[1] - 1;

            _children[u].Add(v);
        }

        var result = Dfs(0);
        var best = 0;

        for (var b = 0; b <= budget; b++)
        {
            best = Math.Max(best, result.noParentBuy[b]);
        }

        return best;
    }

    private (int[] noParentBuy, int[] parentBuy) Dfs(int node)
    {
        var dpNo = new int[_budget + 1];
        var dpYes = new int[_budget + 1];

        foreach (var child in _children[node])
        {
            var (childNo, childYes) = Dfs(child);

            dpNo = Merge(dpNo, childNo);
            dpYes = Merge(dpYes, childYes);
        }

        var newNo = new int[_budget + 1];
        var newYes = new int[_budget + 1];

        Array.Copy(dpNo, newNo, _budget + 1);
        Array.Copy(dpNo, newYes, _budget + 1);

        var fullCost = _present[node];
        var fullProfit = _future[node] - fullCost;
        for (var b = fullCost; b <= _budget; b++)
        {
            newNo[b] = Math.Max(newNo[b], dpYes[b - fullCost] + fullProfit);
        }

        var halfCost = _present[node] / 2;
        var halfProfit = _future[node] - halfCost;

        for (var b = halfCost; b <= _budget; b++)
        {
            newYes[b] = Math.Max(newYes[b], dpYes[b - halfCost] + halfProfit);
        }

        return (newNo, newYes);
    }

    private static int[] Merge(int[] a, int[] b)
    {
        var n = a.Length;
        var merged = new int[n];

        for (var i = 0; i < n; i++)
        {
            merged[i] = int.MinValue;
        }

        for (var i = 0; i < n; i++)
        {
            if (a[i] < 0)
            {
                continue;
            }

            for (var j = 0; j + i < n; j++)
            {
                if (b[j] < 0)
                {
                    continue;
                }

                merged[i + j] = Math.Max(merged[i + j], a[i] + b[j]);
            }
        }

        return merged;
    }
}