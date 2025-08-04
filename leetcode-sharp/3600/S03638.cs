namespace leetcode_sharp;

// 3638. Maximum Balanced Shipments
// https://leetcode.com/problems/maximum-balanced-shipments
public class S03638
{
    public int MaxBalancedShipments(int[] weight)
    {
        var previous = 0;
        var result = 0;

        foreach (var w in weight)
        {
            if (w < previous)
            {
                result++;
                previous = 0;
            }
            else
            {
                previous = w;
            }
        }

        return result;
    }
}
