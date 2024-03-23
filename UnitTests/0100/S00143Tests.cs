using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00143Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00143();
        var head = ListNode.Parse("[1,2,3,4]");
        sut.ReorderList(head);
        head.Should().BeEquivalentTo(ListNode.Parse("[1,4,2,3]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00143();
        var head = ListNode.Parse("[1,2,3,4,5]");
        sut.ReorderList(head);
        head.Should().BeEquivalentTo(ListNode.Parse("[1,5,2,4,3]"));
    }
}