namespace leetcode_sharp;

// 3341. Find Minimum Time to Reach Last Room I
// https://leetcode.com/problems/find-minimum-time-to-reach-last-room-i
public class S03341
{
    public int MinTimeToReach(int[][] moveTime)
    {
        var m = moveTime.Length;
        var n = moveTime[0].Length;

        var heap = new PriorityQueue<int[], int[]>(Comparer<int[]>.Create((a, b) => a[0].CompareTo(b[0])));
        heap.Enqueue([0, 0, 0], [0, 0, 0]);

        var unvisited = new HashSet<string>();
        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                unvisited.Add($"{i},{j}");
            }
        }

        unvisited.Remove("0,0");

        var dx = 1;
        var dy = 0;

        while (heap.Count > 0)
        {
            var current = heap.Dequeue();
            var time = current[0];
            var x = current[1];
            var y = current[2];

            if (x == m - 1 && y == n - 1)
            {
                return time;
            }

            for (var i = 0; i < 4; i++)
            {
                var temp = dx;
                dx = dy;
                dy = -temp;
                var newX = x + dx;
                var newY = y + dy;

                var pos = $"{newX},{newY}";
                if (newX >= 0 && newX < m && newY >= 0 && newY < n && unvisited.Contains(pos))
                {
                    var t = Math.Max(time, moveTime[newX][newY]) + 1;
                    heap.Enqueue([t, newX, newY], [t, newX, newY]);
                    unvisited.Remove(pos);
                }
            }
        }

        return -1;
    }
}
