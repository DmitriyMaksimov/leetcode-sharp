namespace leetcode_sharp;

// 211. Design Add and Search Words Data Structure
// https://leetcode.com/problems/design-add-and-search-words-data-structure/
public abstract class S00211
{
    public class WordDictionary
    {
        private class Trie
        {
            private class TrieNode
            {
                private char Key { get; }
                public bool IsTerminal { get; set; }
                public TrieNode? Parent { get; init; }
                public Dictionary<char, TrieNode> Children { get; } = new();

                public TrieNode(char key, bool isTerminal = false)
                {
                    Key = key;
                    IsTerminal = isTerminal;
                }

                private string? Word
                {
                    get
                    {
                        if (!IsTerminal)
                        {
                            return null;
                        }

                        var curr = this;
                        var stack = new Stack<char>();

                        while (curr.Parent != null)
                        {
                            stack.Push(curr.Key);
                            curr = curr.Parent;
                        }

                        return new string(stack.ToArray());
                    }
                }

                /// <summary>
                /// Returns an enumerable list of key-value pairs of all the words that start 
                /// with the prefix that maps from the root node until this node.
                /// </summary>
                public IEnumerable<string> GetByPrefix()
                {
                    if (IsTerminal)
                    {
                        yield return Word!;
                    }

                    foreach (var childKeyVal in Children)
                    {
                        foreach (var terminalNode in childKeyVal.Value.GetByPrefix())
                        {
                            yield return terminalNode;
                        }
                    }
                }

                /// <summary>
                /// Remove this element upto its parent.
                /// </summary>
                public void Remove()
                {
                    IsTerminal = false;

                    if (Children.Count == 0 && Parent != null)
                    {
                        Parent.Children.Remove(Key);

                        if (!Parent.IsTerminal)
                        {
                            Parent.Remove();
                        }
                    }
                }

                /// <summary>
                /// IComparer interface implementation
                /// </summary>
                public int CompareTo(TrieNode? other)
                {
                    if (other == null)
                    {
                        return -1;
                    }

                    return Key.CompareTo(other.Key);
                }

                public void Clear()
                {
                    Children.Clear();
                }
            }

            private TrieNode _root;

            public Trie()
            {
                Count = 0;
                _root = new TrieNode(' ');
            }

            private int Count { get; set; }

            public void Add(string word)
            {
                if (string.IsNullOrEmpty(word))
                {
                    throw new ArgumentException("Word is empty or null.");
                }

                var current = _root;

                foreach (var ch in word)
                {
                    if (!current.Children.ContainsKey(ch))
                    {
                        var newTrieNode = new TrieNode(ch) {Parent = current};
                        current.Children.Add(ch, newTrieNode);
                    }

                    current = current.Children[ch];
                }

                ++Count;
                current.IsTerminal = true;
            }

            public void Remove(string word)
            {
                if (string.IsNullOrEmpty(word))
                {
                    throw new ArgumentException("Word is empty or null.");
                }

                var current = _root;

                foreach (var ch in word)
                {
                    if (!current.Children.ContainsKey(ch))
                    {
                        throw new KeyNotFoundException("Word doesn't belong to trie.");
                    }

                    current = current.Children[ch];
                }

                if (!current.IsTerminal)
                {
                    throw new KeyNotFoundException("Word doesn't belong to trie.");
                }

                --Count;
                current.Remove();
            }

            public bool ContainsWord(string word)
            {
                if (string.IsNullOrEmpty(word))
                {
                    throw new InvalidOperationException("Word is either null or empty.");
                }

                var current = _root;

                foreach (var ch in word)
                {
                    if (!current.Children.ContainsKey(ch))
                    {
                        return false;
                    }

                    current = current.Children[ch];
                }

                return current.IsTerminal;
            }

            public bool ContainsPrefix(string prefix)
            {
                if (string.IsNullOrEmpty(prefix))
                {
                    throw new InvalidOperationException("Prefix is either null or empty.");
                }

                var current = _root;

                foreach (var ch in prefix)
                {
                    if (!current.Children.ContainsKey(ch))
                    {
                        return false;
                    }

                    current = current.Children[ch];
                }

                return true;
            }

            public bool ContainsWordByMask(string mask)
            {
                if (string.IsNullOrEmpty(mask))
                {
                    throw new InvalidOperationException("Prefix is either null or empty.");
                }

                var nodes = new List<TrieNode> {_root};

                foreach (var ch in mask)
                {
                    if (ch != '.' && !nodes.Any(node => node.Children.ContainsKey(ch)))
                    {
                        return false;
                    }

                    if (ch == '.')
                    {
                        // Include all children
                        nodes = nodes.SelectMany(node => node.Children.Values).ToList();
                    }
                    else
                    {
                        // Select children with ch
                        nodes = nodes.Where(node => node.Children.ContainsKey(ch)).Select(node => node.Children[ch]).ToList();
                    }
                }

                return nodes.Any(node => node.IsTerminal);
            }

            /// <summary>
            /// Searches the entire trie for words that has a specific prefix.
            /// </summary>
            public IEnumerable<string?> SearchByPrefix(string prefix)
            {
                if (string.IsNullOrEmpty(prefix))
                {
                    throw new InvalidOperationException("Prefix is either null or empty.");
                }

                var current = _root;

                foreach (var ch in prefix)
                {
                    if (!current.Children.ContainsKey(ch))
                    {
                        return [];
                    }

                    current = current.Children[ch];
                }

                return current.GetByPrefix();
            }

            public void Clear()
            {
                Count = 0;
                _root.Clear();
                _root = new TrieNode(' ');
            }
        }

        private readonly Trie _trie;

        public WordDictionary()
        {
            _trie = new Trie();
        }

        public void AddWord(string word)
        {
            _trie.Add(word);
        }

        public bool Search(string word)
        {
            var indexOfDot = word.IndexOf('.');

            if (indexOfDot < 0)
            {
                return _trie.ContainsWord(word);
            }

            return _trie.ContainsWordByMask(word);
        }
    }
}