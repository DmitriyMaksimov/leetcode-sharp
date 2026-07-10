using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03534))]
public class S03534Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03534();
        Assert.That(sut.PathExistenceQueries(5, [1, 8, 3, 4, 2], 3, [[0, 3], [2, 4]]), Is.EqualTo([1, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03534();
        Assert.That(sut.PathExistenceQueries(5, [5, 3, 1, 9, 10], 2, [[0, 1], [0, 2], [2, 3], [4, 3]]), Is.EqualTo([1, 2, -1, 1]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03534();
        Assert.That(sut.PathExistenceQueries(3, [3, 6, 1], 1, [[0, 0], [0, 1], [1, 2]]), Is.EqualTo([0, -1, -1]));
    }
}