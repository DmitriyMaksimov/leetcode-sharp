namespace leetcode_sharp;

// 2683. Neighboring Bitwise XOR
// https://leetcode.com/problems/neighboring-bitwise-xor
public class S02683
{
    public bool DoesValidArrayExist(int[] derived)
    {
        return derived.Sum() % 2 == 0;
    }
}
