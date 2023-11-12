namespace leetcode_sharp;

// 2810. Faulty Keyboard
// https://leetcode.com/problems/faulty-keyboard
public class S02810
{
    public string FinalString(string s)
    {
        var result = "";
        
        foreach (var letter in s)
        {
            if (letter == 'i')
            {
                var reversedString = new string(result.ToCharArray().Reverse().ToArray());
                result = reversedString;
            }
            else
            {
                result += letter;
            }
        }

        return result;
    }
}