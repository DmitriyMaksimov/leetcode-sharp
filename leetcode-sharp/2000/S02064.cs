namespace leetcode_sharp;

// 2064. Minimized Maximum of Products Distributed to Any Store
// https://leetcode.com/problems/minimized-maximum-of-products-distributed-to-any-store
public class S02064
{
    public int MinimizedMaximum(int n, int[] quantities)
    {
        var left = 1;
        var right = 100000;

        while (left < right)
        {
            var mid = left + (right - left) / 2;
            var sum = quantities.Sum(a => (a + mid - 1) / mid);

            if (sum > n)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return left;
    }
}
