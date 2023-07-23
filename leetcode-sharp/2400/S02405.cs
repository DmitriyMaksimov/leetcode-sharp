namespace leetcode_sharp;

// 2405. Optimal Partition of String
// https://leetcode.com/problems/optimal-partition-of-string/
public class S02405
{
    public int PartitionString(string s)
    {
        var count = 1;
        var existingLetters = new HashSet<char>();

        foreach (var ch in s)
        {
            if (existingLetters.Contains(ch))
            {
                // The letter is not unique for the current partition => start a new one
                ++count;
                existingLetters.Clear();
            }

            existingLetters.Add(ch);
        }

        return count;
    }
}