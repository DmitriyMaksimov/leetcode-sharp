namespace leetcode_sharp;

// 3280. Convert Date to Binary
// https://leetcode.com/problems/convert-date-to-binary
public class S03280
{
    public string ConvertDateToBinary(string date)
    {
        return string.Join('-', date.Split('-').Select(s => Convert.ToString(int.Parse(s), 2)));
    }
}
