namespace leetcode_sharp;

// 1823. Find the Winner of the Circular Game
// https://leetcode.com/problems/find-the-winner-of-the-circular-game
public class S01823
{
    public int FindTheWinner(int n, int k)
    {
        var queue = new Queue<int>(Enumerable.Range(1, n));

        var count = k;

        while (queue.Count > 1)
        {
            var player = queue.Dequeue();

            if (--count > 0)
            {
                queue.Enqueue(player);
            }
            else
            {
                count = k;
            }
        }

        return queue.Dequeue();
    }
}