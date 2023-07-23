using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02130Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02130();
        sut.PairSum(ListNode.Parse("[5,4,2,1]")).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S02130();
        sut.PairSum(ListNode.Parse("[4,2,2,3]")).Should().Be(7);
    }

    [Test]
    public void T3()
    {
        var sut = new S02130();
        sut.PairSum(ListNode.Parse("[1,100000]")).Should().Be(100001);
    }
}