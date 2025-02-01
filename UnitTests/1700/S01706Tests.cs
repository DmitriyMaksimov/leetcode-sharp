using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01706Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01706();
        Assert.That(sut.FindBall([[1, 1, 1, -1, -1], [1, 1, 1, -1, -1], [-1, -1, -1, 1, 1], [1, 1, 1, 1, -1], [-1, -1, -1, -1, -1]]), Is.EqualTo((int[]) [1, -1, -1, -1, -1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01706();
        Assert.That(sut.FindBall([[-1]]), Is.EqualTo((int[]) [-1]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01706();
        Assert.That(sut.FindBall([[1, 1, 1, 1, 1, 1], [-1, -1, -1, -1, -1, -1], [1, 1, 1, 1, 1, 1], [-1, -1, -1, -1, -1, -1]]), Is.EqualTo((int[]) [0, 1, 2, 3, 4, -1]));
    }
}