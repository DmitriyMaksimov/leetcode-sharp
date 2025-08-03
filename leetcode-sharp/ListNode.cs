using System.Text;

namespace leetcode_sharp;

public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
                                              
    // Parse from string representation, for example "[1,2,3]"
    public static ListNode? Parse(string str)
    {
        str = str.Trim();
        if (!str.StartsWith('[')) throw new ArgumentException("Should start with '['", nameof(str));
        if (!str.EndsWith(']')) throw new ArgumentException("Should end with ']'", nameof(str));

        str = str.Replace(" ", "");

        var enumerable = str[1..][..^1].Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).Select(x => int.TryParse(x, out var n) ? n : default);

        if (!enumerable.Any())
        {
            return null;
        }

        ListNode? head = null;
        ListNode? current = null;
        
        foreach (var i in enumerable)
        {
            if (head == null)
            {
                head = new ListNode(i);
                current = head;
            }
            else
            {
                current!.next = new ListNode(i);
                current = current.next;
            }
        }

        return head;
    }
}
