namespace leetcode_sharp;

// 1016. Binary String With Substrings Representing 1 To N
// https://leetcode.com/problems/binary-string-with-substrings-representing-1-to-n
public class S01016
{
    public bool QueryString(string s, int n)
    {
        while (n > 0)
        {
            var binaryString = Convert.ToString(n, 2);

            if (!s.Contains(binaryString))
            {
                return false;
            }

            n--;
        }

        return true;
    }
}
