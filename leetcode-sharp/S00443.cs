namespace leetcode_sharp;

// 443. String Compression
// https://leetcode.com/problems/string-compression/
public class S00443
{
    public int Compress(char[] chars)
    {
        var currentEncodeIndex = 0;
        var count = 1;

        for (var i = 1; i <= chars.Length; i++)
        {
            if (i < chars.Length && chars[i] == chars[i - 1])
            {
                ++count;
            }
            else
            {
                chars[currentEncodeIndex++] = chars[i - 1];
                if (count > 1)
                {
                    var countStr = count.ToString();
                    foreach (var ch in countStr)
                    {
                        chars[currentEncodeIndex++] = ch;
                    }

                    count = 1;
                }
            }
        }

        return currentEncodeIndex;
    }
}