namespace leetcode_sharp;

// 851. Loud and Rich
// https://leetcode.com/problems/loud-and-rich
public class S00851
{
    private readonly Dictionary<int, List<int>> _richer = [];
    private int[] _result;

    public int[] LoudAndRich(int[][] richer, int[] quiet)
    {
        var n = quiet.Length;

        for (var i = 0; i < n; ++i)
        {
            _richer[i] = [];
        }

        foreach (var v in richer)
        {
            _richer[v[1]].Add(v[0]);
        }

        _result = new int[n];
        Array.Fill(_result, -1);

        for (var i = 0; i < n; i++)
        {
            Dfs(i, quiet);
        }

        return _result;
    }

    private int Dfs(int i, int[] quiet)
    {
        if (_result[i] >= 0)
        {
            return _result[i];
        }

        _result[i] = i;

        foreach (int j in _richer[i].Where(j => quiet[_result[i]] > quiet[Dfs(j, quiet)]))
        {
            _result[i] = _result[j];
        }

        return _result[i];
    }
}
