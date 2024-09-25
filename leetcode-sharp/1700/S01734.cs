namespace leetcode_sharp;

// 1734. Decode XORed Permutation
// https://leetcode.com/problems/decode-xored-permutation
public class S01734
{
    public int[] Decode(int[] encoded)
    {
        var n = 0;
        var result = new int[encoded.Length + 1];

        for (var i = 0; i <= encoded.Length + 1; ++i)
        {
            n ^= i;
            if (i < encoded.Length + 1 && i % 2 == 1)
            {
                n ^= encoded[i];
            }
        }

        result[0] = n;

        for (var i = 0; i < encoded.Length; ++i)
        {
            result[i + 1] = result[i] ^ encoded[i];
        }

        return result;
    }
}
