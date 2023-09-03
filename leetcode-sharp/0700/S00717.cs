namespace leetcode_sharp;

// 717. 1-bit and 2-bit Characters
// https://leetcode.com/problems/1-bit-and-2-bit-characters/
public class S00717
{
    public bool IsOneBitCharacter(int[] bits)
    {
        var i = 0;

        while (i < bits.Length - 1)
        {
            if (bits[i] == 1)
            {
                i += 2;
            }
            else
            {
                i++;
            }
        }

        return i == bits.Length - 1;
    }
}