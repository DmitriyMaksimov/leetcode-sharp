namespace leetcode_sharp;

// 332. Reconstruct Itinerary
// https://leetcode.com/problems/reconstruct-itinerary/
public class S00332
{
    public IList<string> FindItinerary(IList<IList<string>> tickets)
    {
        var graph = new Dictionary<string, List<string>>();

        foreach (var ticket in tickets)
        {
            if (!graph.ContainsKey(ticket[0]))
            {
                graph[ticket[0]] = [];
            }

            graph[ticket[0]].Add(ticket[1]);
        }

        foreach (var destinations in graph.Values)
        {
            destinations.Sort((a, b) => b.CompareTo(a));
        }

        var itinerary = new List<string>();

        dfs("JFK", graph, itinerary);
        itinerary.Reverse();

        return itinerary;
    }

    private static void dfs(string airport, Dictionary<string, List<string>> graph, ICollection<string> itinerary)
    {
        while (graph.ContainsKey(airport) && graph[airport].Count > 0)
        {
            var next = graph[airport][^1];
            graph[airport].RemoveAt(graph[airport].Count - 1);
            dfs(next, graph, itinerary);
        }

        itinerary.Add(airport);
    }
}