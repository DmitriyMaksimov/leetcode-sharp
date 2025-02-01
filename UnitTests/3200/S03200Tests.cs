using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03200Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03200();
        Assert.That(sut.MaxHeightOfTriangle(2, 4), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03200();
        Assert.That(sut.MaxHeightOfTriangle(2, 1), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03200();
        Assert.That(sut.MaxHeightOfTriangle(1, 1), Is.EqualTo(1));
    }

    [Test]
    public void T4()
    {
        var sut = new S03200();
        Assert.That(sut.MaxHeightOfTriangle(10, 1), Is.EqualTo(2));
    }
}