namespace leetcode_sharp;

// 1462. Course Schedule IV
// https://leetcode.com/problems/course-schedule-iv
public class S01462
{
    public IList<bool> CheckIfPrerequisite(int numCourses, int[][] prerequisites, int[][] queries)
    {
        var indegree = new int[numCourses];
        var adj = new Dictionary<int, HashSet<int>>();
        var prerequisitesMap = new Dictionary<int, HashSet<int>>();

        for (var i = 0; i < numCourses; i++)
        {
            prerequisitesMap[i] = [];
            adj[i] = [];
        }

        foreach (var pre in prerequisites)
        {
            indegree[pre[1]]++;
            adj[pre[0]].Add(pre[1]);
        }

        var queue = new Queue<int>();
        for (var i = 0; i < numCourses; i++)
        {
            if (indegree[i] == 0)
            {
                queue.Enqueue(i);
            }
        }

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            foreach (var next in adj[node])
            {
                prerequisitesMap[next].Add(node);
                prerequisitesMap[next].UnionWith(prerequisitesMap[node]);
                indegree[next]--;
                if (indegree[next] == 0)
                {
                    queue.Enqueue(next);
                }
            }
        }

        return queries.Select(pair => prerequisitesMap[pair[1]].Contains(pair[0])).ToList();
    }
}
