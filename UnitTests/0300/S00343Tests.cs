using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00343Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00343();
        sut.IntegerBreak(2).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00343();
        sut.IntegerBreak(10).Should().Be(36);
    }
}