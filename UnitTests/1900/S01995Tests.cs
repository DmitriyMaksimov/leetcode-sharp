using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01995Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01995();
        Assert.That(sut.CountQuadruplets([1, 2, 3, 6]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01995();
        Assert.That(sut.CountQuadruplets([3, 3, 6, 4, 5]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01995();
        Assert.That(sut.CountQuadruplets([1, 1, 1, 3, 5]), Is.EqualTo(4));
    }
}