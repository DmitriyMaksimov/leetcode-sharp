namespace leetcode_sharp;

// 3582. Generate Tag for Video Caption
// https://leetcode.com/problems/generate-tag-for-video-caption
public class S03582
{
    public string GenerateTag(string caption)
    {
        var words = caption.Split([' '], StringSplitOptions.RemoveEmptyEntries);

        var sb = new System.Text.StringBuilder();
        sb.Append('#');

        var first = true;
        
        foreach (var word in words)
        {
            var lettersOnly = new string(word.Where(char.IsLetter).ToArray()).ToLowerInvariant();

            if (lettersOnly.Length == 0)
            {
                continue;
            }

            string processed;

            if (first)
            {
                processed = lettersOnly;
                first = false;
            }
            else
            {
                var low = lettersOnly;
                processed = char.ToUpperInvariant(low[0]) + (low.Length > 1 ? low[1..] : "");
            }

            sb.Append(processed);
        }

        var tag = sb.ToString();

        return tag.Length > 100 ? tag[..100] : tag;
    }
}