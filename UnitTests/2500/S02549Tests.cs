using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02549Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02549();
        Assert.That(sut.DistinctIntegers(5), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02549();
        Assert.That(sut.DistinctIntegers(3), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S02549();
        Assert.That(sut.DistinctIntegers(1), Is.EqualTo(1));
    }
}