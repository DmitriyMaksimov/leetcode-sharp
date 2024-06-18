namespace leetcode_sharp;

// 826. Most Profit Assigning Work
// https://leetcode.com/problems/most-profit-assigning-work
public class S00826
{
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
    {
        List<(int difficulty, int profit)> jobs = [];
        jobs.AddRange(profit.Select((t, j) => (difficulty[j], t)));

        var jobsList = jobs.OrderBy(x => x.difficulty).ToList();
        var res = 0;
        var i = 0;
        var best = 0;

        foreach (var ability in worker.Order())
        {
            while (i < profit.Length && ability >= jobsList[i].difficulty)
            {
                best = Math.Max(jobsList[i++].profit, best);
            }

            res += best;
        }

        return res;
    }
}