namespace leetcode_sharp;

// 3536. Maximum Product of Two Digits
// https://leetcode.com/problems/maximum-product-of-two-digits
public class S03536
{
    public int MaxProduct(int n)
    {
        return n.ToString().OrderDescending().Select(x => x - '0').Take(2).Aggregate(1, (product, val) => product * val);
    }
}
