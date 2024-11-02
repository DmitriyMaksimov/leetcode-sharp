namespace leetcode_sharp;

// 2074. Reverse Nodes in Even Length Groups
// https://leetcode.com/problems/reverse-nodes-in-even-length-groups
public class S02074
{
    public ListNode ReverseEvenLengthGroups(ListNode? head)
    {
        var temp = head;
        var groupNumber = 1;

        while (temp != null)
        {
            var count = 0;
            var start = temp;
            Stack<int> stack = [];

            while (count != groupNumber && temp != null)
            {
                stack.Push(temp.val);
                temp = temp.next;
                count++;
            }

            if (count % 2 == 0)
            {
                while (start != temp)
                {
                    start!.val = stack.Pop();
                    start = start.next;
                }
            }

            groupNumber++;
        }

        return head;
    }
}
