namespace leetcode_sharp;

// 3663. Find The Least Frequent Digit
// https://leetcode.com/problems/find-the-least-frequent-digit
public class S03663
{
    public int GetLeastFrequentDigit(int n)
    {
        var digitsFrequencies = new Dictionary<int, int>();

        while (n > 0)
        {
            var digit = n % 10;
            digitsFrequencies[digit] = digitsFrequencies.GetValueOrDefault(digit) + 1;
            n /= 10;
        }

        return digitsFrequencies.OrderBy(x => x.Value).ThenBy(x => x.Key).Select(x => x.Key).First();
    }
}