using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00492Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00492();
        Assert.That(sut.ConstructRectangle(4), Is.EqualTo((int[]) [2, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00492();
        Assert.That(sut.ConstructRectangle(37), Is.EqualTo((int[]) [37, 1]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00492();
        Assert.That(sut.ConstructRectangle(122122), Is.EqualTo((int[]) [427, 286]));
    }
}