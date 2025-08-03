using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02101Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02101();
        Assert.That(sut.MaximumDetonation([[2, 1, 3], [6, 1, 4]]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02101();
        Assert.That(sut.MaximumDetonation([[1, 1, 5], [10, 10, 5]]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02101();
        Assert.That(sut.MaximumDetonation([
            [1, 2, 3], [2, 3, 1], [3, 4, 2], [4, 5, 3], [5, 6, 4]
        ]), Is.EqualTo(5));
    }
}