using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01466Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01466();
        Assert.That(sut.MinReorder(6, [[0, 1], [1, 3], [2, 3], [4, 0], [4, 5]]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01466();
        Assert.That(sut.MinReorder(6, [[1, 0], [2, 0]]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01466();
        Assert.That(sut.MinReorder(5, [[1, 0], [1, 2], [3, 2], [3, 4]]), Is.EqualTo(2));
    }
}