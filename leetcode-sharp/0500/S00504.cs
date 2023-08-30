using System.Text;

namespace leetcode_sharp;

// 504. Base 7
// https://leetcode.com/problems/base-7/
public class S00504
{
    public string ConvertToBase7(int num)
    {
        if (num == 0)
        {
            return "0";
        }

        var isNegative = num < 0;
        num = Math.Abs(num);
        var sb = new StringBuilder();
        while (num > 0)
        {
            sb.Append(num % 7);
            num /= 7;
        }

        if (isNegative)
        {
            sb.Append('-');
        }

        return new string(sb.ToString().Reverse().ToArray());
    }
}