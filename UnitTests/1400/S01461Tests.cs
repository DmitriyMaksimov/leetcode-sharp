using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01461Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01461();
        Assert.That(sut.HasAllCodes("00110110", 2), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01461();
        Assert.That(sut.HasAllCodes("0110", 1), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S01461();
        Assert.That(sut.HasAllCodes("0110", 2), Is.False);
    }
}
