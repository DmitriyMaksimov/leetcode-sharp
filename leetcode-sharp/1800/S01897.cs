namespace leetcode_sharp;

// 1897. Redistribute Characters to Make All Strings Equal
// https://leetcode.com/problems/redistribute-characters-to-make-all-strings-equal/
public class S01897
{
    public bool MakeEqual(string[] words)
    {
        var counts = new int[26];
        foreach (var word in words)
        {
            foreach (var c in word)
            {
                counts[c - 'a']++;
            }
        }

        return counts.All(count => count % words.Length == 0);
    }
}