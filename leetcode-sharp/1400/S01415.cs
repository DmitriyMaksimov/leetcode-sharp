using System.Text;

namespace leetcode_sharp;

// 1415. The k-th Lexicographical String of All Happy Strings of Length n
// https://leetcode.com/problems/the-k-th-lexicographical-string-of-all-happy-strings-of-length-n
public class S01415
{
    public string GetHappyString(int n, int k)
    {
        var prem = 1 << (n - 1);
        if (k > 3 * prem)
            return "";
        var ch = 'a' + (k - 1) / prem;
        var sb = new StringBuilder(((char)ch).ToString());

        while (prem > 1)
        {
            k = (k - 1) % prem + 1;
            prem >>= 1;
            ch = (k - 1) / prem == 0 ? 'a' + (ch == 'a' ? 1 : 0) : 'b' + (ch != 'c' ? 1 : 0);
            sb.Append((char)ch);
        }

        return sb.ToString();
    }
}