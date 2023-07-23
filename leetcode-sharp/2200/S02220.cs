namespace leetcode_sharp;

// 2220. Minimum Bit Flips to Convert Number
// https://leetcode.com/problems/minimum-bit-flips-to-convert-number/
public class S02220
{
    public int MinBitFlips(int start, int goal)
    {
        return  System.Numerics.BitOperations.PopCount((uint) (start ^ goal));
    }
}