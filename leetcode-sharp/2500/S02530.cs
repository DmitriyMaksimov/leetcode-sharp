namespace leetcode_sharp;

// 2530. Maximal Score After Applying K Operations
// https://leetcode.com/problems/maximal-score-after-applying-k-operations
public class S02530
{
    public long MaxKelements(int[] nums, int k)
    {
        var queue = new PriorityQueue<int, int>();

        foreach (var n in nums)
        {
            queue.Enqueue(n, int.MaxValue - n);
        }

        long answer = 0;

        for (var i = 0; i < k; i++)
        {
            var element = queue.Dequeue();
            answer += element;

            var ceiling = (int)Math.Ceiling((double)element / 3);
            queue.Enqueue(ceiling, int.MaxValue - ceiling);
        }

        return answer;
    }
}
