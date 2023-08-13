using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00148Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00148();
        sut.SortList(ListNode.Parse("[4,2,1,3]")).Should().BeEquivalentTo(ListNode.Parse("[1,2,3,4]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00148();
        sut.SortList(ListNode.Parse("[-1,5,3,4,0]")).Should().BeEquivalentTo(ListNode.Parse("[-1,0,3,4,5]"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00148();
        sut.SortList(ListNode.Parse("[]")).Should().BeEquivalentTo(ListNode.Parse("[]"));
    }
}