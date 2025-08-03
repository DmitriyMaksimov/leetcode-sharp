namespace leetcode_sharp;

// 2807. Insert Greatest Common Divisors in Linked List
// https://leetcode.com/problems/insert-greatest-common-divisors-in-linked-list
public class S02807
{
    public ListNode? InsertGreatestCommonDivisors(ListNode? head)
    {
        if (head?.next is null) return head;
        
        var temp = head;

        while (temp?.next?.next is not null)
        {
            var newNode = new ListNode(Gcd(temp.val, temp.next.val), temp.next);
            temp.next = newNode;
            temp = temp.next.next;
        }

        temp!.next = new ListNode(Gcd(temp.val, temp.next!.val), temp.next);

        return head;
    }

    private static int Gcd(int p, int q)
    {
        return q == 0 ? p : Gcd(q, p % q);
    }
}