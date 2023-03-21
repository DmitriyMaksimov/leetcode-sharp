namespace leetcode_sharp;

// 502. IPO
// https://leetcode.com/problems/ipo/
public class S00502
{
    public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital)
    {
        var projects = new List<(int capital, int profit)>();

        for (var i = 0; i < profits.Length; i++)
        {
            projects.Add((capital[i], profits[i]));
        }

        projects = projects.OrderBy(x => x.capital).ToList();

        var queue = new PriorityQueue<int, int>();

        var completedProjects = 0;

        while (k-- > 0)
        {
            while (completedProjects < projects.Count && projects[completedProjects].capital <= w)
            {
                queue.Enqueue(projects[completedProjects].profit, int.MaxValue - projects[completedProjects].profit);
                completedProjects++;
            }

            if (queue.Count == 0)
            {
                break;
            }

            w += queue.Dequeue();
        }

        return w;
    }
}