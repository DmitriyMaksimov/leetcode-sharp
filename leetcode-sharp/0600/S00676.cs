namespace leetcode_sharp;

// 676. Implement Magic Dictionary
// https://leetcode.com/problems/implement-magic-dictionary
public static class S00676
{
    public class MagicDictionary
    {
        private readonly HashSet<string> _words = [];
        private readonly Dictionary<string, int> _modifiedWords = new();

        public void BuildDict(string[] dictionary)
        {
            _words.Clear();
            _modifiedWords.Clear();

            foreach (var word in dictionary)
            {
                _words.Add(word);

                for (var i = 0; i < word.Length; i++)
                {
                    var modified = word[..i] + "*" + word[(i + 1)..];

                    _modifiedWords[modified] = _modifiedWords.GetValueOrDefault(modified) + 1;
                }
            }
        }

        public bool Search(string searchWord)
        {
            for (var i = 0; i < searchWord.Length; i++)
            {
                var modified = searchWord[..i] + "*" + searchWord[(i + 1)..];

                if (_modifiedWords.TryGetValue(modified, out var word))
                {
                    var exactMatch = _words.Contains(searchWord);

                    if (!exactMatch || word > 1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
