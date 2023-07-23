namespace leetcode_sharp;

// 2124. Check if All A's Appears Before All B's
// https://leetcode.com/problems/check-if-all-as-appears-before-all-bs/
public class S02124
{
    public bool CheckString(string s)
    {
        return !s.Contains("ba");
    }
}