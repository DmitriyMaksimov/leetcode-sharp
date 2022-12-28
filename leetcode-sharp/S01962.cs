namespace leetcode_sharp;

// 1962. Remove Stones to Minimize the Total
// https://leetcode.com/problems/remove-stones-to-minimize-the-total/
public class S01962
{
    public int MinStoneSum(int[] piles, int k)
    {
        var sum = 0;
        var queue = new PriorityQueue<int, int>();
        foreach (var pile in piles)
        {
            queue.Enqueue(pile, int.MaxValue - pile);
            sum += pile;
        }

        while (k-- > 0)
        {
            var n = queue.Dequeue();
            var decrement = n / 2;
            sum -= decrement;
            n -= decrement;
            queue.Enqueue(n, int.MaxValue - n);
        }
        
        return sum;
    }
}