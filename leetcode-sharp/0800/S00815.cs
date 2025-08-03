namespace leetcode_sharp;

// 815. Bus Routes
// https://leetcode.com/problems/bus-routes
public class S00815
{
    public int NumBusesToDestination(int[][] routes, int source, int target)
    {
        var routeDict = new Dictionary<int, List<int>>();
        var queue = new Queue<(int stop, int routeLength)>();

        for (var i = 0; i < routes.Length; i++)
        {
            for (var j = 0; j < routes[i].Length; j++)
            {
                var stop = routes[i][j];
                if (!routeDict.ContainsKey(stop))
                {
                    routeDict.Add(stop, []);
                }

                routeDict[stop].Add(i);
            }
        }

        var visitedBuses = new HashSet<int>();
        var visitedStops = new HashSet<int>();
        queue.Enqueue((source, 0));

        while (queue.Any())
        {
            var item = queue.Dequeue();
            if (item.stop == target)
            {
                return item.routeLength;
            }

            foreach (var bus in routeDict[item.stop].Where(bus => !visitedBuses.Contains(bus)))
            {
                visitedBuses.Add(bus);

                for (var i = 0; i < routes[bus].Length; i++)
                {
                    if (!visitedStops.Contains(routes[bus][i]))
                    {
                        visitedStops.Add(routes[bus][i]);
                        queue.Enqueue((routes[bus][i], item.routeLength + 1));
                    }
                }
            }
        }

        return -1;
    }
}