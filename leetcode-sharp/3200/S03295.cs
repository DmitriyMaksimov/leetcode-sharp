namespace leetcode_sharp;

// 3295. Report Spam Message
// https://leetcode.com/problems/report-spam-message
public class S03295
{
    public bool ReportSpam(string[] message, string[] bannedWords)
    {
        var hashSet = bannedWords.ToHashSet();
        var count = 0;

        foreach (var word in message)
        {
            if (!hashSet.Contains(word))
            {
                continue;
            }

            if (++count == 2)
            {
                return true;
            }
        }

        return false;
    }
}