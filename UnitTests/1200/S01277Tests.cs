using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01277Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01277();
        sut.CountSquares([
            [0, 1, 1, 1],
            [1, 1, 1, 1],
            [0, 1, 1, 1]
        ]).Should().Be(15);
    }

    [Test]
    public void T2()
    {
        var sut = new S01277();
        sut.CountSquares([
            [1, 0, 1],
            [1, 1, 0],
            [1, 1, 0]
        ]).Should().Be(7);
    }
}