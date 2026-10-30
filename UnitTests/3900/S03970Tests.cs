using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03970))]
public class S03970Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03970();
        Assert.That(sut.ShortestPath(3, [[0, 1, 1], [1, 2, 1], [0, 2, 3]], "aab", 1), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03970();
        Assert.That(sut.ShortestPath(3, [[0, 1, 1], [1, 2, 1], [0, 2, 3]], "aab", 2), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03970();
        Assert.That(sut.ShortestPath(3, [[0, 1, 1], [1, 2, 1]], "aaa", 2), Is.EqualTo(-1));
    }
}