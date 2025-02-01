using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02544Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02544();
        Assert.That(sut.AlternateDigitSum(521), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02544();
        Assert.That(sut.AlternateDigitSum(111), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02544();
        Assert.That(sut.AlternateDigitSum(886996), Is.EqualTo(0));
    }
}