namespace leetcode_sharp;

// 1359. Count All Valid Pickup and Delivery Options
// https://leetcode.com/problems/count-all-valid-pickup-and-delivery-options/
public class S01359
{
    public int CountOrders(int n)
    {
        const int modulo = 1_000_000_007;
        var res = 1L;

        for (var i = 1; i <= n; ++i)
        {
            res = res * i * (2 * i - 1) % modulo;
        }
        
        return (int)res;
    }
}