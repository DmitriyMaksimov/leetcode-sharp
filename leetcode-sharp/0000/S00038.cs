using System.Text;

namespace leetcode_sharp;

// 38. Count and Say
// https://leetcode.com/problems/count-and-say
public class S00038
{
    public string CountAndSay(int n)
    {
        var result = "1";

        var nextSequence = new StringBuilder();

        for (var i = 1; i < n; i++)
        {
            var count = 1;
            nextSequence.Clear();

            for (var j = 1; j < result.Length; j++)
            {
                if (result[j] == result[j - 1])
                {
                    count++;
                }
                else
                {
                    nextSequence.Append(count).Append(result[j - 1]);
                    count = 1;
                }
            }

            nextSequence.Append(count).Append(result[^1]);
            result = nextSequence.ToString();
        }

        return result;
    }
}
