using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00509Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00509();
        Assert.That(sut.Fib(2), Is.EqualTo(1));
    }
    [Test]
    public void T2()
    {
        var sut = new S00509();
        Assert.That(sut.Fib(3), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S00509();
        Assert.That(sut.Fib(4), Is.EqualTo(3));
    }
}