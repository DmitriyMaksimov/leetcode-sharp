namespace leetcode_sharp;

// 2517. Maximum Tastiness of Candy Basket
// https://leetcode.com/problems/maximum-tastiness-of-candy-basket
public class S02517
{
    public int MaximumTastiness(int[] price, int k)
    {
        Array.Sort(price);
        var n = price.Length;
        var left = 0;
        var right = price[n - 1] - price[0];

        while (left < right)
        {
            var mid = 1 + left + (right - left) / 2;

            if (Search(mid, price, k))
            {
                left = mid;
            }
            else
            {
                right = mid - 1;
            }
        }

        return left;
    }

    private static bool Search(int target, int[] price, int k)
    {
        var prev = price[0];
        var c = 1;
        for (var i = 1; i < price.Length; i++)
        {
            if (price[i] - prev >= target)
            {
                c++;
                prev = price[i];
            }

            if (c == k)
            {
                return true;
            }
        }

        return false;
    }
}
