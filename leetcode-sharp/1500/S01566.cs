namespace leetcode_sharp;

// 1566. Detect Pattern of Length M Repeated K or More Times
// https://leetcode.com/problems/detect-pattern-of-length-m-repeated-k-or-more-times/
public class S01566
{
    public bool ContainsPattern(int[] arr, int m, int k)
    {
        var count = 0;

        for (var i = 0; i + m < arr.Length; i++)
        {
            if (arr[i] != arr[i + m])
            {
                count = 0;
                continue;
            }

            ++count;

            if (count == (k - 1) * m)
            {
                return true;
            }
        }

        return false;
    }
}