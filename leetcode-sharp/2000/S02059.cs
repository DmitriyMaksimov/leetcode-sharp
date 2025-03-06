namespace leetcode_sharp;

// 2059. Minimum Operations to Convert Number
// https://leetcode.com/problems/minimum-operations-to-convert-number
public class S02059
{
    public int MinimumOperations(int[] nums, int start, int goal)
    {
        var visited = new bool[1001];
        var result = 0;
        var queue = new Queue<int>();
        queue.Enqueue(start);

        while (queue.Count > 0)
        {
            var size = queue.Count;
            while (size-- > 0)
            {
                var frontElement = queue.Dequeue();
                if (frontElement == goal)
                {
                    return result;
                }

                if (frontElement > 1000 || frontElement < 0 || visited[frontElement])
                {
                    continue;
                }

                visited[frontElement] = true;

                foreach (var num in nums)
                {
                    queue.Enqueue(frontElement + num);
                    queue.Enqueue(frontElement - num);
                    queue.Enqueue(frontElement ^ num);
                }
            }

            result++;
        }

        return -1;
    }
}
