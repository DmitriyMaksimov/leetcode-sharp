using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00019Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00019();
        Assert.That(sut.RemoveNthFromEnd(ListNode.Parse("[1,2,3,4,5]"), 2).AsString(), Is.EqualTo("[1,2,3,5]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00019();
        Assert.That(sut.RemoveNthFromEnd(ListNode.Parse("[1]"), 1).AsString(), Is.EqualTo("[]"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00019();
        Assert.That(sut.RemoveNthFromEnd(ListNode.Parse("[1, 2]"), 1).AsString(), Is.EqualTo("[1]"));
    }
    
    [Test]
    public void T4()
    {
        var sut = new S00019();
        Assert.That(sut.RemoveNthFromEnd(ListNode.Parse("[1, 2]"), 2).AsString(), Is.EqualTo("[2]"));
    }
}
