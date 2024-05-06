using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02487Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02487();
        sut.RemoveNodes(ListNode.Parse("[5,2,13,3,8]")).Should().BeEquivalentTo(ListNode.Parse("[13,8]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02487();
        sut.RemoveNodes(ListNode.Parse("[1,1,1,1]")).Should().BeEquivalentTo(ListNode.Parse("[1,1,1,1]"));
    }
}