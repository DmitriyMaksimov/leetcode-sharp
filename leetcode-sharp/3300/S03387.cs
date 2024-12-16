namespace leetcode_sharp;

// 3387. Maximize Amount After Two Days of Conversions
// https://leetcode.com/problems/maximize-amount-after-two-days-of-conversions
public class S03387
{
    public double MaxAmount(string initialCurrency, IList<IList<string>> pairs1, double[] rates1, IList<IList<string>> pairs2, double[] rates2)
    {
        var graph1 = BuildGraph(pairs1, rates1);
        var graph2 = BuildGraph(pairs2, rates2);
        var maxDay1 = Bfs(initialCurrency, graph1);
        var maxCurrency = 0.0;

        foreach (var (currency, amount) in maxDay1)
        {
            var maxDay2 = Bfs(currency, graph2, amount);

            if (maxDay2.TryGetValue(initialCurrency, out var value))
            {
                maxCurrency = Math.Max(maxCurrency, value);
            }
        }

        return maxCurrency;
    }

    private Dictionary<string, List<(string, double)>> BuildGraph(IList<IList<string>> pairs, double[] rates)
    {
        var graph = new Dictionary<string, List<(string, double)>>();

        for (var i = 0; i < pairs.Count; i++)
        {
            var from = pairs[i][0];
            var to = pairs[i][1];
            var rate = rates[i];

            graph.TryAdd(from, []);
            graph[from].Add((to, rate));

            graph.TryAdd(to, []);
            graph[to].Add((from, 1.0 / rate));
        }

        return graph;
    }

    private static Dictionary<string, double> Bfs(string start, Dictionary<string, List<(string, double)>> graph, double startAmount = 1.0)
    {
        var maxAmount = new Dictionary<string, double>();
        var queue = new Queue<(string, double)>();
        queue.Enqueue((start, startAmount));
        maxAmount[start] = startAmount;

        while (queue.Count > 0)
        {
            var (current, amount) = queue.Dequeue();

            if (!graph.TryGetValue(current, out var value))
            {
                continue;
            }

            foreach (var (neighbor, rate) in value)
            {
                var newAmount = amount * rate;

                if (!maxAmount.ContainsKey(neighbor) || newAmount > maxAmount[neighbor])
                {
                    maxAmount[neighbor] = newAmount;
                    queue.Enqueue((neighbor, newAmount));
                }
            }
        }

        return maxAmount;
    }
}
