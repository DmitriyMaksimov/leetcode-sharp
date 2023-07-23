namespace leetcode_sharp;

// 383. Ransom Note
// https://leetcode.com/problems/ransom-note/
public class S00383
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var noteHash = calcHash(ransomNote);
        var magazineHash = calcHash(magazine);
        
        foreach (var (ch, count) in noteHash)
        {
            if (magazineHash.GetValueOrDefault(ch) < count)
            {
                return false;
            }
        }

        return true;
    }

    private static Dictionary<char, int> calcHash(string ransomNote)
    {
        var hash = new Dictionary<char, int>();
        foreach (var ch in ransomNote)
        {
            hash[ch] = hash.GetValueOrDefault(ch) + 1;
        }

        return hash;
    }
}