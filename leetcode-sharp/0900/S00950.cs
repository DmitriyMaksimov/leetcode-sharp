namespace leetcode_sharp;

// 950. Reveal Cards In Increasing Order
// https://leetcode.com/problems/reveal-cards-in-increasing-order
public class S00950
{
    public int[] DeckRevealedIncreasing(int[] deck)
    {
        Array.Sort(deck);
        var n = deck.Length;
        var ans = new int[n];
        var q = new Queue<int>(Enumerable.Range(0, n));

        for (var i = 0; i < n; i++)
        {
            ans[q.Dequeue()] = deck[i];
            if (q.Count > 0)
            {
                q.Enqueue(q.Dequeue());
            }
        }

        return ans;
    }
}