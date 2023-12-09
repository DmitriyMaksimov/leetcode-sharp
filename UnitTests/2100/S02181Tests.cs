using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02181Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02181();
        sut.MergeNodes(ListNode.Parse("[0,3,1,0,4,5,2,0]")).Should().BeEquivalentTo(ListNode.Parse("[4,11]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02181();
        sut.MergeNodes(ListNode.Parse("[0,1,0,3,0,2,2,0]")).Should().BeEquivalentTo(ListNode.Parse("[1,3,4]"));
    }
}