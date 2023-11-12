namespace leetcode_sharp;

// 2716. Minimize String Length
// https://leetcode.com/problems/minimize-string-length
public class S02716
{
    public int MinimizedStringLength(string s)
    {
        return s.ToCharArray().Distinct().Count();
    }
}