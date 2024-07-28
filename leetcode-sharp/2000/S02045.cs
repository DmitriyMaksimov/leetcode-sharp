namespace leetcode_sharp;

// 2045. Second Minimum Time to Reach Destination
// https://leetcode.com/problems/second-minimum-time-to-reach-destination
public class S02045
{
    public int SecondMinimum(int n, int[][] edges, int time, int change)
    {
        var al = new List<List<int>>();
        var minSteps = new int[n + 1];

        Array.Fill(minSteps, 10001);
        
        for (var i = 0; i <= n; ++i)
        {
            al.Add([]);
        }

        foreach (var edge in edges)
        {
            al[edge[0]].Add(edge[1]);
            al[edge[1]].Add(edge[0]);
        }

        var step = -1;
        List<int> q = [1];

        while (q.Any() && ++step <= minSteps[n] + 1)
        {
            List<int> q1 = [];
            foreach (var i in q.Where(i => step != minSteps[i] && step <= minSteps[i] + 1))
            {
                minSteps[i] = Math.Min(minSteps[i], step);
                if (i == n && step > minSteps[n])
                {
                    return StepsTime(step, time, change);
                }

                q1.AddRange(al[i]);
            }

            q = q1;
        }

        return StepsTime(minSteps[n] + 2, time, change);
    }

    private static int StepsTime(int steps, int time, int change)
    {
        var res = 0;
        while (--steps > 0)
        {
            res += time;
            if (res / change % 2 == 1)
            {
                res = (res / change + 1) * change;
            }
        }

        return res + time;
    }
}