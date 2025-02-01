using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02652Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02652();
        Assert.That(sut.SumOfMultiples(7), Is.EqualTo(21));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S02652();
        Assert.That(sut.SumOfMultiples(10), Is.EqualTo(40));
    }

    [Test]
    public void T3()
    {
        var sut = new S02652();
        Assert.That(sut.SumOfMultiples(9), Is.EqualTo(30));
    }
}