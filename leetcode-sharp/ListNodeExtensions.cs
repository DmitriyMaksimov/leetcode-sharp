using System.Text;

namespace leetcode_sharp;

public static class ListNodeExtensions
{
    public static string AsString(this ListNode? root)
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append('[');
        var first = true;

        while (root != null)
        {
            if (!first) stringBuilder.Append(',');
            stringBuilder.Append(root.val);
            first = false;
            root = root.next;
        }

        stringBuilder.Append(']');

        return stringBuilder.ToString();
    }
}
