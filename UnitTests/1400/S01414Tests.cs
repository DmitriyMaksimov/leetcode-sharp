using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01414Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01414();
        Assert.That(sut.FindMinFibonacciNumbers(7), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01414();
        Assert.That(sut.FindMinFibonacciNumbers(10), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01414();
        Assert.That(sut.FindMinFibonacciNumbers(19), Is.EqualTo(3));
    }
}
