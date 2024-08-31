namespace leetcode_sharp;

// 3271. Hash Divided String
// https://leetcode.com/problems/hash-divided-string
public class S03271
{
    public string StringHash(string s, int k)
    {
        var chars = new List<char>(s.Length / k);

        foreach (var subString in s.Chunk(k))
        {
            var hash = subString.Sum(c => c - 'a') % 26;

            chars.Add((char)('a' + hash));
        }

        return new string(chars.ToArray());
    }
}
