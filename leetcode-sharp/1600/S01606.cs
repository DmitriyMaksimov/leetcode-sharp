namespace leetcode_sharp;

// 1606. Find Servers That Handled Most Number of Requests
// https://leetcode.com/problems/find-servers-that-handled-most-number-of-requests
public class S01606
{
    public IList<int> BusiestServers(int k, int[] arrival, int[] load)
    {
        var counter = new int[k];

        // Track available servers
        var available = new SortedSet<int>();

        for (var i = 0; i < k; i++)
        {
            available.Add(i);
        }

        var busyServers = new PriorityQueue<int, int>();

        for (var idx = 0; idx < arrival.Length; idx++)
        {
            var curTime = arrival[idx];
            var endTime = curTime + load[idx];

            while (busyServers.TryPeek(out var freedServer, out var priority) && priority <= curTime)
            {
                busyServers.Dequeue();
                available.Add(freedServer);
            }

            if (available.Count == 0)
            {
                continue;
            }

            var target = idx % k;
            int? assignNum = null;

            foreach (var server in available)
            {
                if (server >= target)
                {
                    assignNum = server;
                    break;
                }
            }

            if (assignNum == null)
            {
                assignNum = available.Min;
            }

            var assignedServer = assignNum.Value;

            counter[assignedServer]++;

            available.Remove(assignedServer);

            busyServers.Enqueue(assignedServer, endTime);
        }

        return FindMaxesInCounter(counter);
    }

    private static List<int> FindMaxesInCounter(int[] counter)
    {
        var max = counter.Max();

        var result = new List<int>();

        for (var i = 0; i < counter.Length; i++)
        {
            if (counter[i] == max)
            {
                result.Add(i);
            }
        }

        return result;
    }
}