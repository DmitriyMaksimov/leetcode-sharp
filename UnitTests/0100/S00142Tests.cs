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
        head.next.next.next = head.next;
        sut.DetectCycle(head).val.Should().Be(2);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00142();
        var head = ListNode.Parse("[1,2]");
        head.next = head;
        sut.DetectCycle(head).val.Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00142();
        sut.DetectCycle(ListNode.Parse("[1]")).Should().BeNull();
    }
}