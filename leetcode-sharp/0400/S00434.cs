namespace leetcode_sharp;

// 434. Number of Segments in a String
// https://leetcode.com/problems/number-of-segments-in-a-string/
public class S00434
{
    public int CountSegments(string s)
    {
        return s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }
}