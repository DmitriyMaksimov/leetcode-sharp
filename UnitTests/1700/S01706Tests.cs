using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01706Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01706();
        sut.FindBall([[1, 1, 1, -1, -1], [1, 1, 1, -1, -1], [-1, -1, -1, 1, 1], [1, 1, 1, 1, -1], [-1, -1, -1, -1, -1]])
            .Should().Equal(1, -1, -1, -1, -1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01706();
        sut.FindBall([[-1]]).Should().Equal(-1);
    }

    [Test]
    public void T3()
    {
        var sut = new S01706();
        sut.FindBall([[1, 1, 1, 1, 1, 1], [-1, -1, -1, -1, -1, -1], [1, 1, 1, 1, 1, 1], [-1, -1, -1, -1, -1, -1]])
            .Should().Equal(0, 1, 2, 3, 4, -1);
    }
}