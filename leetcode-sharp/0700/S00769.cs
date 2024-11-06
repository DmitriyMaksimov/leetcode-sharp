namespace leetcode_sharp;

// 769. Max Chunks To Make Sorted
// https://leetcode.com/problems/max-chunks-to-make-sorted
public class S00769
{
    public int MaxChunksToSorted(int[] arr)
    {
        var chunks = 0;
        var max = 0;

        for (var i = 0; i < arr.Length; i++)
        {
            max = Math.Max(max, arr[i]);

            if (max == i)
            {
                chunks++;
            }
        }

        return chunks;
    }
}
