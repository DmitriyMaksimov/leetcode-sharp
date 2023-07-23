namespace leetcode_sharp;

// 461. Hamming Distance
// https://leetcode.com/problems/hamming-distance/
public class S00461
{
    public int HammingDistance(int x, int y)
    {
        return System.Numerics.BitOperations.PopCount((uint) (x ^ y));
    }
}