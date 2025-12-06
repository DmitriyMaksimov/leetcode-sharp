namespace leetcode_sharp;

// 3726. Remove Zeros in Decimal Representation
// https://leetcode.com/problems/remove-zeros-in-decimal-representation
public class S03726
{
    public long RemoveZeros(long n)
    {
        return long.Parse(n.ToString().Replace("0", ""));
    }
}