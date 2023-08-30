namespace leetcode_sharp;

// 506. Relative Ranks
// https://leetcode.com/problems/relative-ranks/
public class S00506
{
    public string[] FindRelativeRanks(int[] score)
    {
        var res = new string[score.Length];
        var pq = new PriorityQueue<int, int>();

        for (var i = 0; i < score.Length; i++)
        {
            pq.Enqueue(i, -score[i]);
        }

        if (pq.Count > 0)
        {
            res[pq.Dequeue()] = "Gold Medal";
        }

        if (pq.Count > 0)
        {
            res[pq.Dequeue()] = "Silver Medal";
        }

        if (pq.Count > 0)
        {
            res[pq.Dequeue()] = "Bronze Medal";
        }

        for (var i = 4; pq.Count > 0; i++)
        {
            res[pq.Dequeue()] = i.ToString();
        }

        return res;
    }
}