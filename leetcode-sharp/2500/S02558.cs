namespace leetcode_sharp;

// 
// https://leetcode.com/problems/take-gifts-from-the-richest-pile
public class S02558
{
    public long PickGifts(int[] gifts, int k)
    {
        var ans = 0L;
        var queue = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));

        for (var i = 0; i < gifts.Length; i++)
        {
            queue.Enqueue(i, gifts[i]);
        }

        while (k-- > 0)
        {
            if (queue.TryDequeue(out var element, out var priority))
            {
                queue.Enqueue(element, (int)Math.Floor(Math.Sqrt(priority)));
            }
        }

        while (queue.Count > 0)
        {
            if (queue.TryDequeue(out _, out var priority))
            {
                ans += priority;
            }
        }

        return ans;
    }
}