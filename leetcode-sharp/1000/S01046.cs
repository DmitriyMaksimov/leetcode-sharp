namespace leetcode_sharp;

// 1046. Last Stone Weight
// https://leetcode.com/problems/last-stone-weight/
public class S01046
{
    public int LastStoneWeight(int[] stones)
    {
        var queue = new PriorityQueue<int, int>();
        foreach (var stone in stones)
        {
            queue.Enqueue(stone, -stone);
        }

        while (queue.Count > 1)
        {
            // Choose the heaviest two stones and smash them together
            // Suppose the heaviest two stones have weights x and y with x <= y
            var y = queue.Dequeue();
            var x = queue.Dequeue();

            if (y != x)
            {
                // the stone of weight x is destroyed, and the stone of weight y has new weight y - x
                var newWeight = y - x;
                queue.Enqueue(newWeight, -newWeight);
            }
        }

        return queue.Count > 0 ? queue.Dequeue() : 0;
    }
}