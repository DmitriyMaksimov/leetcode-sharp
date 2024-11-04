using System.Text;

namespace leetcode_sharp;

// 3163. String Compression III
// https://leetcode.com/problems/string-compression-iii
public class S03163
{
    public string CompressedString(string word)
    {
        var result = new StringBuilder();
        var count = 1;
        var ch = word[0];

        for (var i = 1; i < word.Length; i++)
        {
            if (word[i] == ch && count < 9)
            {
                count++;
            }
            else
            {
                result.Append(count).Append(ch);
                ch = word[i];
                count = 1;
            }
        }

        result.Append(count).Append(ch);

        return result.ToString();
    }
}
