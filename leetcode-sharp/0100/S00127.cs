namespace leetcode_sharp;

// 127. Word Ladder
// https://leetcode.com/problems/word-ladder/
public class S00127
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        var set = new HashSet<string>(wordList);
        if (!set.Contains(endWord))
        {
            return 0;
        }

        var queue = new Queue<string>();
        queue.Enqueue(beginWord);
        queue.Enqueue(beginWord);

        var visited = new HashSet<string>();

        var result = 1;

        while (queue.Count != 0)
        {
            var size = queue.Count;
            for (var i = 0; i < size; i++)
            {
                var word = queue.Dequeue();
                if (word == endWord)
                {
                    return result;
                }

                for (var j = 0; j < word.Length; j++)
                {
                    for (var k = 'a'; k <= 'z'; k++)
                    {
                        var arr = word.ToCharArray();
                        arr[j] = k;

                        var str = new string(arr);

                        if (set.Contains(str) && !visited.Contains(str))
                        {
                            queue.Enqueue(str);
                            visited.Add(str);
                        }
                    }
                }
            }

            ++result;
        }

        return 0;
    }
}