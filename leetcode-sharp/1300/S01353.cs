namespace leetcode_sharp;

// 1353. Maximum Number of Events That Can Be Attended
// https://leetcode.com/problems/maximum-number-of-events-that-can-be-attended
public class S01353
{
    public int MaxEvents(int[][] events)
    {
        var priorityQueue = new PriorityQueue<int, int>();
        Array.Sort(events, (a, b) => a[0].CompareTo(b[0]));

        var i = 0;
        var result = 0;
        var n = events.Length;

        for (var day = 1; day <= 100_000; ++day)
        {
            while (priorityQueue.Count > 0 && priorityQueue.Peek() < day)
            {
                priorityQueue.Dequeue();
            }

            while (i < n && events[i][0] == day)
            {
                priorityQueue.Enqueue(events[i][1], events[i][1]);
                ++i;
            }

            if (priorityQueue.Count > 0)
            {
                priorityQueue.Dequeue();
                ++result;
            }
        }

        return result;
    }
}