namespace leetcode_sharp;

// 228. Summary Ranges
// https://leetcode.com/problems/summary-ranges/
public class S00228
{
    public IList<string> SummaryRanges(int[] nums)
    {
        var ranges = new List<string>();

        if (nums.Length == 0)
        {
            return ranges;
        }
        
        var startRange = nums[0];
        for (var i = 1; i < nums.Length; i++)
        {
            var prevValue = nums[i - 1];
            var currentValue = nums[i];

            if (Math.Abs(currentValue - prevValue) > 1)
            {
                addRange(ranges, startRange, prevValue);
                startRange = currentValue;
            }
        }

        addRange(ranges, startRange, nums[^1]);

        return ranges;
    }

    private static void addRange(ICollection<string> ranges, int startRange, int endRange)
    {
        ranges.Add(endRange == startRange ? $"{startRange}" : $"{startRange}->{endRange}");
    }
}