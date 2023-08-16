namespace leetcode_sharp;

// 1945. Sum of Digits of String After Convert
// https://leetcode.com/problems/sum-of-digits-of-string-after-convert/
public class S01945
{
    public int GetLucky(string s, int k)
    {
        var n = s.Select(ch => ch - 'a' + 1).Select(i => i / 10 + i % 10).Sum();

        while (k-- > 1)
        {
            n = n / 1000 + n % 1000 / 100 + n % 100 / 10 + n % 10;
        }
        
        
        return (int) n;
    }
}