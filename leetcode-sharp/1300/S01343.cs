namespace leetcode_sharp;

// 1343. Number of Sub-arrays of Size K and Average Greater than or Equal to Threshold
// https://leetcode.com/problems/number-of-sub-arrays-of-size-k-and-average-greater-than-or-equal-to-threshold
public class S01343
{
    public int NumOfSubarrays(int[] arr, int k, int threshold)
    {
        var count = 0;

        for (int low = -1, high = 0, sumOfWin = 0, target = k * threshold; high < arr.Length; ++high)
        {
            sumOfWin += arr[high];

            if (high - low == k)
            {
                if (sumOfWin >= target)
                {
                    ++count;
                }

                sumOfWin -= arr[++low];
            }
        }

        return count;
    }
}
