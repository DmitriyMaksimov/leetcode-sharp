namespace leetcode_sharp;

// 207. Course Schedule
// https://leetcode.com/problems/course-schedule/
public class S00207
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        var adj = new List<int>[numCourses];
        var inDegree = new int[numCourses];
        var ans = new List<int>();

        for (var i = 0; i < numCourses; i++)
        {
            adj[i] = [];
        }

        foreach (var pair in prerequisites)
        {
            var course = pair[0];
            var prerequisite = pair[1];

            adj[prerequisite].Add(course);
            inDegree[course]++;
        }

        var queue = new Queue<int>();
        for (var i = 0; i < numCourses; i++)
        {
            if (inDegree[i] == 0)
            {
                queue.Enqueue(i);
            }
        }

        while (queue.Any())
        {
            var current = queue.Dequeue();
            ans.Add(current);

            foreach (var next in adj[current])
            {
                inDegree[next]--;
                if (inDegree[next] == 0)
                {
                    queue.Enqueue(next);
                }
            }
        }

        return ans.Count == numCourses;
    }
}