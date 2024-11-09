using System.Text;

namespace leetcode_sharp;

// 3304. Find the K-th Character in String Game I
// https://leetcode.com/problems/find-the-k-th-character-in-string-game-i
public class S03304
{
    public char KthCharacter(int k)
    {
        var sb = new StringBuilder("a");

        while (sb.Length < k)
        {
            sb.Append(sb.ToString().Select(ch => ch == 'z' ? 'a' : (char)(ch + 1)).ToArray());
        }

        return sb[k - 1];
    }
}