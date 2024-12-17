namespace leetcode_sharp;

// 421. Maximum XOR of Two Numbers in an Array
// https://leetcode.com/problems/maximum-xor-of-two-numbers-in-an-array
public class S00421
{
    public int FindMaximumXOR(int[] nums)
    {
        var result = 0;
        var mask = 0;

        for (var i = 31; i >= 0; i--)
        {
            mask |= 1 << i;
            var set = new HashSet<int>();

            foreach (var num in nums)
            {
                set.Add(num & mask);
            }

            var temp = result | (1 << i);

            if (set.Any(prefix => set.Contains(temp ^ prefix)))
            {
                result = temp;
            }
        }

        return result;
    }
}
