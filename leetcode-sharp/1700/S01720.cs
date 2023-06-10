namespace leetcode_sharp;

// 1720. Decode XORed Array
// https://leetcode.com/problems/decode-xored-array/
public class S01720
{
    public int[] Decode(int[] encoded, int first)
    {
        var decoded = new int[encoded.Length + 1];
        decoded[0] = first;

        for (var i = 0; i < encoded.Length; i++)
        {
            decoded[i + 1] = encoded[i] ^ decoded[i];
        }
        
        return decoded;
    }
}