using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03532))]
public class S03532Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03532();
        Assert.That(sut.PathExistenceQueries(2, [1, 3], 1, [[0, 0], [0, 1]]), Is.EqualTo([true, false]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03532();
        Assert.That(sut.PathExistenceQueries(4, [2, 5, 6, 8], 2, [[0, 1], [0, 2], [1, 3], [2, 3]]), Is.EqualTo([false, false, true, true]));
    }
}
