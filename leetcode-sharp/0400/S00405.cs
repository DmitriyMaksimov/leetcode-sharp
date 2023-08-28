using System.Text;

namespace leetcode_sharp;

// 405. Convert a Number to Hexadecimal
// https://leetcode.com/problems/convert-a-number-to-hexadecimal/
public class S00405
{
    private char[] _hexDigits = "0123456789abcdef".ToCharArray();

    public string ToHex(int num)
    {
        if (num == 0)
        {
            return "0";
        }

        var sb = new StringBuilder();
        const int mask = 0xF;
        for (var i = 0; i < 8; i++)
        {
            var digit = num & mask;
            sb.Insert(0, _hexDigits[digit]);
            num >>= 4;
        }

        return sb.ToString().TrimStart('0');
    }
}