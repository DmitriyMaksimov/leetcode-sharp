namespace leetcode_sharp;

//  1980. Find Unique Binary String
// https://leetcode.com/problems/find-unique-binary-string
public class S01980
{
    public string FindDifferentBinaryString(string[] nums)
    {
        return new string(nums.Select((s, n) => s[n] == '0' ? '1' : '0').ToArray());
    }
}