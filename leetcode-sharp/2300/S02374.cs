namespace leetcode_sharp;

// 2374. Node With Highest Edge Score
// https://leetcode.com/problems/node-with-highest-edge-score/
public class S02374
{
    public int EdgeScore(int[] edges)
    {
        var n = edges.Length;
        var score = new long[n];

        for (var i = 0; i < n; i++)
        {
            score[edges[i]] += i;
        }

        return score.Select((value, index) => new { Index = index, Value = value }).MaxBy(x => x.Value)!.Index;
    }
}
