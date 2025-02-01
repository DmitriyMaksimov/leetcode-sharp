using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00343Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00343();
        Assert.That(sut.IntegerBreak(2), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00343();
        Assert.That(sut.IntegerBreak(10), Is.EqualTo(36));
    }
}