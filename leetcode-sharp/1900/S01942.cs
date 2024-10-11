namespace leetcode_sharp;

// 1942. The Number of the Smallest Unoccupied Chair
// https://leetcode.com/problems/the-number-of-the-smallest-unoccupied-chair
public class S01942
{
    public int SmallestChair(int[][] times, int targetFriend)
    {
        var list = times.Select((t, i) => (t[0], t[1], i)).OrderBy(t => t.Item1).ThenBy(t => t.Item2).ToList();
        var pq = new PriorityQueue<int, int>();
        var occupied = new PriorityQueue<(int, int), int>();

        for (var i = 0; i < times.Length; i++)
        {
            pq.Enqueue(i, i);
        }

        for (var i = 0; i < list.Count; i++)
        {
            while (occupied.Count > 0 && list[i].Item1 >= occupied.Peek().Item1)
            {
                pq.Enqueue(occupied.Peek().Item2, occupied.Peek().Item2);
                occupied.Dequeue();
            }

            if (list[i].Item3 == targetFriend)
            {
                return pq.Dequeue();
            }

            occupied.Enqueue((list[i].Item2, pq.Dequeue()), list[i].Item2);
        }

        return -1;
    }
}
