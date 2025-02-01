using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00025Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00025();
        Assert.That(sut.ReverseKGroup(ListNode.Parse("[1,2,3,4,5]"), 2).AsString(), Is.EqualTo("[2,1,4,3,5]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00025();
        Assert.That(sut.ReverseKGroup(ListNode.Parse("[1,2,3,4,5]"), 3).AsString(), Is.EqualTo("[3,2,1,4,5]"));
    }
}
