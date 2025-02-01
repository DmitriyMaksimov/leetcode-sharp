using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01947Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01947();
        Assert.That(sut.MaxCompatibilitySum([[1, 1, 0], [1, 0, 1], [0, 0, 1]], [[1, 0, 0], [0, 0, 1], [1, 1, 0]]), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S01947();
        Assert.That(sut.MaxCompatibilitySum([[0, 0], [0, 0], [0, 0]], [[1, 1], [1, 1], [1, 1]]), Is.EqualTo(0));
    }
}
