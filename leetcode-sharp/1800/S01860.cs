namespace leetcode_sharp;

// 1860. Incremental Memory Leak
// https://leetcode.com/problems/incremental-memory-leak
public class S01860
{
    public int[] MemLeak(int memory1, int memory2)
    {
        var i = 1;

        while (Math.Max(memory1, memory2) >= i)
        {
            if (memory1 >= memory2)
            {
                memory1 -= i;
            }
            else
            {
                memory2 -= i;
            }

            i++;
        }

        return [i, memory1, memory2];
    }
}