namespace leetcode_sharp;

// 2462. Total Cost to Hire K Workers
// https://leetcode.com/problems/total-cost-to-hire-k-workers/
public class S02462
{
    public long TotalCost(int[] costs, int k, int candidates)
    {
        var left = 0;
        var right = costs.Length - 1;
        var leftQueue = new PriorityQueue<int, int>();
        var rightQueue = new PriorityQueue<int, int>();

        var result = 0L;

        while (k-- > 0)
        {
            while (leftQueue.Count < candidates && left <= right)
            {
                leftQueue.Enqueue(costs[left], costs[left]);
                ++left;
            }

            while (rightQueue.Count < candidates && left <= right)
            {
                rightQueue.Enqueue(costs[right], costs[right]);
                --right;
            }

            var leftCost = leftQueue.Count > 0 ? leftQueue.Peek() : int.MaxValue;
            var rightCost = rightQueue.Count > 0 ? rightQueue.Peek() : int.MaxValue;

            if (leftCost <= rightCost)
            {
                result += leftCost;
                leftQueue.Dequeue();
            }
            else
            {
                result += rightCost;
                rightQueue.Dequeue();
            }
        }

        return result;
    }
}