using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01171Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01171();
        Assert.That(sut.RemoveZeroSumSublists(ListNode.Parse("[1,2,-3,3,1]")).AsString(), Is.EqualTo("[3,1]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01171();
        Assert.That(sut.RemoveZeroSumSublists(ListNode.Parse("[1,2,3,-3,4]")).AsString(), Is.EqualTo("[1,2,4]"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01171();
        Assert.That(sut.RemoveZeroSumSublists(ListNode.Parse("[1,2,3,-3,-2]")).AsString(), Is.EqualTo("[1]"));
    }
}