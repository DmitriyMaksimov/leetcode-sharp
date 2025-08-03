using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01284Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01284();
        Assert.That(sut.MinFlips([[0, 0], [0, 1]]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01284();
        Assert.That(sut.MinFlips([[0]]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01284();
        Assert.That(sut.MinFlips([[1, 0, 0], [1, 0, 0]]), Is.EqualTo(-1));
    }
}