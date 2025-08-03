namespace leetcode_sharp;

// 25. Reverse Nodes in k-Group
// https://leetcode.com/problems/reverse-nodes-in-k-group/
public class S00025
{
    public ListNode? ReverseKGroup(ListNode? head, int k)
    {
        if (k == 1)
        {
            return head;
        }

        var tempList = new List<int>();
        var finalList = new List<int>();
        var newNode = new ListNode();
        var finalNode = newNode;

        while (head != null)
        {
            tempList.Add(head.val);
            head = head.next;
        }

        var count = tempList.Count / k;
        var j = 0;

        for (var i = 0; i < count; i++)
        {
            var list = tempList.Skip(j).Take(k);
            j = j + k;
            list = list.Reverse();
            finalList.AddRange(list);
        }

        if (tempList.Count - finalList.Count > 0)
        {
            finalList.AddRange(tempList.Skip(finalList.Count).Take(tempList.Count - finalList.Count));
        }

        for (var i = 0; i < finalList.Count; i++)
        {
            newNode!.val = finalList[i];
            if (i != finalList.Count - 1)
            {
                newNode.next = new ListNode();
            }

            newNode = newNode.next;
        }

        return finalNode;
    }
}