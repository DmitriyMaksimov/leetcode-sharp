using System.Text;

namespace leetcode_sharp;

// 
// https://leetcode.com/problems/find-unique-binary-string
public class S01980
{
    public string FindDifferentBinaryString(string[] nums)
    {
        var sb = new StringBuilder();

        for (var i = 0; i < nums.Length; i++)
        {
            sb.Append(nums[i][i] == '0' ? '1' : '0');
        }

        return sb.ToString();
    }
}