using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01837Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01837();
        Assert.That(sut.SumBase(34, 6), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S01837();
        Assert.That(sut.SumBase(10, 10), Is.EqualTo(1));
    }
}