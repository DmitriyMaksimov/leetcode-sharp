using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02520Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02520();
        Assert.That(sut.CountDigits(7), Is.EqualTo(1));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S02520();
        Assert.That(sut.CountDigits(121), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S02520();
        Assert.That(sut.CountDigits(1248), Is.EqualTo(4));
    }
}