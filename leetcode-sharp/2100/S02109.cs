namespace leetcode_sharp;

// 2109. Adding Spaces to a String
// https://leetcode.com/problems/adding-spaces-to-a-string
public class S02109
{
    public string AddSpaces(string s, int[] spaces)
    {
        var newLength = s.Length + spaces.Length;
        var result = new char[newLength];

        var sIndex = 0;
        var spaceIndex = 0;
        var resultIndex = 0;

        while (sIndex < s.Length)
        {
            if (spaceIndex < spaces.Length && sIndex == spaces[spaceIndex])
            {
                result[resultIndex++] = ' ';
                spaceIndex++;
            }

            result[resultIndex++] = s[sIndex++];
        }

        return new string(result);
    }
}
