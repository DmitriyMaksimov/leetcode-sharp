using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03195Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03195();
        Assert.That(sut.MinimumArea([[0, 1, 0], [1, 0, 1]]), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S03195();
        Assert.That(sut.MinimumArea([[1, 0], [0, 0]]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03195();
        Assert.That(sut.MinimumArea([[0, 1]]), Is.EqualTo(1));
    }
}
