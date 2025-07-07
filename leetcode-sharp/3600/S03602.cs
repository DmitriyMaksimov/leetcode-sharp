namespace leetcode_sharp;

// 3602. Hexadecimal and Hexatrigesimal Conversion
// https://leetcode.com/problems/hexadecimal-and-hexatrigesimal-conversion
public class S03602
{
    public string ConcatHex36(int n)
    {
        return ConvertToBase(n * n, 16) + ConvertToBase(n * n *n, 36);
    }

    private static string ConvertToBase(int number, int radix)
    {
        if (radix is < 2 or > 36)
        {
            throw new ArgumentOutOfRangeException(nameof(radix), "Radix must be between 2 and 36.");
        }

        if (number == 0)
        {
            return "0";
        }

        const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var isNegative = number < 0;
        number = Math.Abs(number);

        var result = "";

        while (number > 0)
        {
            var remainder = number % radix;
            result = chars[remainder] + result;
            number /= radix;
        }

        if (isNegative)
        {
            result = "-" + result;
        }

        return result;
    }
}