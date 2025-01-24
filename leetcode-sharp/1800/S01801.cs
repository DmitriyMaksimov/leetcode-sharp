namespace leetcode_sharp;

// 1801. Number of Orders in the Backlog
// https://leetcode.com/problems/number-of-orders-in-the-backlog
public class S01801
{
    public int GetNumberOfBacklogOrders(int[][] orders)
    {
        var buyQueue = new PriorityQueue<int[], int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        var sellQueue = new PriorityQueue<int[], int>();

        foreach (var order in orders)
        {
            var price = order[0];
            var type = order[2];

            if (type == 0)
            {
                buyQueue.Enqueue(order, price);
            }
            else
            {
                sellQueue.Enqueue(order, price);
            }

            while (buyQueue.Count > 0 && sellQueue.Count > 0 && sellQueue.Peek()[0] <= buyQueue.Peek()[0])
            {
                var k = Math.Min(buyQueue.Peek()[1], sellQueue.Peek()[1]);
                buyQueue.Peek()[1] -= k;
                sellQueue.Peek()[1] -= k;

                if (buyQueue.Peek()[1] == 0) buyQueue.Dequeue();
                if (sellQueue.Peek()[1] == 0) sellQueue.Dequeue();
            }
        }

        var result = 0;
        const int mod = 1_000_000_007;

        while (sellQueue.Count > 0)
        {
            result = (result + sellQueue.Dequeue()[1]) % mod;
        }

        while (buyQueue.Count > 0)
        {
            result = (result + buyQueue.Dequeue()[1]) % mod;
        }

        return result;
    }
}
