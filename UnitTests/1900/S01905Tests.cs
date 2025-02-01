using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01905Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01905();
        Assert.That(sut.CountSubIslands([[1, 1, 1, 0, 0], [0, 1, 1, 1, 1], [0, 0, 0, 0, 0], [1, 0, 0, 0, 0], [1, 1, 0, 1, 1]],
            [[1, 1, 1, 0, 0], [0, 0, 1, 1, 1], [0, 1, 0, 0, 0], [1, 0, 1, 1, 0], [0, 1, 0, 1, 0]]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01905();
        Assert.That(sut.CountSubIslands([[1, 0, 1, 0, 1], [1, 1, 1, 1, 1], [0, 0, 0, 0, 0], [1, 1, 1, 1, 1], [1, 0, 1, 0, 1]],
            [[0, 0, 0, 0, 0], [1, 1, 1, 1, 1], [0, 1, 0, 1, 0], [0, 1, 0, 1, 0], [1, 0, 0, 0, 1]]), Is.EqualTo(2));
    }
}
