using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01277Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01277();
        Assert.That(sut.CountSquares([
            [0, 1, 1, 1],
            [1, 1, 1, 1],
            [0, 1, 1, 1]
        ]), Is.EqualTo(15));
    }

    [Test]
    public void T2()
    {
        var sut = new S01277();
        Assert.That(sut.CountSquares([
            [1, 0, 1],
            [1, 1, 0],
            [1, 1, 0]
        ]), Is.EqualTo(7));
    }
}