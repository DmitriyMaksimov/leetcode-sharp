namespace leetcode_sharp;

// 3697. Compute Decimal Representation
// https://leetcode.com/problems/compute-decimal-representation
public class S03697
{
    public int[] DecimalRepresentation(int n)
    {
        var result = new List<int>();
        var power = 1;

        while (n > 0)
        {
            var reminder = n % 10;

            if (reminder != 0)
            {
                result.Add(reminder * power);
            }

            n /= 10;
            power *= 10;
        }

        return result.AsEnumerable().Reverse().ToArray();
    }
}