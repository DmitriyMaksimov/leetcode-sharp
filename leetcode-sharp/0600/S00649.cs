namespace leetcode_sharp;

// 649. Dota2 Senate
// https://leetcode.com/problems/dota2-senate/
public class S00649
{
    public string PredictPartyVictory(string senate)
    {
        var rQueue = new Queue<int>();
        var dQueue = new Queue<int>();
        var n = senate.Length;

        for (var i = 0; i < n; i++)
        {
            if (senate[i] == 'R')
            {
                rQueue.Enqueue(i);
            }
            else
            {
                dQueue.Enqueue(i);
            }
        }

        while (rQueue.Any() && dQueue.Any())
        {
            var rIndex = rQueue.Dequeue();
            var dIndex = dQueue.Dequeue();

            if (rIndex < dIndex)
            {
                rQueue.Enqueue(rIndex + n);
            }
            else
            {
                dQueue.Enqueue(dIndex + n);
            }
        }

        return rQueue.Count > dQueue.Count ? "Radiant" : "Dire";
    }
}