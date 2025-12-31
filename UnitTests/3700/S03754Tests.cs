using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03754))]
public class S03754Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03754();
        Assert.That(sut.SumAndMultiply(10203004), Is.EqualTo(12340));
    }

    [Test]
    public void T2()
    {
        var sut = new S03754();
        Assert.That(sut.SumAndMultiply(1000), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03754();
        Assert.That(sut.SumAndMultiply(1), Is.EqualTo(1));
    }

    [Test]
    public void T4()
    {
        var sut = new S03754();
        Assert.That(sut.SumAndMultiply(0), Is.Zero);
    }
}