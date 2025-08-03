using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00463Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00463();
        Assert.That(sut.IslandPerimeter([
            [0, 1, 0, 0], [1, 1, 1, 0], [0, 1, 0, 0], [1, 1, 0, 0]
        ]), Is.EqualTo(16));
    }

    [Test]
    public void T2()
    {
        var sut = new S00463();
        Assert.That(sut.IslandPerimeter([[1]]), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S00463();
        Assert.That(sut.IslandPerimeter([[1, 0]]), Is.EqualTo(4));
    }
}