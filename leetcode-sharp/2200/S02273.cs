namespace leetcode_sharp;

// 2273. Find Resultant Array After Removing Anagrams
// https://leetcode.com/problems/find-resultant-array-after-removing-anagrams/
public class S02273
{
    public IList<string> RemoveAnagrams(string[] words)
    {
        IList<string> list = new List<string>();
        var stack = new Stack<string>();

        foreach (var word in words)
        {
            var sorted = string.Concat(word.Order());
            
            if (stack.Count == 0)
            {
                stack.Push(sorted);
                list.Add(word);
            }
            else
            {
                if (!stack.Peek().Equals(sorted))
                {
                    list.Add(word);
                    stack.Push(sorted);
                }
            }
        }

        return list;
    }
}