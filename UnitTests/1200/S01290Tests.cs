using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01290Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01290();
        Assert.That(sut.GetDecimalValue(ListNode.Parse("[1,0,1]")), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S01290();
        Assert.That(sut.GetDecimalValue(ListNode.Parse("[0]")), Is.EqualTo(0));
    }
}