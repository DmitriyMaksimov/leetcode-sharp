namespace leetcode_sharp;

// 1626. Best Team With No Conflicts
// https://leetcode.com/problems/best-team-with-no-conflicts/
public class S01626
{
    private (int score, int age)[] _data;
    private readonly Dictionary<(int index, int prev), int> _cache = new();

    public int BestTeamScore(int[] scores, int[] ages)
    {
        _data = new (int score, int age)[scores.Length];
        for (var i = 0; i < scores.Length; i++)
        {
            _data[i] = (scores[i], ages[i]);
        }

        _data = _data.OrderBy(x => x.age).ThenBy(x => x.score).ToArray();

        return dp(0, -1);
    }

    private int dp(int index, int prev)
    {
        if (index >= _data.Length)
        {
            return 0;
        }

        if (_cache.TryGetValue((index, prev), out var value))
        {
            return value;
        }

        if (prev == -1 || _data[index].score >= _data[prev].score)
        {
            // 2 options:
            // - take current player
            // - skip current player
            return _cache[(index, prev)] = Math.Max(
                _data[index].score + dp(index + 1, index),
                dp(index + 1, prev)
            );
        }

        // Conflict => skip
        return _cache[(index, prev)] = dp(index + 1, prev);
    }
}