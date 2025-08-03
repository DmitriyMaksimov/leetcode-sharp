namespace leetcode_sharp;

// 1584. Min Cost to Connect All Points
// https://leetcode.com/problems/min-cost-to-connect-all-points/
public class S01584
{
    private readonly HashSet<int[]> _visited = [];
    private readonly PriorityQueue<(int[] point, int wt), int> _heap = new();

    public int MinCostConnectPoints(int[][] points)
    {
        _heap.Enqueue((points[0], 0), 0);

        var total = 0;
        while (_heap.Count > 0 && _visited.Count < points.Length)
        {
            var tuple = _heap.Dequeue();
            if (_visited.Contains(tuple.point)) continue;

            total += tuple.wt;
            _visited.Add(tuple.point);

            foreach (var point in points)
            {
                if (_visited.Contains(point)) continue;
                var distance = getDistance(point, tuple.point);
                _heap.Enqueue((point, distance), distance);
            }
        }

        return total;
    }

    private static int getDistance(int[] a, int[] b)
    {
        return Math.Abs(a[0] - b[0]) + Math.Abs(a[1] - b[1]);
    }
}