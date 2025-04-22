using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02338Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02338();
        Assert.That(sut.IdealArrays(2, 5), Is.EqualTo(10));
    }

    [Test]
    public void T2()
    {
        var sut = new S02338();
        Assert.That(sut.IdealArrays(5, 3), Is.EqualTo(11));
    }

    [Test]
    public void T3()
    {
        var sut = new S02338();
        Assert.That(sut.IdealArrays(10000, 10000), Is.EqualTo(22940607));
    }
}
