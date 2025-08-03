namespace leetcode_sharp;

// 2492. Minimum Score of a Path Between Two Cities
// https://leetcode.com/problems/minimum-score-of-a-path-between-two-cities/
public class S02492
{
    private readonly HashSet<int> _visited = [];
    private Dictionary<int, List<(int city, int distance)>> _graph;

    public int MinScore(int n, int[][] roads)
    {
        _graph = buildGraph(roads);
        
        var queue = new Queue<int>();
        queue.Enqueue(1);

        var result = int.MaxValue;

        while (queue.Count > 0)
        {
            var city = queue.Dequeue();
            if (!_visited.Contains(city))
            {
                _visited.Add(city);
                
                foreach (var (cityB, distance) in _graph.GetValueOrDefault(city, Enumerable.Empty<(int, int)>().ToList()))
                {
                    result = Math.Min(result, distance);
                    if (!_visited.Contains(cityB))
                    {
                        queue.Enqueue(cityB);
                    }
                }
            }
        }
        
        return result;
    }
    
    private static Dictionary<int, List<(int city, int distance)>> buildGraph(int[][] roads)
    {
        var graph = new Dictionary<int, List<(int city, int distance)>>();
        foreach (var element in roads)
        {
            var cityA = element[0];
            var cityB = element[1];
            var distance = element[2];

            graph[cityA] = graph.GetValueOrDefault(cityA, new List<(int, int)>());
            graph[cityA].Add((cityB, distance));

            graph[cityB] = graph.GetValueOrDefault(cityB, new List<(int, int)>());
            graph[cityB].Add((cityA, distance));
        }

        return graph;
    }
}