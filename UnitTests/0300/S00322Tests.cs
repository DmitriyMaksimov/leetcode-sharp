using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00322Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00322();
        Assert.That(sut.CoinChange([1, 2, 5], 11), Is.EqualTo(3));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00322();
        Assert.That(sut.CoinChange([2], 3), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S00322();
        Assert.That(sut.CoinChange([1], 0), Is.EqualTo(0));
    }
}