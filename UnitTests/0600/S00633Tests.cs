using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00633Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00633();
        sut.JudgeSquareSum(5).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00633();
        sut.JudgeSquareSum(3).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S00633();
        sut.JudgeSquareSum(4).Should().BeTrue();
    }
}