using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00201Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00201();
        sut.RangeBitwiseAnd(5, 7).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00201();
        sut.RangeBitwiseAnd(0, 0).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S00201();
        sut.RangeBitwiseAnd(1, 2147483647).Should().Be(0);
    }
}