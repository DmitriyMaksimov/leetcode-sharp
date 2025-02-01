using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02130Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02130();
        Assert.That(sut.PairSum(ListNode.Parse("[5,4,2,1]")), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S02130();
        Assert.That(sut.PairSum(ListNode.Parse("[4,2,2,3]")), Is.EqualTo(7));
    }

    [Test]
    public void T3()
    {
        var sut = new S02130();
        Assert.That(sut.PairSum(ListNode.Parse("[1,100000]")), Is.EqualTo(100001));
    }
}