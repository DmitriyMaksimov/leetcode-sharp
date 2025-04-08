using System.Text;

namespace leetcode_sharp;

// 2075. Decode the Slanted Ciphertext
// https://leetcode.com/problems/decode-the-slanted-ciphertext
public class S02075
{
    public string DecodeCiphertext(string encodedText, int rows)
    {
        var n = encodedText.Length;
        var columns = n / rows;
        var sb = new StringBuilder();

        for (var i = 0; i < columns; ++i)
        {
            for (var j = i; j < n; j += columns + 1)
            {
                sb.Append(encodedText[j]);
            }
        }

        return sb.ToString().TrimEnd();
    }
}
