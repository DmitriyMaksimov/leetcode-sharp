using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00633Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00633();
        Assert.That(sut.JudgeSquareSum(5), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00633();
        Assert.That(sut.JudgeSquareSum(3), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00633();
        Assert.That(sut.JudgeSquareSum(4), Is.True);
    }
}
