namespace leetcode_sharp;

// 1702. Maximum Binary String After Change
// https://leetcode.com/problems/maximum-binary-string-after-change
public class S01702
{
    public string MaximumBinaryString(string binary)
    {
        var leadingOnes = binary.IndexOf('0');

        if (leadingOnes < 0)
        {
            return binary;
        }

        var zeros = 0;
        var rest = 0;

        for (var i = leadingOnes; i < binary.Length; i++)
        {
            if (binary[i] == '0')
            {
                zeros++;
            }
            else
            {
                rest++;
            }
        }

        return new string('1', leadingOnes + zeros - 1) + '0' + new string('1', rest);
    }
}