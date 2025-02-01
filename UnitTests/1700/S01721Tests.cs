using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01721Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01721();
        Assert.That(sut.SwapNodes(ListNode.Parse("[1,2,3,4,5]"), 2).AsString(), Is.EqualTo("[1,4,3,2,5]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01721();
        Assert.That(sut.SwapNodes(ListNode.Parse("[7,9,6,6,7,8,3,0,9,5]"), 5).AsString(), Is.EqualTo("[7,9,6,6,8,7,3,0,9,5]"));
    }
}