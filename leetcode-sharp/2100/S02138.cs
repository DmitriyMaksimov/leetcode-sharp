namespace leetcode_sharp;

// 2138. Divide a String Into Groups of Size k
// https://leetcode.com/problems/divide-a-string-into-groups-of-size-k/
public class S02138
{
    public string[] DivideString(string s, int k, char fill)
    {
        return s.Chunk(k).Select(x => new string(x) + new string(fill, k - x.Length)).ToArray();
    }
}