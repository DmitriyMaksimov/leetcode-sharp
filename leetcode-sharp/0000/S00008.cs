namespace leetcode_sharp;

// 8. String to Integer (atoi)
// https://leetcode.com/problems/string-to-integer-atoi
public class S00008
{
    public int MyAtoi(string s)
    {
        var span = s.AsSpan().TrimStart();
        var sign = span.StartsWith('-') ? -1 : 1;
        var i = span.StartsWith('-') || span.StartsWith('+') ? 1 : 0;

        var result = 0L;

        while (i < span.Length && char.IsDigit(span[i]))
        {
            if (!char.IsDigit(span[i]))
            {
                break;
            }

            result = result * 10 + (span[i++] - '0');

            if (sign * result <= int.MinValue)
            {
                return int.MinValue;
            }

            if (sign * result >= int.MaxValue)
            {
                return int.MaxValue;
            }
        }

        return (int)(sign * result);
    }
}
