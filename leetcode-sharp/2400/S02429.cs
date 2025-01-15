using System.Numerics;

namespace leetcode_sharp;

// 2429. Minimize XOR
// https://leetcode.com/problems/minimize-xor
public class S02429
{
    public int MinimizeXor(int num1, int num2)
    {
        var bitsCount = BitOperations.PopCount((uint)num2);
        var result = (1 << bitsCount) - 1;

        for (int l1 = 30, l2 = bitsCount - 1; result < num1 && l2 >= 0; --l1, --l2)
        {
            while (((1 << l1) & num1) == 0)
            {
                --l1;
            }

            result += (1 << l1) - (1 << l2);
        }

        return result;
    }
}
