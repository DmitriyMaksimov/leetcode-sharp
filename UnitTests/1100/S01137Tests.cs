using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01137Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01137();

        Assert.That(sut.Tribonacci(4), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01137();

        Assert.That(sut.Tribonacci(25), Is.EqualTo(1389537));
    }

    [Test]
    public void T3()
    {
        var sut = new S01137();

        Assert.That(sut.Tribonacci(37), Is.EqualTo(2082876103));
    }
}