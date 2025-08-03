namespace leetcode_sharp;

// 1376. Time Needed to Inform All Employees
// https://leetcode.com/problems/time-needed-to-inform-all-employees/
public class S01376
{
    public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
    {
        var adjList = new Dictionary<int, List<int>>();

        for (var i = 0; i < n; i++)
        {
            if (manager[i] != -1)
            {
                adjList[manager[i]] = adjList.GetValueOrDefault(manager[i], []);
                adjList[manager[i]].Add(i);
            }
        }

        return dfs(headID, informTime, adjList);
    }

    private static int dfs(int manager, IReadOnlyList<int> informTime, IReadOnlyDictionary<int, List<int>> adjList)
    {
        var maxTime = 0;
        if (adjList.ContainsKey(manager))
        {
            foreach (var subordinate in adjList[manager])
            {
                maxTime = Math.Max(maxTime, dfs(subordinate, informTime, adjList));
            }
        }

        return maxTime + informTime[manager];
    }
}