namespace leetcode_sharp;

// 937. Reorder Data in Log Files
// https://leetcode.com/problems/reorder-data-in-log-files
public class S00937
{
    public string[] ReorderLogFiles(string[] logs)
    {
        return logs.Where(IsLetterLog).OrderBy(GetContent).ThenBy(GetIdentifier).Concat(logs.Where(IsDigitLog)).ToArray();

        bool IsLetterLog(string log)
        {
            var indexOfSpace = log.IndexOf(' ');
            var characterAfterSpace = log[indexOfSpace + 1];
            return char.IsLetter(characterAfterSpace);
        }

        bool IsDigitLog(string log)
        {
            var indexOfSpace = log.IndexOf(' ');
            var characterAfterSpace = log[indexOfSpace + 1];
            return char.IsDigit(characterAfterSpace);
        }

        string GetContent(string log)
        {
            var indexOfSpace = log.IndexOf(' ');
            return log[(indexOfSpace + 1)..];
        }

        string GetIdentifier(string log)
        {
            var indexOfSpace = log.IndexOf(' ');
            return log[..indexOfSpace];
        }
    }
}
