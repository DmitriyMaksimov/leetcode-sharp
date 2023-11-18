namespace leetcode_sharp;

// 2899. Last Visited Integers
// https://leetcode.com/problems/last-visited-integers
public class S02899
{
    public IList<int> LastVisitedIntegers(IList<string> words)
    {
        var numbers = new List<int> {-1};
        var idx = 0;
        var result = new List<int>();

        foreach (var w in words)
        {
            if (int.TryParse(w, out var val))
            {
                numbers.Add(val);
                idx = numbers.Count - 1;
            }
            else
            {
                result.Add(numbers[idx]);
                if (idx > 0) idx--;
            }
        }

        return result;
    }
}