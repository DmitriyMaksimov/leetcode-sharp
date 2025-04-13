using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01922Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01922();
        Assert.That(sut.CountGoodNumbers(1), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S01922();
        Assert.That(sut.CountGoodNumbers(4), Is.EqualTo(400));
    }

    [Test]
    public void T3()
    {
        var sut = new S01922();
        Assert.That(sut.CountGoodNumbers(50), Is.EqualTo(564908303));
    }
}
