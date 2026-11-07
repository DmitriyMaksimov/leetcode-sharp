namespace leetcode_sharp;

// 1882. Process Tasks Using Servers
// https://leetcode.com/problems/process-tasks-using-servers
public class S01882
{
    public int[] AssignTasks(int[] servers, int[] tasks)
    {
        var n = tasks.Length;
        var result = new int[n];

        // Sort by weight, then index.
        var availableServers = new PriorityQueue<int, (int weight, int index)>();

        // Sort by finishing time.
        var runningServers = new PriorityQueue<int, long>();

        for (var i = 0; i < servers.Length; i++)
        {
            availableServers.Enqueue(i, (servers[i], i));
        }

        var time = 0L;

        for (var i = 0; i < n; i++)
        {
            time = Math.Max(time, i);

            while (runningServers.TryPeek(out var server, out var finishTime) && finishTime <= time)
            {
                runningServers.Dequeue();
                availableServers.Enqueue(server, (servers[server], server));
            }

            if (availableServers.Count == 0)
            {
                runningServers.TryPeek(out _, out var nextFinish);
                time = nextFinish;

                while (runningServers.TryPeek(out var server, out var finishTime) && finishTime <= time)
                {
                    runningServers.Dequeue();
                    availableServers.Enqueue(server, (servers[server], server));
                }
            }

            var selected = availableServers.Dequeue();

            result[i] = selected;

            runningServers.Enqueue(selected, time + tasks[i]);
        }

        return result;
    }
}