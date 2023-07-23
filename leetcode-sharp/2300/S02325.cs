namespace leetcode_sharp;

// 2325. Decode the Message
// https://leetcode.com/problems/decode-the-message/
public class S02325
{
    public string DecodeMessage(string key, string message)
    {
        var cipher = new Dictionary<char, char>
        {
            [' '] = ' '
        };

        var currentChar = 'a';

        foreach (var k in key)
        {
            if (!cipher.ContainsKey(k))
            {
                cipher.Add(k, currentChar++);
            }
        }
        
        var chars = new char[message.Length];
        var index = 0;
        foreach (var ch in message)
        {
            chars[index++] = cipher[ch];
        }

        return string.Join("", chars);
    }
}