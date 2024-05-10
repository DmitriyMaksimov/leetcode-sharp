namespace leetcode_sharp;

// 786. K-th Smallest Prime Fraction
// https://leetcode.com/problems/k-th-smallest-prime-fraction
public class S00786
{
    public int[] KthSmallestPrimeFraction(int[] arr, int k)
    {
        var n = arr.Length;
        var left = 0.0;
        var right = 1.0;

        while (left < right)
        {
            var mid = left + (right - left) / 2;
            var maxFraction = 0.0;

            var total = 0;
            var p = 0;
            var q = 0;
            var j = 1;

            for (var i = 0; i < n - 1; i++)
            {
                while (j < n && arr[i] > mid * arr[j])
                {
                    j++;
                }

                total += n - j;

                if (j == n)
                {
                    break;
                }

                var f = (double)arr[i] / arr[j];

                if (f > maxFraction)
                {
                    // Store maxFraction and it's indices p and q
                    p = i;
                    q = j;
                    maxFraction = f;
                }
            }

            if (total == k)
            {
                return [arr[p], arr[q]];
            }

            if (total > k)
            {
                right = mid;
            }
            else
            {
                left = mid;
            }
        }

        return [];
    }
}