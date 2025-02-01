using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02257Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02257();
        Assert.That(sut.CountUnguarded(4, 6, [[0, 0], [1, 1], [2, 3]], [[0, 1], [2, 2], [1, 4]]), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S02257();
        Assert.That(sut.CountUnguarded(3, 3, [[1, 1]], [[0, 1], [1, 0], [2, 1], [1, 2]]), Is.EqualTo(4));
    }
}
