namespace leetcode_sharp;

// 1017. Convert to Base -2
// https://leetcode.com/problems/convert-to-base-2
public class S01017
{
    public string BaseNeg2(int n)
    {
        var result = new List<char>();

        while (n != 0)
        {
            result.Add((char)('0' + (n & 1)));
            n = -(n >> 1);
        }

        result.Reverse();
        return result.Count > 0 ? new string(result.ToArray()) : "0";
    }
}
