namespace leetcode_sharp;

// 1304. Find N Unique Integers Sum up to Zero
// https://leetcode.com/problems/find-n-unique-integers-sum-up-to-zero/
public class S01304
{
    public int[] SumZero(int n)
    {
        var result = new int[n];

        var i = 0;

        if (n % 2 == 1)
        {
            result[i++] = 0;
        }

        while (i < n)
        {
            result[i] = i + 1;
            result[i + 1] = -(i + 1);
            i += 2;
        }

        return result;
    }
}