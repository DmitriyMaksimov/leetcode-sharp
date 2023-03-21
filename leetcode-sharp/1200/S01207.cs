namespace leetcode_sharp;

// 1207. Unique Number of Occurrences
// https://leetcode.com/problems/unique-number-of-occurrences/
public class S01207
{
    public bool UniqueOccurrences(int[] arr)
    {
        var occurrences = new Dictionary<int, int>();
        
        foreach (var n in arr)
        {
            occurrences[n] = occurrences.GetValueOrDefault(n) + 1;
        }

        return occurrences.Count == occurrences.Values.Distinct().Count();
    }
}