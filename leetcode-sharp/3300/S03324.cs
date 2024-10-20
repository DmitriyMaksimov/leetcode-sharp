namespace leetcode_sharp;

// 3324. Find the Sequence of Strings Appeared on the Screen
// https://leetcode.com/problems/find-the-sequence-of-strings-appeared-on-the-screen
public class S03324
{
    public IList<string> StringSequence(string target)
    {
        List<string> result = [];
        var s = "a";

        foreach (var c in target)
        {
            result.Add(s);

            var charArray = s.ToCharArray();

            while (charArray[^1] != c)
            {
                var lastChar = charArray[^1];
                charArray[^1]  = lastChar == 'z' ? 'a' : (char)(lastChar + 1);
                result.Add(new string(charArray));
            }

            s = new string(charArray) + 'a';
        }

        return result;
    }
}
