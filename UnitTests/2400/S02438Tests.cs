using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02438))]
public class S02438Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02438();
        Assert.That(sut.ProductQueries(15, [[0, 1], [2, 2], [0, 3]]), Is.EqualTo([2, 4, 64]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02438();
        Assert.That(sut.ProductQueries(2, [[0, 0]]), Is.EqualTo([2]));
    }
}