using System.Text;

namespace leetcode_sharp;

// 3210. Find the Encrypted String
// https://leetcode.com/problems/find-the-encrypted-string
public class S03210
{
    public string GetEncryptedString(string s, int k)
    {
        var n = s.Length;
        var sb = new StringBuilder();

        for (var i = 0; i < s.Length; i++)
        {
            sb.Append(s[(i + k) % n]);
        }

        return sb.ToString();
    }
}