namespace leetcode_sharp;

// 2092. Find All People With Secret
// https://leetcode.com/problems/find-all-people-with-secret
public class S02092
{
    public IList<int> FindAllPeople(int n, int[][] meetings, int firstPerson)
    {
        var graph = new List<(int person, int time)>[n];
        
        for (var i = 0; i < n; i++)
        {
            graph[i] = new List<(int, int)>();
        }

        foreach (var m in meetings)
        {
            graph[m[0]].Add((m[1], m[2]));
            graph[m[1]].Add((m[0], m[2]));
        }

        var pq = new PriorityQueue<int, int>();

        pq.Enqueue(0, 0);
        pq.Enqueue(firstPerson, 0);

        var visited = new bool[n];

        while (pq.Count > 0)
        {
            pq.TryDequeue(out var person, out var time);

            if (visited[person])
            {
                continue;
            }

            visited[person] = true;

            foreach (var (nextPerson, meetTime) in graph[person])
            {
                if (!visited[nextPerson] && time <= meetTime)
                {
                    pq.Enqueue(nextPerson, meetTime);
                }
            }
        }

        var result = new List<int>();
        for (var i = 0; i < n; i++)
        {
            if (visited[i])
            {
                result.Add(i);
            }
        }

        return result;
    }
}