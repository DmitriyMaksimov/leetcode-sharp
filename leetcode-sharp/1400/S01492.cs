namespace leetcode_sharp;

// 1492. The kth Factor of n
// https://leetcode.com/problems/the-kth-factor-of-n
public class S01492
{
    public int KthFactor(int n, int k)
    {
        for (var d = 1; d <= n / 2; ++d)
        {
            if (n % d == 0 && --k == 0)
            {
                return d;
            }
        }

        return k == 1 ? n : -1;
    }
}
