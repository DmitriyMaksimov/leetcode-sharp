namespace leetcode_sharp;

// 3823. Reverse Letters Then Special Characters in a String
// https://leetcode.com/problems/reverse-letters-then-special-characters-in-a-string
public class S03823
{
    public string ReverseByType(string s)
    {
        var charArray = s.ToCharArray();

        ReverseCharacters(char.IsAsciiLetter, s, charArray);
        ReverseCharacters(ch => !char.IsAsciiLetter(ch), s, charArray);

        return new string(charArray);
    }

    private static void ReverseCharacters(Predicate<char> predicate, string s, char[] charArray)
    {
        var start = 0;
        var end = s.Length - 1;
        while (start <= end)
        {
            if (predicate(charArray[start]) && predicate(charArray[end]))
            {
                (charArray[start], charArray[end]) = (charArray[end], charArray[start]);
                ++start;
                --end;
            }
            else if (predicate(charArray[start]))
            {
                --end;
            }
            else if (predicate(charArray[end]))
            {
                ++start;
            }
            else
            {
                ++start;
                --end;
            }
        }
    }
}