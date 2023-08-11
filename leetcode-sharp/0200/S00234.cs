namespace leetcode_sharp;

// 234. Palindrome Linked List
// https://leetcode.com/problems/palindrome-linked-list/
public class S00234
{
    public bool IsPalindrome(ListNode? head)
    {
        var slow = head;
        var fast = head;

        while (fast?.next != null)
        {
            slow = slow?.next;
            fast = fast.next.next;
        }

        var prev = slow;
        slow = slow!.next;
        prev!.next = null;

        while (slow != null)
        {
            var temp = slow.next;
            slow.next = prev;
            prev = slow;
            slow = temp;
        }

        fast = head;
        slow = prev;
        while (slow != null)
        {
            if (fast?.val != slow.val)
            {
                return false;
            }

            fast = fast.next;
            slow = slow.next;
        }

        return true;
    }
}