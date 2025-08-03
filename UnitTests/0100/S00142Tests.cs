using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00142Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00142();
        var head = ListNode.Parse("[3,2,0,-4]");
        head!.next!.next!.next = head.next;
        Assert.That(sut.DetectCycle(head)!.val, Is.EqualTo(2));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00142();
        var head = ListNode.Parse("[1,2]");
        head!.next = head;
        Assert.That(sut.DetectCycle(head)!.val, Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S00142();
        Assert.That(sut.DetectCycle(ListNode.Parse("[1]")), Is.Null);
    }
}