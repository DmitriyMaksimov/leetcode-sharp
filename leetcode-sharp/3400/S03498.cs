namespace leetcode_sharp;

// 3498. Reverse Degree of a String
// https://leetcode.com/problems/reverse-degree-of-a-string
public class S03498
{
    public int ReverseDegree(string s)
    {
        return s.Select((t, i) => (26 - (t - 'a')) * (i + 1)).Sum();
    }
}
