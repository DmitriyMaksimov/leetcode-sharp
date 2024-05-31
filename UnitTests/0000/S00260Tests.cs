using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00260Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00260();
        sut.SingleNumber([1, 2, 1, 3, 2, 5]).Should().BeEquivalentTo([3, 5]);
    }

    [Test]
    public void T2()
    {
        var sut = new S00260();
        sut.SingleNumber([-1, 0]).Should().BeEquivalentTo([-1, 0]);
    }

    [Test]
    public void T3()
    {
        var sut = new S00260();
        sut.SingleNumber([0, 1]).Should().BeEquivalentTo([0, 1]);
    }
}