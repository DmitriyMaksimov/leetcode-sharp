namespace leetcode_sharp;

// 1410. HTML Entity Parser
// https://leetcode.com/problems/html-entity-parser
public class S01410
{
    public string EntityParser(string text)
    {
        var replacements = new Dictionary<string, char>
        {
            { "&gt;", '>' },
            { "&lt;", '<' } ,
            { "&amp;", '&' },
            { "&quot;", '"' },
            { "&apos;", '\'' },
            { "&frasl;", '/' }
        };

        var startIndex = 0;
        var currentIndex = 0;
        var textArray = new char[text.Length];

        for (var i = 0; i < textArray.Length; ++i, ++currentIndex)
        {
            textArray[currentIndex] = text[i];

            switch (textArray[currentIndex])
            {
                case '&':
                    startIndex = currentIndex;
                    break;

                case ';':
                    var length = currentIndex - startIndex + 1;

                    foreach (var (key, value) in replacements)
                    {
                        if (textArray.AsSpan(startIndex, length).SequenceEqual(key))
                        {
                            currentIndex = startIndex;
                            textArray[currentIndex] = value;
                            break;
                        }
                    }

                    startIndex = currentIndex + 1;
                    break;
            }
        }

        return new string(textArray, 0, currentIndex);
    }
}
