using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00141Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00141();
        var head = ListNode.Parse("[3,2,0,-4]");
        head.next.next.next = head.next;
        sut.HasCycle(head).Should().BeTrue();
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00141();
        var head = ListNode.Parse("[1,2]");
        head.next = head;
        sut.HasCycle(head).Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S00141();
        sut.HasCycle(ListNode.Parse("[1]")).Should().BeFalse();
    }
}